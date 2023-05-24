using ERP.Core.Filters.Abstract;
using ERP.Core.Models;

namespace ERP.Core.Filters
{
    public class CustomerFilter : PageFilterBase
    {
        public int? CustomerNumber { get; set; }
        public string? UserName { get; set; } = string.Empty;
        public string? FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; } = string.Empty;
        public string? Email { get; set; } = string.Empty;
        public string? Telefon { get; set; } = string.Empty;
        public Address? DeliveryAddress { get; set; } = new();
        public Address? BillingAddress { get; set; } = new();
        public DateTime? RegistrationDate { get; set; }
        public int? CustomerStatus { get; set; }

        public int CustomerNumberOperator { get; set; }
        public int RegistrationDateOperator { get; set; }

        public int? CustomerNumberRange { get; set; }
        public DateTime? RegistrationDateRange { get; set; }

    }
}
