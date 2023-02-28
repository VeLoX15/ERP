using ERP.Core.Services;
using ERP.Core.Interfaces;
using ERP.Core.Models;
using DbController;

namespace ERP.Core.Services
{
    public class ArticleService : IModelService<Article, int>
    {
        public Task CreateAsync(Article input, IDbController dbController)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Article input, IDbController dbController)
        {
            throw new NotImplementedException();
        }

        public Task<Article?> GetAsync(int identifier, IDbController dbController)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Article input, IDbController dbController)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Article input, Article oldInputToCompare, IDbController dbController)
        {
            throw new NotImplementedException();
        }
    }
}
