using DbController;

namespace ERP.Core.Models
{
    public class Invoice
    {
        [CompareField("invoice_id")]
        public int InvoiceId { get; set; }
        [CompareField("invoice_number")]
        public string InvoiceNumber { get; set; } = string.Empty;
        [CompareField("total_price")]
        public decimal TotalPrice { get; set; }
        [CompareField("tax")]
        public decimal Tax { get; set; }

        public Dictionary<string, object?> GetParameters()
        {
            return new Dictionary<string, object?>
            {
                { "INVOICE_ID", InvoiceId },
                { "INVOICE_NUMBER", InvoiceNumber },
                { "TOTAL_PRICE", TotalPrice },
                { "TAX", Tax }
           };
        }
    }
}
