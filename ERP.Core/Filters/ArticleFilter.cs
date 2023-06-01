using ERP.Core.Filters.Abstract;

namespace ERP.Core.Filters
{
    public class ArticleFilter : PageFilterBase
    {
        public string? ArticleNumber { get; set; }
        public string? Name { get; set; }
        public decimal? Weight { get; set; }
        public DateTime? InclusionDate { get; set; }
        public decimal? PurchasePrice { get; set; }
        public decimal? SellingPrice { get; set; }
        public bool? IsBundle { get; set; }

        public int ArticleNumberOperator { get; set; }
        public int WeightOperator { get; set; }
        public int InclusionDateOperator { get; set; }
        public int PurchasePriceOperator { get; set; }
        public int SellingPriceOperator { get; set; }

        public string? ArticleNumberRange { get; set; }
        public decimal? WeightRange { get; set; }
        public DateTime? InclusionDateRange { get; set; }
        public decimal? PurchasePriceRange { get; set; }
        public decimal? SellingPriceRange { get; set; }
    }
}
