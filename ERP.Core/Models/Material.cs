using DbController;

namespace ERP.Core.Models
{
    public class Material
    {
        [CompareField("material_id")]
        public int MaterialId { get; set; }
        [CompareField("name")]
        public string Name { get; set; } = string.Empty;
        [CompareField("description")]
        public string Description { get; set; } = string.Empty;

        public Dictionary<string, object?> GetParameters()
        {
            return new Dictionary<string, object?>
            {
                { "MATERIAL_ID", MaterialId },
                { "NAME", Name },
                { "DESCRIPTION", Description }
           };
        }
    }
}
