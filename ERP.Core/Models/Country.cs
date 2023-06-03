using DbController;

namespace ERP.Core.Models
{
    public sealed class Country
    {
        [CompareField("country_id")]
        public int CountryId { get; set; }
        [CompareField("iso")]
        public string Iso { get; set; } = string.Empty;
        [CompareField("name")]
        public string  Name { get; set; } = string.Empty;
        [CompareField("iso3")]
        public string Iso3 { get;set; } = string.Empty;
        [CompareField("numcode")]
        public int NumCode { get; set; }
        [CompareField("phonecode")]
        public int PhoneCode { get; set; }

        public Dictionary<string, object?> GetParameters()
        {
            return new Dictionary<string, object?>
            {
                { "COUNTRY_ID", CountryId },
                { "ISO", Iso },
                { "NAME", Name },
                { "ISO3", Iso3 },
                { "NUMCODE", NumCode },
                { "PHONECODE", PhoneCode }
           };
        }
    }
}
