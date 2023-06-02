using DbController;

namespace ERP.Core.Models
{
    public class Size
    {
        [CompareField("size_id")]
        public int SizeId { get; set; }
        [CompareField("length")]
        public decimal Length { get; set; }
        [CompareField("width")]
        public decimal Width { get; set; }
        [CompareField("height")]
        public decimal Height { get; set; }
        [CompareField("volume")]
        public decimal Volume { get; set; }

        public Dictionary<string, object?> GetParameters()
        {
            return new Dictionary<string, object?>
            {
                { "SIZE_ID", SizeId },
                { "LENGTH", Length },
                { "WIDTH", Width },
                { "HEIGHT", Height },
                { "VOLUME", Volume }
           };
        }
    }
}
