namespace ERP.Core.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public Guid? Guid { get; set; }

        public string Password { get; set; } = string.Empty;

        public string Salt { get; set; } = string.Empty;

        public List<Permission> Permissions { get; set; } = new List<Permission>();
    }
}
