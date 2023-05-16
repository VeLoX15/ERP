using Microsoft.AspNetCore.Components;
using ERP.Core.Models;
using ERP.Core.Filters;
using ERP.Core.Validators;
using DbController.MySql;
using DbController;
using ERP.Core.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ERP.Pages.Management
{
    public partial class CustomerManagement
    {
        [Parameter]
        public int CustomerId { get; set; }
        public Customer Input { get; set; } = new();
        private CustomerValidator Validator { get; set; } = new CustomerValidator();
        public CustomerFilter Filter { get; set; } = new CustomerFilter();
    }
}