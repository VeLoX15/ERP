using DbController;

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
        [CompareField("purchase_price")]
        public decimal PurchasePrice { get; set; }
        [CompareField("selling_price")]
        public decimal SellingPrice { get; set; }
        [CompareField("is_bundle")]
        public bool IsBundle { get; set; }
        public List<Article> BundleArticles { get; set; } = new List<Article>();
        public List<Category> Categories { get; set; } = new List<Category>();
        public List<Material> Materials { get; set; } = new List<Material>();


        public Dictionary<string, object?> GetParameters()
        {
            return new Dictionary<string, object?>
            {
                { "ARTICLE_ID", ArticleId },
                { "ARTICLE_NUMBER", ArticleNumber },
                { "NAME", Name },
                { "DESCRIPTION", Description },
                { "WEIGHT", Weight },
                { "LENGTH", Length },
                { "STOCK", Stock },
                { "ASSORTMENT_INTAKE", AssortmentIntake },
                { "PURCHASE_PRICE", PurchasePrice },
                { "SELLING_PRICE", SellingPrice },
                { "IS_BUNDLE", IsBundle }
           };
        }
    }
}
