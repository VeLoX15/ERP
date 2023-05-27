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
    public partial class OrderManagement
    {
        public OrderFilter Filter { get; set; } = new()
        {
            Limit = AppdatenService.PageLimit
        };

        public OrderValidator Validator { get; set; } = new();

        public List<Order> FilterData { get; set; } = new();

        private async Task SendDataAsync()
        {
            using IDbController dbController = new MySqlController(AppdatenService.ConnectionString);
            FilterData = await orderService.GetAsync(Filter, dbController);

            string serializedOrders = JsonSerializer.Serialize(FilterData);
            await JSRuntime.InvokeVoidAsync("sessionStorage.removeItem", "orders");
            await JSRuntime.InvokeVoidAsync("sessionStorage.setItem", "orders", serializedOrders);

            navigationManager.NavigateTo("/Management/Orders/List");
        }
    }
}