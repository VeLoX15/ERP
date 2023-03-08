using DbController;

namespace ERP.Core.Models
{
    public class Section
    {
        [CompareField("section_id")]
        public int SectionId { get; set; }
        [CompareField("warehouse_id")]
        public int WarehouseId { get; set; }
        [CompareField("name")]
        public string Name { get; set; } = string.Empty;
        [CompareField("number")]
        public int Number { get; set; }
        [CompareField("sort_number")]
        public int SortNumber { get; set; }
    }
}
