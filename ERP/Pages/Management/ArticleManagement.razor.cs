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
    public partial class ArticleManagement
    {
        public ArticleFilter Filter { get; set; } = new()
        {
            Limit = AppdatenService.PageLimit
        };

        public ArticleValidator Validator { get; set; } = new();

        public List<Article> FilterData { get; set; } = new ();

        private bool _isToggled = false;

        private bool _isBundle = false;

        private async Task SendDataAsync()
        {
            CheckBundle();

            using IDbController dbController = new MySqlController(AppdatenService.ConnectionString);
            FilterData = await articleService.GetAsync(Filter, dbController);

            string serializedArticles = JsonSerializer.Serialize(FilterData);
            await JSRuntime.InvokeVoidAsync("sessionStorage.removeItem", "articles");
            await JSRuntime.InvokeVoidAsync("sessionStorage.setItem", "articles", serializedArticles);

            navigationManager.NavigateTo("/Management/Articles/List");
        }

        private void CheckBundle()
        {
            if (!_isToggled)
            {
                Filter.IsBundle = null;
            } 
            else
            {
                Filter.IsBundle = _isBundle;
            }
        }


    }
}