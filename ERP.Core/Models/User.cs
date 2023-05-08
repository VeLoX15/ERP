using DbController;

namespace ERP.Core.Models
{
    public class User
    {
        [CompareField("user_id")]
        public int UserId { get; set; }
        [CompareField("name")]
        public string Name { get; set; } = string.Empty;
        [CompareField("email")]
        public string Email { get; set; } = string.Empty;
        [CompareField("guid")]
        public Guid? Guid { get; set; }
        [CompareField("password")]
        public string Password { get; set; } = string.Empty;
        [CompareField("salt")]
        public string Salt { get; set; } = string.Empty;
        [CompareField("permission")]
        public List<Permission> Permissions { get; set; } = new List<Permission>();

        public Dictionary<string, object?> GetParameters()
        {
            return new Dictionary<string, object?>
            {
                { "user_id", UserId },
                { "name", Name},
                { "email", Email },
                { "guid", Guid },
                { "password", Password },
                { "salt", Salt },
                { "permisson", Permissions}
           };
        }
    }
}
