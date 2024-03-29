﻿using DbController;
using ERP.Core.Filters;
using ERP.Core.Models;
using System.Collections.Generic;
using System.Text;

namespace ERP.Core.Services
{
    public class ArticleService : IModelService<Article, int, ArticleFilter>
    {
        private readonly SizeService _sizeService;

        public ArticleService(SizeService sizeService)
        {
            _sizeService = sizeService;
        }

        public async Task CreateAsync(Article input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = $@"INSERT INTO `articles`
(
`article_number`,
`name`,
`description`,
`size_id`,
`weight`,
`inclusion_date`,
`purchase_price`,
`selling_price`,
`is_bundle`
)
VALUES
(
@ARTICLE_NUMBER,
@NAME,
@DESCRIPTION,
@SIZE_ID,
@WEIGHT,
@INCLUSION_DATE,
@PURCHASE_PRICE,
@SELLING_PRICE,
@IS_BUNDLE
); {dbController.GetLastIdSql()}";

            input.ArticleId = await dbController.GetFirstAsync<int>(sql, input.GetParameters(), cancellationToken);

            await _sizeService.CreateAsync(input.Size, dbController, cancellationToken);
        }

        public async Task DeleteAsync(Article input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = "DELETE FROM `articles` WHERE `article_id` = @ARTICLE_ID";

            await dbController.QueryAsync(sql, input.GetParameters(), cancellationToken);

            await _sizeService.DeleteAsync(input.Size, dbController, cancellationToken);
        }

        public async Task<Article?> GetAsync(int articleId, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = "SELECT * FROM `articles` WHERE `article_id` = @ARTICLE_ID";

            Article? article = await dbController.GetFirstAsync<Article>(sql, new
            {
                ARTICLE_ID = articleId,
            }, cancellationToken);

            if(article is not null)
            {
                await _sizeService.GetAsync(article.SizeId, dbController, cancellationToken);
            }

            return article;
        }

        public async Task<List<Article>> GetAsync(ArticleFilter filter, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            StringBuilder sqlBuilder = new();
            sqlBuilder.AppendLine("SELECT a.* FROM `articles` a ");
            sqlBuilder.AppendLine("WHERE 1 = 1 ");
            sqlBuilder.AppendLine(GetFilterWhere(filter));
            sqlBuilder.AppendLine(@$"ORDER BY `article_number` DESC ");
            sqlBuilder.AppendLine(dbController.GetPaginationSyntax(filter.PageNumber, filter.Limit));

            string sql = sqlBuilder.ToString();

            List<Article> list = await dbController.SelectDataAsync<Article>(sql, GetFilterParameter(filter), cancellationToken);

            if (list.Any())
            {
                IEnumerable<int> sizeIds = list.Select(x => x.SizeId);
                sql = $"SELECT * FROM `sizes` WHERE `size_id` IN ({string.Join(",", sizeIds)})";
                List<Size> sizes = await dbController.SelectDataAsync<Size>(sql, null, cancellationToken);

                foreach (var item in list)
                {
                    item.Size = sizes.FirstOrDefault(x => x.SizeId == item.SizeId) ?? new();
                }
            }

            return list;
        }

        public Dictionary<string, object?> GetFilterParameter(ArticleFilter filter)
        {
            return new Dictionary<string, object?>
            {
                { "ARTICLE_NUMBER", filter.ArticleNumber },
                { "NAME", filter.Name },
                { "WEIGHT", filter.Weight },
                { "INCLUSION_DATE", filter.InclusionDate },
                { "PURCHASE_PRICE", filter.PurchasePrice },
                { "SELLING_PRICE", filter.SellingPrice },
                { "IS_BUNDLE", filter.IsBundle },

                { "WEIGHT_OPERATOR", filter.WeightOperator },
                { "INCLUSION_DATE_OPERATOR", filter.InclusionDateOperator },
                { "PURCHASE_PRICE_OPERATOR", filter.PurchasePriceOperator },
                { "SELLING_PRICE_OPERATOR", filter.SellingPriceOperator },

                { "WEIGHT_RANGE", filter.WeightRange },
                { "INCLUSION_DATE_RANGE", filter.InclusionDateRange },
                { "PURCHASE_PRICE_RANGE", filter.PurchasePriceRange },
                { "SELLING_PRICE_RANGE", filter.SellingPriceRange }
            };
        }

        public string GetFilterWhere(ArticleFilter filter)
        {
            StringBuilder sqlBuilder = new();

            Dictionary<string, object?> filterParameters = GetFilterParameter(filter);

            for (int i = 0; i <= 6; i++)
            {
                string conditionSql = ConditionFilter.FilterToSql(filterParameters, i);
                sqlBuilder.AppendLine(conditionSql);
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
            cancellationToken.ThrowIfCancellationRequested();
            string sql = @"UPDATE `articles` SET
`article_number` = @ARTICLE_NUMBER,
`name` = @NAME,
`description` = @DESCRIPTION,
`size_id` = @SIZE_ID,
`weight` = @WEIGHT,
`inclusion_date` = @INCLUSION_DATE,
`purchase_price` = @PURCHASE_PRICE,
`selling_price` = @SELLING_PRICE,
`is_bundle` = @IS_BUNDLE
WHERE `article_id` = @ARTICLE_ID";

            await dbController.QueryAsync(sql, input.GetParameters(), cancellationToken);

            await _sizeService.UpdateAsync(input.Size, dbController, cancellationToken);
        }
    }
}
