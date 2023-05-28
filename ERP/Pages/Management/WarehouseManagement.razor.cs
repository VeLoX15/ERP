using ERP.Core.Filters;
using ERP.Core.Services;
using ERP.Core.Validators;
using ERP.Core.Models;
using DbController.MySql;
using DbController;
using Microsoft.AspNetCore.Components;

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
        public int SelectedWarehouse { get; set; }
        public List<Section> Sections { get; set; } = new();
        public int SelectedSection { get; set; }


        protected override async Task OnInitializedAsync()
        {
            using IDbController dbController = new MySqlController(AppdatenService.ConnectionString);
            Warehouses = await warehouseService.GetAllAsync(dbController);
        }

        private async Task UpdateSections()
        {
            Sections = await GetSectionsForWarehouse(SelectedWarehouse);
            StateHasChanged();
        }

        private async Task<List<Section>> GetSectionsForWarehouse(int warehouseId)
        {
            using IDbController dbController = new MySqlController(AppdatenService.ConnectionString);
            return await sectionService.GetSectionsByWarehouseId(warehouseId, dbController);
        }

        private async Task OnSelectedWarehouseChanged(ChangeEventArgs e)
        {
            SelectedWarehouse = Convert.ToInt32(e.Value);
            await UpdateSections();
        }
    }
}