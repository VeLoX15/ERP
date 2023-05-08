using DatabaseControllerProvider;
using DbController;
using ERP.Core.Models;
using Microsoft.Extensions.Configuration;

namespace ERP.Core.Services
{
    public static class AppdatenService
    {
        public static bool FirstUserExists { get; set; } = false;

        public static List<Permission> Permissions { get; set; } = new();
        private static IConfiguration? _configuration;

        public static async Task InitAsync(IConfiguration configuration, DbProviderService dbProviderService)
        {
            _configuration = configuration;
            using IDbController dbController = dbProviderService.GetDbController(DbProvider, ConnectionString);
<<<<<<< HEAD

            // TODO: Init FirstUserExists
=======
            Permissions = await PermissionService.GetAllAsync(dbController);
            FirstUserExists = await UserService.FirstUserExistsAsync(dbController);
>>>>>>> ff1a43dec780b6271f9a9d85601ef8ee424c61ae
        }
        public static string ConnectionString => _configuration?["ConnectionStrings:Default"] ?? string.Empty;
        public static string DbProvider => _configuration?["DbProvider"] ?? string.Empty;
        public static bool IsLdapLoginEnabled => _configuration?.GetSection("LdapSettings").GetValue<bool>("ENABLE_LDAP_LOGIN") ?? false;
        public static bool IsLocalLoginEnabled => _configuration?.GetSection("LdapSettings").GetValue<bool>("ENABLE_LOCAL_LOGIN") ?? false;
        public static string LdapServer => _configuration?["LdapSettings:LDAP_SERVER"] ?? string.Empty;
        public static string LdapDomainServer => _configuration?["LdapSettings:DOMAIN_SERVER"] ?? string.Empty;
        public static string LdapDistinguishedName => _configuration?["LdapSettings:DistinguishedName"] ?? string.Empty;

        public static int PageLimit => _configuration?.GetValue<int>("PageLimit") ?? 30;
    }
}
