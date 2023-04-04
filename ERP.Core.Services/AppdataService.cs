using DatabaseControllerProvider;
using DbController;
using ERP.Core.Models;
using Microsoft.Extensions.Configuration;

namespace ERP.Core.Services
{
    public class AppdataService
    {
        public static bool FirstUserExists { get; set; } = false;

        public static List<Permission> Permissions { get; set; } = new();
        private static IConfiguration? _configuration;

        public static async Task InitAsync(IConfiguration configuration)
        {
            _configuration = configuration;
            // HACK: Refactor to dependency injection
            DbProviderService dbProviderService = new DbProviderService();
            using IDbController dbController = dbProviderService.GetDbController(DbProvider, ConnectionString);

            // TODO: Init FirstUserExists
        }
        public static string DbProvider => _configuration?["DbProvider"] ?? string.Empty;
        public static string ConnectionString => _configuration?.GetConnectionString("Default") ?? string.Empty;
        public static bool IsLdapLoginEnabled => _configuration?.GetSection("Login").GetValue<bool>("ENABLE_LDAP_LOGIN") ?? false;
        public static bool IsLocalLoginEnabled => _configuration?.GetSection("Login").GetValue<bool>("ENABLE_LOCAL_LOGIN") ?? false;
        public static string LdapServer => _configuration?["Login:LDAP_SERVER"] ?? string.Empty;
        public static string LdapDomainServer => _configuration?["Login:DOMAIN_SERVER"] ?? string.Empty;
        public static string LdapDistinguishedName => _configuration?["Login:DistinguishedName"] ?? string.Empty;
    }
}
