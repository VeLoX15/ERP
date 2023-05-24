using DbController;

namespace ERP.Core.Models
{
    public class Article : IDbModel
    {
        [CompareField("article_id")]
        public int ArticleId { get; set; }
        [CompareField("article_number")]
        public string ArticleNumber { get; set; } = string.Empty;
        [CompareField("name")]
        public string Name { get; set; } = string.Empty;
        [CompareField("description")]
        public string Description { get; set; } = string.Empty;
        [CompareField("weight")]
        public decimal Weight { get; set; }
        [CompareField("length")]
        public decimal Length { get; set; }
        [CompareField("inclusion_date")]
        public DateTime InclusionDate { get; set; }
        [CompareField("purchase_price")]
        public decimal PurchasePrice { get; set; }
        [CompareField("selling_price")]
        public decimal SellingPrice { get; set; }
        [CompareField("is_bundle")]
        public bool IsBundle { get; set; }
        public List<Article> BundleArticles { get; set; } = new List<Article>();
        public List<Category> Categories { get; set; } = new List<Category>();
        public List<Material> Materials { get; set; } = new List<Material>();

        public int Id => ArticleId;

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
                { "INCLUSION_DATE", InclusionDate },
                { "PURCHASE_PRICE", PurchasePrice },
                { "SELLING_PRICE", SellingPrice },
                { "IS_BUNDLE", IsBundle }
           };
        }
    }
}
