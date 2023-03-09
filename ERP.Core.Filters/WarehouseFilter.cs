using ERP.Core.Filters.Abstract;

namespace ERP.Core.Filters
{
    public class WarehouseFilter : PageFilterBase
    {
        public bool ShowOnlyActiveForms { get; set; }
        public bool ShowOnlyFormsWhichRequireLogin { get; set; }
    }
}
