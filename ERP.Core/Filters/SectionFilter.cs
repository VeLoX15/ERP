using ERP.Core.Filters.Abstract;

namespace ERP.Core.Filters
{
    public class SectionFilter : PageFilterBase
    {
        public string? Name { get; set; }
        public int? Number { get; set; }
    }
}
