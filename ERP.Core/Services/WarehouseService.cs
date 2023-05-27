using DbController;
using ERP.Core.Filters;
using ERP.Core.Models;
using System.Text;

namespace ERP.Core.Services
{
    public class WarehouseService : IModelService<Warehouse, int, WarehouseFilter>
    {
        public async Task CreateAsync(Warehouse input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = $@"INSERT INTO `warehouses`
(
`name`,
`number`
)
VALUES
(
@NAME,
@NUMBER
); {dbController.GetLastIdSql()}";

            input.WarehouseId = await dbController.GetFirstAsync<int>(sql, input.GetParameters(), cancellationToken);
        }

        public async Task DeleteAsync(Warehouse input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = "DELETE FROM `warehouses` WHERE `warehouse_id` = @WAREHOUSE_ID";

            await dbController.QueryAsync(sql, input.GetParameters(), cancellationToken);
        }

        public async Task<Warehouse?> GetAsync(int warehouseId, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = "SELECT * FROM `warehouses` WHERE `warehouse_id` = @WAREHOUSE_ID";

            Warehouse? warehouse = await dbController.GetFirstAsync<Warehouse>(sql, new
            {
                WAREHOUSE_ID = warehouseId,
            }, cancellationToken);

            return warehouse;
        }

        public async Task<List<Warehouse>> GetAllAsync(IDbController dbController)
        {
            string sql = "SELECT * FROM `warehouses`";

            var list = await dbController.SelectDataAsync<Warehouse>(sql);
            return list;
        }

        public async Task<List<Warehouse>> GetAsync(WarehouseFilter filter, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            StringBuilder sqlBuilder = new();
            sqlBuilder.AppendLine("SELECT w.* FROM `warehouses` w ");
            sqlBuilder.AppendLine("WHERE 1 = 1 ");
            sqlBuilder.AppendLine(GetFilterWhere(filter));
            sqlBuilder.AppendLine(@$"ORDER BY `warehouse_id` DESC ");
            sqlBuilder.AppendLine(dbController.GetPaginationSyntax(filter.PageNumber, filter.Limit));

            string sql = sqlBuilder.ToString();

            List<Warehouse> list = await dbController.SelectDataAsync<Warehouse>(sql, GetFilterParameter(filter), cancellationToken);

            return list;
        }

        public Dictionary<string, object?> GetFilterParameter(WarehouseFilter filter)
        {
            return new Dictionary<string, object?>
            {
                { "NAME", filter.Name },
                { "NUMBER", filter.Number }
            };
        }

        public string GetFilterWhere(WarehouseFilter filter)
        {
            StringBuilder sqlBuilder = new();

            Dictionary<string, object?> filterParameters = GetFilterParameter(filter);

            for (int i = 0; i <= 1; i++)
            {
                string conditionSql = ConditionFilter.FilterToSql(filterParameters, i);
                sqlBuilder.AppendLine(conditionSql);
            }

            string sql = sqlBuilder.ToString();
            return sql;
        }

        public async Task<int> GetTotalAsync(WarehouseFilter filter, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            StringBuilder sqlBuilder = new();
            sqlBuilder.AppendLine("SELECT COUNT(*) FROM `warehouses` WHERE 1 = 1");
            sqlBuilder.AppendLine(GetFilterWhere(filter));

            string sql = sqlBuilder.ToString();

            int result = await dbController.GetFirstAsync<int>(sql, GetFilterParameter(filter), cancellationToken);

            return result;
        }

        public async Task UpdateAsync(Warehouse input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = @"UPDATE `warehouses` SET
`name` = @NAME,
`number` = @NUMBER
WHERE `warehouse_id` = @WAREHOUSE_ID";

            await dbController.QueryAsync(sql, input.GetParameters(), cancellationToken);
        }
    }
}
