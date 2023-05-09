using DbController;
using ERP.Core.Models;

namespace ERP.Core.Services
{
    public class RackService : IModelService<Rack, int>
    {
        public Task CreateAsync(Rack input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Rack input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<Rack?> GetAsync(int identifier, IDbController dbController, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Rack input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
