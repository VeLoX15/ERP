using ERP.Core.Models;

namespace ERP.Pages
{
    public partial class ArticleFormPage
    {
        public int ArticleId { get; set; }

        public Article Input { get; set; } = new Article();
    }
}