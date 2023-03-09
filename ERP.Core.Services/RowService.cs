using DbController;
using ERP.Core.Interfaces;
using ERP.Core.Models;

namespace ERP.Core.Services
{
    public class RowService : IModelService<Row, int>
    {
        public Task CreateAsync(Row input, IDbController dbController)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Row input, IDbController dbController)
        {
            throw new NotImplementedException();
        }

        public Task<Row?> GetAsync(int identifier, IDbController dbController)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Row input, IDbController dbController)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Row input, Row oldInputToCompare, IDbController dbController)
        {
            throw new NotImplementedException();
        }
    }
}
