using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Models
{
    public class Permission
    {
        public int PermissionId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Identifier { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
    }
}
