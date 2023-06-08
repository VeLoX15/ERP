using DbController;
using ERP.Core.Filters;
using ERP.Core.Models;
using System.Text;

namespace ERP.Core.Services
{
    public class CompartmentService : IModelService<Compartment, int, WarehouseFilter>
    {
        private readonly ArticleService _articleService;

        public CompartmentService(ArticleService articleService)
        {
            _articleService = articleService;
        }

        public async Task CreateAsync(Compartment input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = $@"INSERT INTO `compartments`
(
`number`
)
VALUES
(
@NUMBER
); {dbController.GetLastIdSql()}";

            input.CompartmentId = await dbController.GetFirstAsync<int>(sql, input.GetParameters(), cancellationToken);

            await _articleService.CreateAsync(input.Article, dbController, cancellationToken);
        }

        public async Task DeleteAsync(Compartment input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = "DELETE FROM `compartments` WHERE `compartment_id` = @COMPARTMENT_ID";

            await dbController.QueryAsync(sql, input.GetParameters(), cancellationToken);

            await _articleService.DeleteAsync(input.Article, dbController, cancellationToken);
        }

        public async Task<Compartment?> GetAsync(int compartmentId, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = "SELECT * FROM `compartments` WHERE `compartment_id` = @COMPARTMENT_ID";

            Compartment? compartment = await dbController.GetFirstAsync<Compartment>(sql, new
            {
                COMPARTMENT_ID = compartmentId,
            }, cancellationToken);

            if (compartment is not null)
            {
                compartment.Article = await _articleService.GetAsync(compartment.ArticleId, dbController, cancellationToken) ?? new();
            }

            return compartment;
        }

        public async Task<List<Compartment>> GetAsync(WarehouseFilter filter, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            StringBuilder sqlBuilder = new();
            sqlBuilder.AppendLine("SELECT c.*, r.`sort_number` AS `row_sort_number`, s.`sort_number` AS `rack_sort_number` FROM `compartments` c ");
            sqlBuilder.AppendLine("JOIN `rows` r ON c.`row_id` = r.`row_id` ");
            sqlBuilder.AppendLine("JOIN `racks` s ON c.`rack_id` = s.`rack_id` ");
            sqlBuilder.AppendLine("WHERE 1 = 1 ");
            sqlBuilder.AppendLine($@"AND c.`warehouse_id` = {filter.WarehouseId} ");
            sqlBuilder.AppendLine($@"AND c.`section_id` = {filter.SectionId} ");
            sqlBuilder.AppendLine(GetFilterWhere(filter));
            sqlBuilder.AppendLine($@"ORDER BY c.`sort_number` DESC ");
            sqlBuilder.AppendLine(dbController.GetPaginationSyntax(filter.PageNumber, filter.Limit));

            string sql = sqlBuilder.ToString();

            List<Compartment> list = await dbController.SelectDataAsync<Compartment>(sql, GetFilterParameter(filter), cancellationToken);

            if (list.Any())
            {
                IEnumerable<int> articleIds = list.Select(x => x.ArticleId);
                sql = $"SELECT * FROM `articles` WHERE `article_id` IN ({string.Join(",", articleIds)})";
                List<Article> articles = await dbController.SelectDataAsync<Article>(sql, null, cancellationToken);

                foreach (var item in list)
                {
                    item.Article = articles.FirstOrDefault(x => x.ArticleId == item.ArticleId) ?? new();
                }
            }

            return list;
        }

        public Dictionary<string, object?> GetFilterParameter(WarehouseFilter filter)
        {
            return new Dictionary<string, object?>
            {
                { "WAREHOUSE_ID", filter.WarehouseId }
            };
        }

        public string GetFilterWhere(WarehouseFilter filter)
        {
            StringBuilder sqlBuilder = new();
            sqlBuilder.AppendLine(WarehouseFilter.ExtractNumber(filter.StorageLocation, "r"));
            sqlBuilder.AppendLine(WarehouseFilter.ExtractNumber(filter.StorageLocation, "s"));
            sqlBuilder.AppendLine(WarehouseFilter.ExtractNumber(filter.StorageLocation, "c"));
            string sql = sqlBuilder.ToString();

            return sql;
        }

        public async Task<List<Compartment>> GetCompartmentsByArticleIdAsync(WarehouseFilter filter, IDbController dbController, CancellationToken cancellationToken = default)
        {
            StringBuilder sqlBuilder = new();
            sqlBuilder.AppendLine("SELECT c.*, a.`article_number` AS `article_number`, a.`name` AS `name` FROM `compartments` c ");
            sqlBuilder.AppendLine("JOIN `articles` a ON c.`article_id` = a.`article_id` ");
            sqlBuilder.AppendLine("WHERE 1 = 1 ");
            sqlBuilder.AppendLine($@"AND a.`article_number` = '{filter.ArticleNumber}' ");
            sqlBuilder.AppendLine($@"ORDER BY a.`article_number` DESC ");
            sqlBuilder.AppendLine(dbController.GetPaginationSyntax(filter.PageNumber, filter.Limit));
            string sql = sqlBuilder.ToString();

            List<Compartment> list = await dbController.SelectDataAsync<Compartment>(sql, GetFilterParameter(filter), cancellationToken);

            if (list.Any())
            {
                IEnumerable<int> articleIds = list.Select(x => x.ArticleId);
                sql = $"SELECT * FROM `articles` WHERE `article_id` IN ({string.Join(",", articleIds)})";
                List<Article> articles = await dbController.SelectDataAsync<Article>(sql, null, cancellationToken);

                foreach (var item in list)
                {
                    item.Article = articles.FirstOrDefault(x => x.ArticleId == item.ArticleId) ?? new();
                }

            }

            return list;
        }

        public async Task<int> GetTotalAsync(WarehouseFilter filter, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            StringBuilder sqlBuilder = new();
            sqlBuilder.AppendLine("SELECT COUNT(*) FROM `compartments` WHERE 1 = 1");
            sqlBuilder.AppendLine(GetFilterWhere(filter));

            string sql = sqlBuilder.ToString();

            int result = await dbController.GetFirstAsync<int>(sql, GetFilterParameter(filter), cancellationToken);

            return result;
        }

        public async Task UpdateAsync(Compartment input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = @"UPDATE `compartments` SET
`number` = @NUMBER
WHERE `compartment_id` = @COMPARTMENT_ID";

            await dbController.QueryAsync(sql, input.GetParameters(), cancellationToken);

            await _articleService.UpdateAsync(input.Article, dbController, cancellationToken);
        }
    }
}
