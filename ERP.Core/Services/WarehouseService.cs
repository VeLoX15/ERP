using DbController;
using ERP.Core.Filters;
using ERP.Core.Interfaces;
using ERP.Core.Models;

namespace ERP.Core.Services
{
    public class WarehouseService : IModelService<Warehouse, int, WarehouseFilter>
    {
        public async Task CreateAsync(Warehouse input, IDbController dbController)
        {
            string sql = @$"INSERT INTO articles
(
warehouse_id,
name,
number,
sort_number
)
VALUES
(
@WAREHOUSE_ID,
@NAME,
@NUMBER,
@SORT_NUMBER
); {dbController.GetLastIdSql()}";

            input.WarehouseId = await dbController.GetFirstAsync<int>(sql, input.GetParameters());
        }

        public async Task DeleteAsync(Warehouse input, IDbController dbController)
        {
            string sql = "DELETE FROM warehouses WHERE warehouse_id = @WAREHOUSE_ID";

            await dbController.QueryAsync(sql, new
            {
                WAREHOUSE_ID = input.WarehouseId
            });
        }

        public Task<Warehouse?> GetAsync(int identifier, IDbController dbController)
        {
            throw new NotImplementedException();
        }

        public Task<List<Warehouse>> GetAsync(WarehouseFilter filter, IDbController dbController)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, object?> GetFilterParameter(WarehouseFilter filter)
        {
            throw new NotImplementedException();
        }

        public string GetFilterWhere(WarehouseFilter filter)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetTotalAsync(WarehouseFilter filter, IDbController dbController)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Warehouse input, IDbController dbController)
        {
            string sql = @"UPDATE warehouses SET 
warehouse_id = @WAREHOUSE_ID,
name = @NAME,
number = @NUMBER,
sort_number = @SORT_NUMBER";

            await dbController.QueryAsync(sql, input.GetParameters());
        }

        public Task UpdateAsync(Warehouse input, Warehouse oldInputToCompare, IDbController dbController)
        {
            throw new NotImplementedException();
        }
    }
}
