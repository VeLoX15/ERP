using Microsoft.AspNetCore.Components;
using ERP.Core.Models;
using ERP.Core.Filters;
using ERP.Core.Validators;

namespace ERP.Pages.Management
{
    public partial class ArticleManagement
    {
        [Parameter]
        public int ArticleId { get; set; }
        public Article Input { get; set; } = new();
        private ArticleValidator Validator { get; set; } = new ArticleValidator();
        public ArticleFilter Filter { get; set; } = new ArticleFilter();

        public void StartFilter()
        {

        }
    }
}