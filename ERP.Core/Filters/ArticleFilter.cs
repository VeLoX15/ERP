using DbController;
using ERP.Core.Constants;
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
        public DateTime AssortmentIntake { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
        public bool IsBundle { get; set; }

        public FilterCondition ArticleIdCondition { get; set; }
        public FilterCondition ArticleNumberCondition { get; set; }
        public FilterCondition WeightCondition { get; set; }
        public FilterCondition LengthCondition { get; set; }
        public FilterCondition StockCondition { get; set; }
        public FilterCondition AssortmentIntakeCondition { get; set; }
        public FilterCondition PurchasePriceCondition { get; set; }
        public FilterCondition SellingPriceCondition { get; set; }


    }
}
