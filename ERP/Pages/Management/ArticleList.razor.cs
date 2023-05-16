using Blazor.Pagination;
using DbController.MySql;
using DbController;
using ERP.Core.Filters;
using ERP.Core.Models;
using ERP.Core.Services;
using Microsoft.AspNetCore.Components;

namespace ERP.Pages.Management
{
    public partial class ArticleList : IHasPagination
    {
        private int _page = 1;
        public ArticleFilter Filter { get; set; } = new()
        {
            Limit = AppdatenService.PageLimit
        };

        [Parameter]
        public int Id { get; set; }

        [Parameter]
        public List<Article> FilteredArticles { get; set; } = new();

        private EventCallback<List<Article>> OnItemsChanged { get; set; }

        public int Page { get => _page; set => _page = value < 1 ? 1 : value; }
        public int TotalItems { get; set; }

        private async Task HandleItemsChangedAsync()
        {
            await OnItemsChanged.InvokeAsync(FilteredArticles);
        }

        protected override void OnInitialized()
        {
            FilteredArticles = FilteredArticles.Where(x => x.Id == Id).ToList();
        }

        public async Task LoadAsync(bool navigateToPage1 = false)
        {
            Filter.PageNumber = navigateToPage1 ? 1 : Page;
            using IDbController dbController = new MySqlController(AppdatenService.ConnectionString);
            TotalItems = await Service.GetTotalAsync(Filter, dbController);
            Data = await Service.GetAsync(Filter, dbController);
        }
    }
}