using DbController;

namespace ERP.Core.Models
{
    public class Order : IDbModel
    {
        [CompareField("order_id")]
        public int OrderId { get; set; }
        [CompareField("order_number")]
        public string OrderNumber { get; set; } = string.Empty;
        [CompareField("customer_id")]
        public int CustomerId { get; set; }
        [CompareField("weight")]
        public decimal Weight { get; set; }
        [CompareField("length")]
        public decimal Length { get; set; }
        [CompareField("payment_method")]
        public string PaymentMethod { get; set; } = string.Empty;
        [CompareField("shipping_method")]
        public string ShippingMethod { get; set; } = string.Empty;
        [CompareField("delivery_address_id")]
        public int DeliveryAddressId { get; set; }
        [CompareField("billing_address_id")]
        public int BillingAddressId { get; set; }
        [CompareField("order_date")]
        public DateTime OrderDate { get; set; }
        [CompareField("delivery_date")]
        public DateTime DeliveryDate { get; set; }
        [CompareField("invoice_date")]
        public DateTime InvoiceDate { get; set; }
        [CompareField("order_status_public")]
        public string OrderStatusPublic { get; set; } = string.Empty;
        [CompareField("order_status_intern")]
        public string OrderStatusIntern { get; set; } = string.Empty;
        [CompareField("discount_code")]
        public Guid DiscoutCode { get; set; }
        [CompareField("order_note")]
        public string OrderNote { get; set; } = string.Empty;

        public int Id => OrderId;

        public Dictionary<string, object?> GetParameters()
        {
            return new Dictionary<string, object?>
            {
                { "order_id", OrderId },
                { "order_number", OrderNumber },
                { "customer_id", CustomerId },
                { "weight", Weight },
                { "length", Length },
                { "payment_methode", PaymentMethod },
                { "shipping_method", ShippingMethod },
                { "delivery_address_id", DeliveryAddressId },
                { "billing_address_id", BillingAddressId },
                { "order_date", OrderDate },
                { "delivery_date", DeliveryDate },
                { "invoice_date", InvoiceDate },
                { "order_status_public", OrderStatusPublic },
                { "order_status_intern", OrderStatusIntern },
                { "discount_code", DiscoutCode },
                { "order_note", OrderNote }
           };
        }
    }
}
