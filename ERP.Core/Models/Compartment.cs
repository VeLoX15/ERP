using DbController;

namespace ERP.Core.Models
{
    public class Compartment : IDbModel
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
        [CompareField("article_id")]
        public int ArticleId { get; set; }
        [CompareField("stock")]
        public int Stock { get; set; }

        public Article Article { get; set; } = new();
        public Warehouse Warehouse { get; set; } = new();
        public Section Section { get; set; } = new();
        public Row Row { get; set; } = new();
        public Rack Rack { get; set; } = new();

        public int Id => CompartmentId;

        public Dictionary<string, object?> GetParameters()
        {
            return new Dictionary<string, object?>
            {
                { "COMPARTMENT_ID", RackId },
                { "WAREHOUSE_ID", WarehouseId },
                { "SECTION_ID", Name },
                { "ROW_ID", RowId },
                { "RACK_ID", RackId },
                { "NAME", Name },
                { "NUMBER", Number },
                { "SORT_NUMBER", SortNumber },
                { "ARTICLE_ID", ArticleId },
                { "STOCK", Stock }
           };
        }
    }
}
