using DbController;
using ERP.Core.Models;

namespace ERP.Core.Services
{
    public class SectionService : IModelService<Section, int>
    {
        public async Task CreateAsync(Section input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = $@"INSERT INTO `sections`
(
`name`,
`number`
)
VALUES
(
@NAME,
@NUMBER
); {dbController.GetLastIdSql()}";

            input.SectionId = await dbController.GetFirstAsync<int>(sql, input.GetParameters(), cancellationToken);
        }

        public async Task DeleteAsync(Section input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = "DELETE FROM `sections` WHERE `section_id` = @SECTION_ID";

            await dbController.QueryAsync(sql, input.GetParameters(), cancellationToken);
        }

        public async Task<Section?> GetAsync(int sectionId, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = "SELECT * FROM `sections` WHERE `section_id` = @SECTION_ID";

            Section? section = await dbController.GetFirstAsync<Section>(sql, new
            {
                SECTION_ID = sectionId
            }, cancellationToken);

            return section;
        }

        public async Task<List<Section>> GetSectionsByWarehouseId(int warehouseId, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = "SELECT * FROM `sections` WHERE `warehouse_id` = @WAREHOUSE_ID";

            if(warehouseId > 0)
            {
                var sections = await dbController.SelectDataAsync<Section>(sql, new 
                { 
                    WAREHOUSE_ID = warehouseId 
                }, cancellationToken);
                return sections;
            }
            return new();
        }

        public async Task UpdateAsync(Section input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = @"UPDATE `sections` SET
`name` = @NAME,
`number` = @NUMBER
WHERE `section_id` = @SECTION_ID";

            await dbController.QueryAsync(sql, input.GetParameters(), cancellationToken);
        }
    }
}