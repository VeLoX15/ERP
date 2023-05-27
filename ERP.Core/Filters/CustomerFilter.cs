using ERP.Core.Filters.Abstract;
using ERP.Core.Models;

namespace ERP.Core.Filters
{
    public class CustomerFilter : PageFilterBase
    {
        public string? CustomerNumber { get; set; }
        public string? UserName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Telefon { get; set; }
        public Address? DeliveryAddress { get; set; }
        public Address? BillingAddress { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public int? CustomerStatus { get; set; }

        public int RegistrationDateOperator { get; set; }

        public DateTime? RegistrationDateRange { get; set; }

    }
}
