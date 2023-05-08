using DbController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        [CompareField("article_id")]
        public int ArticleId { get; set; }

        public Dictionary<string, object?> GetParameters()
        {
            return new Dictionary<string, object?>
            {
                { "MATERIAL_ID", MaterialId },
                { "NAME", Name },
                { "DESCRIPTION", Description },
                { "ARTICLE_ID", ArticleId }
           };
        }
    }
}
