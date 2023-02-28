using DbController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Models
{
    public class Article
    {
        [CompareField("article_id")]
        public int ArticleId { get; set; }
        [CompareField("article_number")]
        public int ArticleNumber { get; set; }
        [CompareField("name")]
        public string Name { get; set; } = string.Empty;
        [CompareField("description")]
        public string Description { get; set; } = string.Empty;
        [CompareField("weight")]
        public decimal Weight { get; set; }
        [CompareField("length")]
        public decimal Length { get; set; }
        [CompareField("stock")]
        public int Stock { get; set; }
        [CompareField("assortment_intake")]
        public DateTime AssortmentIntake { get; set; }
        [CompareField("sale_net")]
        public decimal SaleNet { get; set; }
        [CompareField("sale_gross")]
        public decimal SaleGross { get; set; }
        [CompareField("purchase_net")]
        public decimal PurchaseNet { get; set; }
        [CompareField("is_bundle")]
        public bool IsBundle { get; set; }
        [CompareField("bundle_articles")]
        public List<Article> BundleArticles { get; set; } = new List<Article>();
        [CompareField("categories")]
        public List<Category> Categories { get; set; } = new List<Category>();
        [CompareField("materials")]
        public List<Material> Materials { get; set; } = new List<Material>();

    }
}
