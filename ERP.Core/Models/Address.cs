using DbController;

namespace ERP.Core.Models
{
    public class Address
    {
        [CompareField("address_id")]
        public int AddressId { get; set; }
        [CompareField("street")]
        public string Street { get; set; } = string.Empty;
        [CompareField("house_number")]
        public int HouseNumber { get; set; }
        [CompareField("city")]
        public string City { get; set; } = string.Empty;
        [CompareField("state")]
        public string State { get; set; } = string.Empty;
        [CompareField("postal_code")]
        public string PostalCode { get; set; } = string.Empty;
        [CompareField("country_id")]
        public int CountryId { get; set; }

        public Dictionary<string, object?> GetParameters()
        {
            return new Dictionary<string, object?>
            {
                { "ADDRESS_ID", AddressId },
                { "STREET", Street },
                { "HOUSE_NUMBER", HouseNumber },
                { "CITY", City },
                { "STATE", State },
                { "POSTAL_CODE", PostalCode },
                { "COUNTRY_ID", CountryId }
           };
        }
    }
}
