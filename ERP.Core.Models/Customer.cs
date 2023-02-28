using DbController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        

    }
}
