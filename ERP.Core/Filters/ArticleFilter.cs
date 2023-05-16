using ERP.Core.Filters.Abstract;

namespace ERP.Core.Filters
{
    public class ArticleFilter : PageFilterBase
    {
        public int ArticleId { get; set; }
        public int ArticleNumber { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Weight { get; set; }
        public decimal Length { get; set; }
        public int Stock { get; set; }
        public DateTime InclusionDate { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
        public bool IsBundle { get; set; }

        public int ArticleNumberCondition { get; set; }
        public int WeightCondition { get; set; }
        public int LengthCondition { get; set; }
        public int StockCondition { get; set; }
        public int InclusionDateCondition { get; set; }
        public int PurchasePriceCondition { get; set; }
        public int SellingPriceCondition { get; set; }

        public int ArticleNumberRange { get; set; }
        public decimal WeightRange { get; set; }
        public decimal LengthRange { get; set; }
        public int StockRange { get; set; }
        public DateTime InclusionDateRange { get; set; }
        public decimal PurchasePriceRange { get; set; }
        public decimal SellingPriceRange { get; set; }


    }
}
