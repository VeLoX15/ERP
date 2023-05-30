using ERP.Core.Filters.Abstract;
using System.Text;

namespace ERP.Core.Filters
{
    public class WarehouseFilter : PageFilterBase
    {
        public int WarehouseId { get; set; }
        public int SectionId { get; set; }
        public int RowId { get; set; }
        public int RackId { get; set; }
        public int CompartmentId { get; set; }


        public static string StorageFilter()
        {
            StringBuilder sqlBuilder = new();
            sqlBuilder.AppendLine("SELECT c.* FROM `compartments` c ");
            sqlBuilder.AppendLine("WHERE 1 = 1 ");
            sqlBuilder.AppendLine("");
            sqlBuilder.AppendLine(@$"ORDER BY `compartment_id` DESC ");
        }
    }
}
