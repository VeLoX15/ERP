using Blazor.Pagination;
using DbController;
using DbController.MySql;
using ERP.Core.Filters;
using ERP.Core.Services;

namespace ERP.Pages.Management
{
    public partial class ArticleList : IHasPagination
    {
        private int _page = 1;
        public ArticleFilter Filter { get; set; } = new()
        {
            Limit = AppdatenService.PageLimit
        };
        public int Page { get => _page; set => _page = value < 1 ? 1 : value; }
        public int TotalItems { get; set; }
        protected override async Task SaveAsync()
        {
            if (Input is null)
            {
                return;
            }

            await base.SaveAsync();
            await LoadAsync();
        }
        public async Task LoadAsync(bool navigateToPage1 = false)
        {
            Filter.PageNumber = navigateToPage1 ? 1 : Page;
            using IDbController dbController = new MySqlController(AppdatenService.ConnectionString);
            TotalItems = await Service.GetTotalAsync(Filter, dbController);
            Data = await Service.GetAsync(Filter, dbController);
        }

        protected override async Task DeleteAsync()
        {
            await base.DeleteAsync();
            await LoadAsync();
        }
    }
}