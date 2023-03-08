using ERP.Core.Interfaces;
using ERP.Core.Models;
using DbController;

namespace ERP.Core.Services
{
    internal class WarehouseService : IModelService<Warehouse, int>
    {
        public Task CreateAsync(Warehouse input, IDbController dbController)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Warehouse input, IDbController dbController)
        {
            throw new NotImplementedException();
        }

        public Task<Warehouse?> GetAsync(int identifier, IDbController dbController)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Warehouse input, IDbController dbController)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Warehouse input, Warehouse oldInputToCompare, IDbController dbController)
        {
            throw new NotImplementedException();
        }
    }
}
