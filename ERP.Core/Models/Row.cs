using DbController;

namespace ERP.Core.Models
{
    public class Row
    {
        [CompareField("row_id")]
        public int RowId { get; set; }
        [CompareField("warehouse_id")]
        public int WarehouseId { get; set; }
        [CompareField("section_id")]
        public int SectionId { get; set; }
        [CompareField("name")]
        public string Name { get; set; } = string.Empty;
        [CompareField("number")]
        public int Number { get; set; }
        [CompareField("sort_number")]
        public int SortNumber { get; set; }

        public Dictionary<string, object?> GetParameters()
        {
            return new Dictionary<string, object?>
            {
                { "row_id", RowId },
                { "warehouse_id", WarehouseId },
                { "section_id", SectionId },
                { "name", Name },
                { "number", Number },
                { "sort_number", SortNumber }
           };
        }
    }
}
