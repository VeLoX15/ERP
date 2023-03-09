using DbController;
using ERP.Core.Interfaces;
using ERP.Core.Models;

namespace ERP.Core.Services
{
    public class CompartmentService : IModelService<Compartment, int
        >
    {
        public Task CreateAsync(Compartment input, IDbController dbController)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Compartment input, IDbController dbController)
        {
            throw new NotImplementedException();
        }

        public Task<Compartment?> GetAsync(int identifier, IDbController dbController)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Compartment input, IDbController dbController)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Compartment input, Compartment oldInputToCompare, IDbController dbController)
        {
            throw new NotImplementedException();
        }
    }
}
