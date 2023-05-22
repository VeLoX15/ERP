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

        public int ArticleNumberOperator { get; set; }
        public int WeightOperator { get; set; }
        public int LengthOperator { get; set; }
        public int StockOperator { get; set; }
        public int InclusionDateOperator { get; set; }
        public int PurchasePriceOperator { get; set; }
        public int SellingPriceOperator { get; set; }

        public int ArticleNumberRange { get; set; }
        public decimal WeightRange { get; set; }
        public decimal LengthRange { get; set; }
        public int StockRange { get; set; }
        public DateTime InclusionDateRange { get; set; }
        public decimal PurchasePriceRange { get; set; }
        public decimal SellingPriceRange { get; set; }


    }
}
