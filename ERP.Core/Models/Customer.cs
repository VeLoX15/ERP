using DbController;

namespace ERP.Core.Models
{
    public class Customer : IDbModel
    {
        [CompareField("customer_id")]
        public int CustomerId { get; set; }
        [CompareField("customer_number")]
        public string CustomerNumber { get; set; } = string.Empty;
        [CompareField("username")]
        public string UserName { get; set; } = string.Empty;
        [CompareField("origin")]
        public string Origin { get; set; } = string.Empty;
        [CompareField("salutation")]
        public string Salutation { get; set; } = string.Empty;
        [CompareField("first_name")]
        public string FirstName { get; set; } = string.Empty;
        [CompareField("last_name")]
        public string LastName { get; set; } = string.Empty;
        [CompareField("email")]
        public string Email { get; set; } = string.Empty;
        [CompareField("telefon")]
        public string Telefon { get; set; } = string.Empty;
        [CompareField("standard_payment_method")]
        public string StandardPaymentMethod { get; set; } = string.Empty;
        [CompareField("standard_delivery_method")]
        public string StandardDeliveryMethod { get; set; } = string.Empty;
        [CompareField("delivery_address_id")]
        public int DeliveryAddressId { get; set; }
        [CompareField("billing_address_id")]
        public int BillingAddressId { get; set; }
        [CompareField("registration_date")]
        public DateTime RegistrationDate { get; set; }
        [CompareField("last_login")]
        public DateTime LastLogin { get; set; }
        [CompareField("customer_status")]
        public int CustomerStatus { get; set; }
        [CompareField("customer_group")]
        public int CustomerGroup { get; set; }
        [CompareField("comment")]
        public string Comment { get; set; } = string.Empty;
        public Address DeliveryAddress { get; set; } = new();
        public Address BillingAddress { get; set; } = new();

        public int Id => CustomerId;


        public Dictionary<string, object?> GetParameters()
        {
            return new Dictionary<string, object?>
            {
                { "CUSTOMER_ID", CustomerId },
                { "CUSTOMER_NUMBER", CustomerNumber },
                { "USERNAME", UserName },
                { "ORIGIN", Origin },
                { "SALUTATION", Salutation },
                { "FIRST_NAME", FirstName },
                { "LAST_NAME", LastName },
                { "EMAIL", Email },
                { "TELEFON", Telefon },
                { "STANDARD_PAYMENT_METHOD", StandardPaymentMethod },
                { "STANDARD_DELIVERY_METHOD", StandardDeliveryMethod },
                { "DELIVERY_ADDRESS_ID", DeliveryAddressId },
                { "BILLING_ADDRESS_ID", BillingAddressId },
                { "REGISTRATION_DATE", RegistrationDate },
                { "LAST_LOGIN", LastLogin },
                { "CUSTOMER_STATUS", CustomerStatus },
                { "CUSTOMER_GROUP", CustomerGroup },
                { "COMMENT", Comment }
           };
        }
    }
}
