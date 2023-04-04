using DbController;

namespace ERP.Core.Models
{
    public class Tray
    {
        [CompareField("tray_id")]
        public int TrayId { get; set; }
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
        [CompareField("article")]
        public Article Article { get; set; } = new();
        [CompareField("stock")]
        public int Stock { get; set; }


        public Dictionary<string, object?> GetParameters()
        {
            return new Dictionary<string, object?>
            {
                { "TRAY_ID", TrayId},
                { "WAREHOUSE_ID", WarehouseId},
                { "SECTION_ID", SectionId},
                { "ROW_ID", RowId},
                { "RACK_ID", RackId},
                { "NAME", Name },
                { "NUMBER", Number},
                { "SORT_NUMBER", SortNumber},
                { "ARTICLE", Article},
                { "STOCK", Stock}
           };
        }
    }
}
