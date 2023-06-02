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
    public partial class StockManagement
    {
        public WarehouseFilter Filter { get; set; } = new()
        {
            Limit = AppdatenService.PageLimit
        };

        public ArticleValidator Validator { get; set; } = new();

        public List<Compartment> FilterData { get; set; } = new();

        private async Task SendDataAsync()
        {
            using IDbController dbController = new MySqlController(AppdatenService.ConnectionString);
            FilterData = await compartmentService.GetCompartmentsByArticleIdAsync(Filter, dbController);

            string serializedOrders = JsonSerializer.Serialize(FilterData);
            await JSRuntime.InvokeVoidAsync("sessionStorage.removeItem", "stocks");
            await JSRuntime.InvokeVoidAsync("sessionStorage.setItem", "stocks", serializedOrders);

            navigationManager.NavigateTo("/Management/Stocks/List");
        }
    }
}