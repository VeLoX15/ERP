using DbController;
using ERP.Core.Filters;
using ERP.Core.Models;

namespace ERP.Core.Services
{
    public class WarehouseService : IModelService<Warehouse, int, WarehouseFilter>
    {
        public Task CreateAsync(Warehouse input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Warehouse input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<Warehouse?> GetAsync(int identifier, IDbController dbController, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<Warehouse>> GetAsync(WarehouseFilter filter, IDbController dbController, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, object?> GetFilterParameter(WarehouseFilter filter)
        {
            throw new NotImplementedException();
        }

        public string GetFilterWhere(WarehouseFilter filter)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetTotalAsync(WarehouseFilter filter, IDbController dbController, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Warehouse input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
