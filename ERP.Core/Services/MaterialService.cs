using DbController;
using ERP.Core.Filters;
using ERP.Core.Models;
using System.Text;

namespace ERP.Core.Services
{
    public class MaterialService : IModelService<Material, int, MaterialFilter>
    {
        public async Task CreateAsync(Material input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = $@"INSERT INTO `erp`.`materials`
(
`name`,
`description`
)
VALUES
(
@NAME,
@DESCRIPTION
); {dbController.GetLastIdSql()}";

            input.MaterialId = await dbController.GetFirstAsync<int>(sql, input.GetParameters(), cancellationToken);
        }

        public async Task DeleteAsync(Material input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = "DELETE FROM `erp`.`materials` WHERE `material_id` = @MATERIAL_ID";

            await dbController.QueryAsync(sql, input.GetParameters(), cancellationToken);
        }

        public async Task<Material?> GetAsync(int materialId, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = "SELECT * FROM `erp`.`materials` WHERE `material_id` = @MATERIAL_ID";

            Material? material = await dbController.GetFirstAsync<Material >(sql, new
            {
                MATERIAL_ID = materialId,
            }, cancellationToken);

            return material;
        }

        public async Task<List<Material>> GetAsync(MaterialFilter filter, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            StringBuilder sqlBuilder = new();
            sqlBuilder.Append("SELECT * FROM `erp`.`erp`.`materials` WHERE 1 = 1");
            sqlBuilder.AppendLine(GetFilterWhere(filter));
            sqlBuilder.AppendLine(@$"  ORDER BY `name` ASC");
            sqlBuilder.AppendLine(dbController.GetPaginationSyntax(filter.PageNumber, filter.Limit));

            string sql = sqlBuilder.ToString();

            List<Material> list = await dbController.SelectDataAsync<Material>(sql, GetFilterParameter(filter), cancellationToken);

            return list;
        }

        public Dictionary<string, object?> GetFilterParameter(MaterialFilter filter)
        {
            return new Dictionary<string, object?>
            {
                { "SEARCHPHRASE", $"%{filter.SearchPhrase}%" }
            };
        }

        public string GetFilterWhere(MaterialFilter filter)
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

        public async Task<int> GetTotalAsync(MaterialFilter filter, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            StringBuilder sqlBuilder = new();
            sqlBuilder.AppendLine("SELECT COUNT(*) FROM `erp`.`materials` WHERE 1 = 1");
            sqlBuilder.AppendLine(GetFilterWhere(filter));

            string sql = sqlBuilder.ToString();

            int result = await dbController.GetFirstAsync<int>(sql, GetFilterParameter(filter), cancellationToken);

            return result;
        }

        public async Task UpdateAsync(Material input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = @"UPDATE `erp`.`materials` SET
`name` = @NAME,
`description` = @DESCRIPTION
WHERE `material_id` = @MATERIAL_ID";

            await dbController.QueryAsync(sql, input.GetParameters(), cancellationToken);
        }
    }
}
