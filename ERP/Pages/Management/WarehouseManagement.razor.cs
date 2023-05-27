using ERP.Core.Filters;
using ERP.Core.Services;
using ERP.Core.Validators;
using ERP.Core.Models;
using ERP.Core.Extensions;
using DbController.MySql;
using DbController;
using Microsoft.AspNetCore.Identity;

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
        public Warehouse SelectedWarehouse { get; set; } = new();
        public List<Section> Sections { get; set; } = new();
        public Section SelectedSection { get; set; } = new();

        //protected override async Task OnInitializedAsync()
        //{
        //    using IDbController dbController = new MySqlController(AppdatenService.ConnectionString);
        //    Warehouses = await warehouseService.GetAllAsync(dbController);
        //}

        //private async Task OnChange()
        //{
        //    using IDbController dbController = new MySqlController(AppdatenService.ConnectionString);
        //    Sections = await sectionService.GetSectionsByWarehouseId(SelectedWarehouse.WarehouseId, dbController);
        //}
    }
}