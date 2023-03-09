using DbController;
using ERP.Core.Interfaces;
using ERP.Core.Models;

namespace ERP.Core.Services
{
    public class SectionService : IModelService<Section, int>
    {
        public Task CreateAsync(Section input, IDbController dbController)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Section input, IDbController dbController)
        {
            throw new NotImplementedException();
        }

        public Task<Section?> GetAsync(int identifier, IDbController dbController)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Section input, IDbController dbController)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Section input, Section oldInputToCompare, IDbController dbController)
        {
            throw new NotImplementedException();
        }
    }
}
