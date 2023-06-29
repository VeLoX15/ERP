using DbController;
using ERP.Core.Filters;
using ERP.Core.Models;
using System.Text;

namespace ERP.Core.Services
{
    public class CategoryService : IModelService<Category, int, CategoryFilter>
    {
        public async Task CreateAsync(Category input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = $@"INSERT INTO `erp`.`categories`
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
            string sql = "DELETE FROM `erp`.`categories` WHERE `category_id` = @GATEGORY_ID";

            await dbController.QueryAsync(sql, input.GetParameters(), cancellationToken);
        }

        public async Task<Category?> GetAsync(int categoryId, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = "SELECT * FROM `erp`.`categories` WHERE `category_id` = @CATEGORY_ID";

            Category? category = await dbController.GetFirstAsync<Category>(sql, new
            {
                CATEGORY_ID = categoryId,
            }, cancellationToken);

            return category;
        }

        public async Task<List<Category>> GetAsync(CategoryFilter filter, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            StringBuilder sqlBuilder = new();
            sqlBuilder.Append("SELECT * FROM `erp`.`categories` WHERE 1 = 1");
            sqlBuilder.AppendLine(GetFilterWhere(filter));
            sqlBuilder.AppendLine(@$"  ORDER BY `name` ASC");
            sqlBuilder.AppendLine(dbController.GetPaginationSyntax(filter.PageNumber, filter.Limit));

            string sql = sqlBuilder.ToString();

            List<Category> list = await dbController.SelectDataAsync<Category>(sql, GetFilterParameter(filter), cancellationToken);

            return list;
        }

        public Dictionary<string, object?> GetFilterParameter(CategoryFilter filter)
        {
            return new Dictionary<string, object?>
            {
                { "SEARCHPHRASE", $"%{filter.SearchPhrase}%" }
            };
        }

        public string GetFilterWhere(CategoryFilter filter)
        {
            StringBuilder sb = new();

            if (!string.IsNullOrWhiteSpace(filter.SearchPhrase))
            {
                sb.AppendLine(@" AND 
(
        UPPER(name) LIKE @SEARCHPHRASE
)");
            }

            string sql = sb.ToString();
            return sql;
        }

        public async Task<int> GetTotalAsync(CategoryFilter filter, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            StringBuilder sqlBuilder = new();
            sqlBuilder.AppendLine("SELECT COUNT(*) FROM `erp`.`categories` WHERE 1 = 1");
            sqlBuilder.AppendLine(GetFilterWhere(filter));

            string sql = sqlBuilder.ToString();

            int result = await dbController.GetFirstAsync<int>(sql, GetFilterParameter(filter), cancellationToken);

            return result;
        }

        public async Task UpdateAsync(Category input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = @"UPDATE `erp`.`categories` SET
`name` = @NAME,
`description` = @DESCRIPTION
WHERE `category_id` = @CATEGORY_ID";

            await dbController.QueryAsync(sql, input.GetParameters(), cancellationToken);
        }
    }
}
