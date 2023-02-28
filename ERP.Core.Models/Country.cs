using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Models
{
    public sealed class Country
    {
        public int CountryId { get; set; }

        public string  Name { get; set; } = string.Empty;

        public string IsoCode2 { get; set; } = string.Empty;

        public string IsoCode3 { get;set; } = string.Empty;

        public int NumCode { get; set; }

        public int PhoneCode { get; set; }
    }
}
