using DbController;

namespace ERP.Core.Models
{
    public class Compartment
    {
        [CompareField("compartment_id")]
        public int CompartmentId { get; set; }
        [CompareField("warehouse_id")]
        public int WarehouseId { get; set; }
        [CompareField("section_id")]
        public int SectionId { get; set; }
        [CompareField("row_id")]
        public int RowId { get; set; }
        [CompareField("rack_id")]
        public int RackId { get; set; }
        [CompareField("name")]
        public string Name { get; set; } = string.Empty;
        [CompareField("number")]
        public int Number { get; set; }
        [CompareField("sort_number")]
        public int SortNumber { get; set; }
    }
}
