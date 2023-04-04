using Blazor.Pagination;
using DbController;
using ERP.Core.Models;
using ERP.Core.Filters;
using ERP.Core.Services;
using Microsoft.AspNetCore.Components;

namespace ERP.Pages.Admin
{
    public partial class WarehouseListing : IHasPagination
    {
        public WarehouseFilter Filter { get; set; } = new WarehouseFilter();
        public List<Warehouse> Data { get; set; } = new();
        [Parameter]
        public int Page { get; set; }
        public int TotalItems { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            await LoadAsync();
        }
        public async Task LoadAsync(bool navigateToPage1 = false)
        {
            if (navigateToPage1)
            {
                navigationManager.NavigateTo("/Admin/Warehouses/");
            }

            Filter.PageNumber = Page;
            using IDbController dbController = dbProviderService.GetDbController(AppdatenService.DbProvider, AppdatenService.ConnectionString);
            TotalItems = await warehouseService.GetTotalAsync(Filter, dbController);
            Data = await warehouseService.GetAsync(Filter, dbController);

        }
    }
}