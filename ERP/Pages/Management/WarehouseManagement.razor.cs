using ERP.Core.Filters;
using ERP.Core.Services;
using ERP.Core.Validators;
using ERP.Core.Models;
using DbController.MySql;
using DbController;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Text.Json;

namespace ERP.Pages.Management
{
    public partial class WarehouseManagement
    {
        public WarehouseFilter Filter { get; set; } = new()
        {
            Limit = AppdatenService.PageLimit
        };

        public WarehouseValidator Validator { get; set; } = new();

        public List<Warehouse> Warehouses { get; set; } = new();
        public List<Section> Sections { get; set; } = new();
        public List<Compartment> FilterData { get; set; } = new();


        protected override async Task OnInitializedAsync()
        {
            using IDbController dbController = new MySqlController(AppdatenService.ConnectionString);
            Warehouses = await warehouseService.GetAllAsync(dbController);
        }

        private async Task UpdateSections()
        {
            Sections = await GetSectionsForWarehouse(Filter.WarehouseId);
            StateHasChanged();
        }

        private async Task<List<Section>> GetSectionsForWarehouse(int warehouseId)
        {
            using IDbController dbController = new MySqlController(AppdatenService.ConnectionString);
            return await sectionService.GetSectionsByWarehouseId(warehouseId, dbController);
        }

        private async Task OnSelectedWarehouseChanged(ChangeEventArgs e)
        {
            Filter.WarehouseId = Convert.ToInt32(e.Value);
            await UpdateSections();
        }

        private async Task SendDataAsync()
        {
            using IDbController dbController = new MySqlController(AppdatenService.ConnectionString);
            FilterData = await compartmentService.GetAsync(Filter, dbController);

            string serializedArticles = JsonSerializer.Serialize(FilterData);
            await JSRuntime.InvokeVoidAsync("sessionStorage.removeItem", "storages");
            await JSRuntime.InvokeVoidAsync("sessionStorage.setItem", "storages", serializedArticles);

            navigationManager.NavigateTo("/Management/Warehouses/List");
        }
    }
}