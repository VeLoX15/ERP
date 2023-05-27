using ERP.Core.Filters.Abstract;

namespace ERP.Core.Filters
{
    public class OrderFilter : PageFilterBase
    {
        public string? OrderNumber { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Length { get; set; }
        public int? PaymentMethod { get; set; }
        public int? ShippingMethod { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public int? OrderStatusPublic { get; set; }
        public int? OrderStatusIntern { get; set; }

        public int WeightOperator { get; set; }
        public int LengthOperator { get; set; }
        public int OrderDateOperator { get; set; }
        public int DeliveryDateOperator { get; set; }
        public int InvoiceDateOperator { get; set; }

        public decimal? WeightRange { get; set; }
        public decimal? LengthRange { get; set; }
        public DateTime? OrderDateRange { get; set; }
        public DateTime? DeliveryDateRange { get; set; }
        public DateTime? InvoiceDateRange { get; set; }
    }
}
