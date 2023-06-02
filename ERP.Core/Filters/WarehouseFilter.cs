using ERP.Core.Filters.Abstract;
using ERP.Core.Models;
using System.Text.RegularExpressions;

namespace ERP.Core.Filters
{
    public class WarehouseFilter : PageFilterBase
    {
        public int WarehouseId { get; set; }
        public int SectionId { get; set; } = 1;
        public string StorageLocation { get; set; } = string.Empty;

        public static string ExtractNumber(string input, string letter)
        {
            string pattern = $@"[{letter.ToLower()}{letter.ToUpper()}](\d+)";
            Match match = Regex.Match(input, pattern);

            if (match.Success && int.TryParse(match.Groups[1].Value, out int number))
            {
                if(number > 0)
                {
                    return @$"AND {letter}.`sort_number` = {number} ";
                }
            }

            return "";
        }

        public string ArticleNumber { get; set; } = string.Empty;
    }
}
