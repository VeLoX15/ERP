using DbController;
using ERP.Core.Models;

namespace ERP.Core.Services
{
    public class CategoryService : IModelService<Category, int>
    {
        public async Task CreateAsync(Category input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = $@"INSERT INTO `categories`
(
`name`,
`description`
)
VALUES
(
@NAME,
@DESCRIPTION
); {dbController.GetLastIdSql()}";

            input.CategoryId = await dbController.GetFirstAsync<int>(sql, input.GetParameters(), cancellationToken);
        }

        public async Task DeleteAsync(Category input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = "DELETE FROM `categories` WHERE `category_id` = @GATEGORY_ID";

            await dbController.QueryAsync(sql, input.GetParameters(), cancellationToken);
        }

        public async Task<Category?> GetAsync(int categoryId, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = "SELECT * FROM `categories` WHERE `category_id` = @CATEGORY_ID";

            Category? category = await dbController.GetFirstAsync<Category>(sql, new
            {
                CATEGORY_ID = categoryId,
            }, cancellationToken);

            return category;
        }

        public async Task UpdateAsync(Category input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = @"UPDATE `categories` SET
`name` = @NAME,
`description` = @DESCRIPTION
WHERE `category_id` = @CATEGORY_ID";

            await dbController.QueryAsync(sql, input.GetParameters(), cancellationToken);
        }
    }
}
