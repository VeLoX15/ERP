using DbController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ERP.Core.Models
{
    public sealed class Country
    {
        [CompareField("country_id")]
        public int CountryId { get; set; }
        [CompareField("name")]
        public string  Name { get; set; } = string.Empty;
        [CompareField("iso_code_2")]
        public string IsoCode2 { get; set; } = string.Empty;
        [CompareField("iso_code_3")]
        public string IsoCode3 { get;set; } = string.Empty;
        [CompareField("num_code")]
        public int NumCode { get; set; }
        [CompareField("phone_code")]
        public int PhoneCode { get; set; }

        public Dictionary<string, object?> GetParameters()
        {
            return new Dictionary<string, object?>
            {
                { "COUNTRY_ID", CountryId },
                { "NAME", Name },
                { "ISO_CODE_2", IsoCode2 },
                { "ISO_CODE_3", IsoCode3 },
                { "NUM_CODE", NumCode },
                { "PHONE_CODE", PhoneCode }
           };
        }
    }
}
