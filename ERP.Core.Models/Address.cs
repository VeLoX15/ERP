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
        [CompareField("zip_code")]
        public string ZipCode { get; set; } = string.Empty;
        [CompareField("country_id")]
        public int CountryId { get; set; }

        public Dictionary<string, object?> GetParameters()
        {
            return new Dictionary<string, object?>
            {
                { "address_id", AddressId },
                { "street", Street },
                { "house_number", HouseNumber },
                { "city", City },
                { "zip_code", ZipCode },
                { "country_id", CountryId }
           };
        }
    }
}
