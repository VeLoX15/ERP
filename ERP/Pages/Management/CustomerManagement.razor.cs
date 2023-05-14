using Microsoft.AspNetCore.Components;
using ERP.Core.Models;
using ERP.Core.Filters;
using ERP.Core.Validators;

namespace ERP.Pages.Management
{
    public partial class CustomerManagement
    {
        [Parameter]
        public int WarehouseId { get; set; }
        public Customer Input { get; set; } = new();
        private CustomerValidator Validator { get; set; } = new CustomerValidator();
        public CustomerFilter Filter { get; set; } = new CustomerFilter();

        public void StartFilter()
        {

        }
    }
}