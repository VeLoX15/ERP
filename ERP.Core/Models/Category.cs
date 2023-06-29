using DbController;

namespace ERP.Core.Models
{
    public class Category : IDbModel
    {
        [CompareField("category_id")]
        public int CategoryId { get; set; }
        [CompareField("name")]
        public string Name { get; set; } = string.Empty;
        [CompareField("description")]
        public string Description { get; set; } = string.Empty;

        public int Id => CategoryId;

        public Dictionary<string, object?> GetParameters()
        {
            return new Dictionary<string, object?>
            {
                { "CATEGORY_ID", CategoryId },
                { "NAME", Name },
                { "DESCRIPTION", Description }
           };
        }
    }
}
