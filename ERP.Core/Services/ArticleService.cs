using DbController;
using ERP.Core.Filters;
using ERP.Core.Models;
using System.Text;
using System.Xml.Linq;

namespace ERP.Core.Services
{
    public class ArticleService : IModelService<Article, int, ArticleFilter>
    {
        public async Task CreateAsync(Article input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = $@"INSERT INTO `articles`
(
`article_number`,
`name`,
`description`,
`weight`,
`length`,
`stock`,
`assortment_intake`,
`purchase_price`,
`selling_price`,
`is_bundle`

)
VALUES
(
@ARTICLE_NUMBER,
@NAME,
@DESCRIPTION,
@WEIGHT,
@LENGTH,
@STOCK,
@ASSORTMENT_INTAKE,
@PURCHASE_PRICE,
@SELLING_PRICE,
@IS_BUNDLE
); {dbController.GetLastIdSql()}";

            input.ArticleId = await dbController.GetFirstAsync<int>(sql, input.GetParameters(), cancellationToken);
        }

        public async Task DeleteAsync(Article input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = "DELETE FROM `articles` WHERE `article_id` = @ARTICLE_ID";

            await dbController.QueryAsync(sql, input.GetParameters(), cancellationToken);
        }

        public async Task<Article?> GetAsync(int articleId, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = "SELECT * FROM `articles` WHERE `article_id` = @ARTICLE_ID";

            Article? article = await dbController.GetFirstAsync<Article>(sql, new
            {
                FORM_ID = articleId,
            }, cancellationToken);

            return article;
        }

        public async Task<List<Article>> GetAsync(ArticleFilter filter, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            StringBuilder sqlBuilder = new();
            sqlBuilder.AppendLine("SELECT a.* FROM 'article' a");
            sqlBuilder.AppendLine("WHERE 1 = 1");
            sqlBuilder.AppendLine(GetFilterWhere(filter));
            sqlBuilder.AppendLine(@$"  ORDER BY 'article_id' DESC");
            sqlBuilder.AppendLine(dbController.GetPaginationSyntax(filter.PageNumber, filter.Limit));

            string sql = sqlBuilder.ToString();

            List<Article> list = await dbController.SelectDataAsync<Article>(sql, GetFilterParameter(filter), cancellationToken);

            return list;
        }

        public Dictionary<string, object?> GetFilterParameter(ArticleFilter filter)
        {
            return new Dictionary<string, object?>
            {
                { "ARTICLE_ID", filter.ArticleId },
                { "ARTICLE_NUMBER", filter.ArticleNumber },
                { "NAME", filter.Name },
                { "WEIGHT", filter.Weight },
                { "LENGTH", filter.Length },
                { "STOCK", filter.Stock },
                { "ASSORTMENT_INTAKE", filter.AssortmentIntake },
                { "PURCHASE_PRICE", filter.PurchasePrice },
                { "SELLING_PRICE", filter.SellingPrice },
                { "IS_BUNDLE", filter.IsBundle }
            };
        }

        public string GetFilterWhere(ArticleFilter filter)
        {
            StringBuilder sqlBuilder = new StringBuilder();

            if (filter.ArticleNumber > 0)
            {
                sqlBuilder.AppendLine(@" AND 'article_number' = @ARTICLE_NUMBER");
            }
            if (filter.Name is not null)
            {
                sqlBuilder.AppendLine(@" AND 'name' = @NAME");
            }
            if (filter.Weight > 0)
            {
                sqlBuilder.AppendLine(@" AND 'weight' = @WEIGHT");
            }
            if (filter.Length > 0)
            {
                sqlBuilder.AppendLine(@" AND 'length' = @LENGTH");
            }
            //if (filter.AssortmentIntake)
            //{
            //    sqlBuilder.AppendLine(@" AND 'assortment_intake' = @ASSORTMENT_INTAKE");
            //}
            if (filter.PurchasePrice > 0)
            {
                sqlBuilder.AppendLine(@" AND 'purchase_price' = @PURCHASE_PRICE");
            }
            if (filter.SellingPrice > 0)
            {
                sqlBuilder.AppendLine(@" AND 'selling_price' = @SELLING_PRICE");
            }
            if (filter.IsBundle is true)
            {
                sqlBuilder.AppendLine(@" AND 'is_bundle' = @IS_BUNDLE");
            }

            string sql = sqlBuilder.ToString();
            return sql;
        }

        public async Task<int> GetTotalAsync(ArticleFilter filter, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            StringBuilder sqlBuilder = new();
            sqlBuilder.AppendLine("SELECT COUNT(*) FROM `articles` WHERE 1 = 1");
            sqlBuilder.AppendLine(GetFilterWhere(filter));

            string sql = sqlBuilder.ToString();

            int result = await dbController.GetFirstAsync<int>(sql, GetFilterParameter(filter), cancellationToken);

            return result;
        }

        public async Task UpdateAsync(Article input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            string sql = @"UPDATE `articles` SET
`article_number` = @ARTICLE_NUMBER,
`name` = @NAME,
`description` = @DESCRIPTION,
`weight` = @WEIGHT,
`length` = @LENGTH,
`stock` = @STOCK,
`assortment_intake` = @ASSORTMENT_INTAKE,
`purchase_price` = @PURCHASE_PRICE,
`selling_price` = @SELLING_PRICE,
`is_bundle` = @IS_BUNDLE
WHERE `article_id` = @ARTICLE_ID";

            await dbController.QueryAsync(sql, input.GetParameters());
        }
    }
}
