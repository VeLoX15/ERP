using DbController;
using ERP.Core.Models;

namespace ERP.Core.Services
{
    public class MaterialService : IModelService<Material, int>
    {
        public async Task CreateAsync(Material input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = $@"INSERT INTO `materials`
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
            string sql = "DELETE FROM `materials` WHERE `material_id` = @MATERIAL_ID";

            await dbController.QueryAsync(sql, input.GetParameters(), cancellationToken);
        }

        public async Task<Material?> GetAsync(int materialId, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = "SELECT * FROM `materials` WHERE `material_id` = @MATERIAL_ID";

            Material? material = await dbController.GetFirstAsync<Material >(sql, new
            {
                MATERIAL_ID = materialId,
            }, cancellationToken);

            return material;
        }

        public async Task UpdateAsync(Material input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = @"UPDATE `materials` SET
`name` = @NAME,
`description` = @DESCRIPTION
WHERE `material_id` = @MATERIAL_ID";

            await dbController.QueryAsync(sql, input.GetParameters(), cancellationToken);
        }
    }
}
