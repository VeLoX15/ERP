using DbController;
using ERP.Core.Interfaces;
using ERP.Core.Models;

namespace ERP.Core.Services
{
    public class CompartmentService : IModelService<Tray, int
        >
    {
        public Task CreateAsync(Tray input, IDbController dbController)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Tray input, IDbController dbController)
        {
            throw new NotImplementedException();
        }

        public Task<Tray?> GetAsync(int identifier, IDbController dbController)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Tray input, IDbController dbController)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Tray input, Tray oldInputToCompare, IDbController dbController)
        {
            throw new NotImplementedException();
        }
    }
}
