using Microsoft.AspNetCore.Components;
using ERP.Core.Models;
using ERP.Core.Validator;
using ERP.Core.Filters;

namespace ERP.Components.Filters
{
    public partial class ArticleFilterForm
    {
        [Parameter]
        public int ArticleId { get; set; }
        public Article Input { get; set; } = new();
        private ArticleValidator Validator { get; set; } = new ArticleValidator();
        public ArticleFilter Filter { get; set; } = new ArticleFilter();
    }
}