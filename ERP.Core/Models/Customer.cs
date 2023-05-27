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
        [CompareField("password")]
        public string Password { get; set; } = string.Empty;
        [CompareField("salt")]
        public string Salt { get; set; } = string.Empty;
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
        [CompareField("delivery_address")]
        public Address DeliveryAddress { get; set; } = new();
        [CompareField("billing_address")]
        public Address BillingAddress { get; set; } = new();
        [CompareField("registration_date")]
        public DateTime RegistrationDate { get; set; }
        [CompareField("customer_status")]
        public int CustomerStatus { get; set; }
        [CompareField("comment")]
        public string Comment { get; set; } = string.Empty;

        public int Id => CustomerId;


        public Dictionary<string, object?> GetParameters()
        {
            return new Dictionary<string, object?>
            {
                { "CUSTOMER_ID", CustomerId },
                { "CUSTOMER_NUMBER", CustomerNumber },
                { "USERNAME", UserName },
                { "PASSWORD", Password },
                { "SALT", Salt },
                { "ORIGIN", Origin },
                { "SALUTATION", Salutation },
                { "FIRST_NAME", FirstName },
                { "LAST_NAME", LastName },
                { "EMAIL", Email },
                { "TELEFON", Telefon},
                { "STANDARD_PAYMENT_METHOD", StandardPaymentMethod },
                { "DELIVERY_ADDRESS", DeliveryAddress },
                { "BILLING_ADDRESS", BillingAddress },
                { "REGISTRATION_DATE", RegistrationDate },
                { "CUSTOMER_STATUS", CustomerStatus },
                { "COMMENT", Comment }
           };
        }
    }
}
