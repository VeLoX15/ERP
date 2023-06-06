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
        [CompareField("invoice_id")]
        public int InvoiceId { get; set; }
        [CompareField("size_id")]
        public int SizeId { get; set; }
        [CompareField("weight")]
        public decimal Weight { get; set; }
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
        [CompareField("discount_id")]
        public int DiscountId { get; set; }
        [CompareField("order_note")]
        public string OrderNote { get; set; } = string.Empty;

        public Customer Customer { get; set; } = new();
        public Invoice Invoice { get; set; } = new();
        public Size Size { get; set; } = new();
        public Address DeliveryAddress { get; set; } = new();
        public Address BillingAddress { get; set; } = new();
         
        public int Id => OrderId;

        public Dictionary<string, object?> GetParameters()
        {
            return new Dictionary<string, object?>
            {
                { "ORDER_ID", OrderId },
                { "ORDER_NUMBER", OrderNumber },
                { "CUSTOMER_ID", CustomerId },
                { "SIZE_ID", SizeId },
                { "WEIGHT", Weight },
                { "PAYMENT_METHOD", PaymentMethod },
                { "SHIPPING_METHOD", ShippingMethod },
                { "DELIVERY_ADDRESS_ID", DeliveryAddressId },
                { "BILLING_ADDRESS_ID", BillingAddressId },
                { "ORDER_DATE", OrderDate },
                { "DELIVERY_DATE", DeliveryDate },
                { "INVOICE_DATE", InvoiceDate },
                { "ORDER_STATUS_PUBLIC", OrderStatusPublic },
                { "ORDER_STATUS_INTERN", OrderStatusIntern },
                { "DISCOUNT_ID", DiscountId },
                { "ORDER_NOTE", OrderNote }
           };
        }
    }
}
