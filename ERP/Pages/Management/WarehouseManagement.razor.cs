using Microsoft.AspNetCore.Components;
using ERP.Core.Models;
using ERP.Core.Filters;
using ERP.Core.Validators;

namespace ERP.Pages.Management
{
    public partial class WarehouseManagement
    {
        [Parameter]
        public int WarehouseId { get; set; }
        public Warehouse Input { get; set; } = new();
        private WarehouseValidator Validator { get; set; } = new WarehouseValidator();
        public WarehouseFilter Filter { get; set; } = new WarehouseFilter();

        public void StartFilter()
        {

        }
    }
}