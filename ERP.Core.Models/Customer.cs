using DbController;
using System.Xml.Linq;

namespace ERP.Core.Models
{
    public class Customer
    {
        [CompareField("customer_id")]
        public int CustomerId { get; set; }
        [CompareField("customer_number")]
        public int CustomerNumber { get; set; }
        [CompareField("user_name")]
        public string UserName { get; set; } = string.Empty;
        [CompareField("first_name")]
        public string FirstName { get; set; } = string.Empty;
        [CompareField("last_name")]
        public string LastName { get; set; } = string.Empty;
        [CompareField("email")]
        public string Email { get; set; } = string.Empty;
        [CompareField("telefon")]
        public string Telefon { get; set; } = string.Empty;

        public Dictionary<string, object?> GetParameters()
        {
            return new Dictionary<string, object?>
            {
                { "CUSTOMER_ID", CustomerId },
                { "CUSTOMER_NUMBER", CustomerNumber },
                { "USER_NAME", UserName },
                { "FIRST_NAME", FirstName },
                { "LAST_NAME", LastName },
                { "EMAIL", Email },
                { "TELEFON", Telefon}
           };
        }
    }
}
