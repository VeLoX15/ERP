using DbController;
using ERP.Core.Filters;
using ERP.Core.Models;

namespace ERP.Core.Services
{
    public class CustomerService : IModelService<Customer, int, CustomerFilter>
    {
        public Task CreateAsync(Customer input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Customer input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<Customer?> GetAsync(int identifier, IDbController dbController, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<Customer>> GetAsync(CustomerFilter filter, IDbController dbController, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, object?> GetFilterParameter(CustomerFilter filter)
        {
            throw new NotImplementedException();
        }

        public string GetFilterWhere(CustomerFilter filter)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetTotalAsync(CustomerFilter filter, IDbController dbController, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Customer input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
