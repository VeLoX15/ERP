namespace DatabaseControllerProvider
{
    public interface DbProviderService
    {
        IDbController GetDbController(string connectionString);
    }
}