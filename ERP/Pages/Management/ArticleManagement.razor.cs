using DbController.MySql;
using DbController;
using ERP.Core.Filters;
using ERP.Core.Services;
using ERP.Core.Validators;
using ERP.Core.Models;
using Microsoft.AspNetCore.Components;

namespace ERP.Pages.Management
{
    public partial class ArticleManagement
    {
        public ArticleFilter Filter { get; set; } = new()
        {
            Limit = AppdatenService.PageLimit
        };

        public ArticleValidator Validator { get; set; } = new();

        private EventCallback<List<Article>> FilteredArticle { get; set; }

        private async Task HandleFilteredArticleAsync()
        {
            using IDbController dbController = new MySqlController(AppdatenService.ConnectionString);
            var list = await articleService.GetAsync(Filter, dbController);
            await FilteredArticle.InvokeAsync(list);
        }
    }
}