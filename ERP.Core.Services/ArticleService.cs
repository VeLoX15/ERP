using ERP.Core.Interfaces;
using ERP.Core.Models;
using DbController;

namespace ERP.Core.Services
{
    public class ArticleService : IModelService<Article, int>
    {
        public async Task CreateAsync(Article input, IDbController dbController)
        {
            string sql = @$"INSERT INTO articles
(
article_id,
article_number,
name,
description,
weight,
length,
stock,
assortment_intake,
sale_net,
sale_gross,
purchase_net,
is_bundle,
bundle_articles,
categories,
materials
)
VALUES
(
@ARTICLE_ID,
@ARTICLE_NUMBER,
@NAME,
@DESCRIPTION,
@WEIGHT,
@LENGTH,
@STOCK,
@ASSORTMENT_INTAKE,
@SALE_NET,
@SALE_GROSS,
@PURCHASE_NET,
@IS_BUNDLE,
@BUNDLE_ARTICLES,
@CATEGORIES,
@MATERIALS
); {dbController.GetLastIdSql()}";

            input.ArticleId = await dbController.GetFirstAsync<int>(sql, input.GetParameters());
        }

        public async Task DeleteAsync(Article input, IDbController dbController)
        {
            string sql = "DELETE FROM articles WHERE article_id = @ARTICLE_ID";

            await dbController.QueryAsync(sql, new
            {
                ARTICLE_ID = input.ArticleId
            });
        }

        public async Task<Article?> GetAsync(int articleId, IDbController dbController)
        {
            string sql = "SELECT * FROM forms WHERE form_id = @FORM_ID";

            Article? article = await dbController.GetFirstAsync<Article>(sql, new
            {
                ARTICLE_ID = articleId,
            });

            return article;
        }

        public async Task UpdateAsync(Article input, IDbController dbController)
        {
            string sql = @"UPDATE articles SET 
article_id = @ARTICLE_ID,
article_number = @ARTICLE_NUMBER,
name = @NAME,
description = @DESCRIPTION,
weight = @WEIGHT,
length = @LENGTH,
stock = @STOCK,
assortment_intake = @ASSORTMENT_INTAKE,
sale_net = @SALE_NET,
sale_gross = @SALE_GROSS,
purchase_net = @PURCHASE_NET,
is_bundle = @IS_BUNDLE,
bundle_articles = @BUNDLE_ARTICLES,
categories = @CATEGORIES,
materials = @MATERIALS";

            await dbController.QueryAsync(sql, input.GetParameters());
        }

        public Task UpdateAsync(Article input, Article oldInputToCompare, IDbController dbController)
        {
            throw new NotImplementedException();
        }
    }
}
