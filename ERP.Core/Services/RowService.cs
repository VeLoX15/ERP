using DbController;
using ERP.Core.Models;

namespace ERP.Core.Services
{
    public class RowService : IModelService<Row, int>
    {
        public Task CreateAsync(Row input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Row input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<Row?> GetAsync(int identifier, IDbController dbController, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Row input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
