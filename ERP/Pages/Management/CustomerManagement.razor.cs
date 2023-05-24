using DbController.MySql;
using DbController;
using ERP.Core.Filters;
using ERP.Core.Services;
using ERP.Core.Validators;
using ERP.Core.Models;
using Microsoft.JSInterop;
using System.Text.Json;

namespace ERP.Pages.Management
{
    public partial class CustomerManagement
    {
        public CustomerFilter Filter { get; set; } = new()
        {
            Limit = AppdatenService.PageLimit
        };

        public CustomerValidator Validator { get; set; } = new();

        public List<Customer> FilterData { get; set; } = new();

        private async Task SendDataAsync()
        {
            using IDbController dbController = new MySqlController(AppdatenService.ConnectionString);
            FilterData = await customerService.GetAsync(Filter, dbController);

            string serializedArticles = JsonSerializer.Serialize(FilterData);
            await JSRuntime.InvokeVoidAsync("sessionStorage.removeItem", "customers");
            await JSRuntime.InvokeVoidAsync("sessionStorage.setItem", "customers", serializedArticles);

            navigationManager.NavigateTo("/Management/Customers/List");
        }
    }
}