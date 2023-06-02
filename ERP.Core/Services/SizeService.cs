using DbController;
using ERP.Core.Models;

namespace ERP.Core.Services
{
    public class SizeService : IModelService<Size, int>
    {
        public async Task CreateAsync(Size input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = $@"INSERT INTO `sizes`
(
`length`,
`width`,
`height`,
`volume`
)
VALUES
(
@LENGTH,
@WIDTH,
@HEIGHT,
@VOLUME
); {dbController.GetLastIdSql()}";

            input.SizeId = await dbController.GetFirstAsync<int>(sql, input.GetParameters(), cancellationToken);
        }

        public async Task DeleteAsync(Size input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = "DELETE FROM `sizes` WHERE `size_id` = @SIZE_ID";

            await dbController.QueryAsync(sql, input.GetParameters(), cancellationToken);
        }

        public async Task<Size?> GetAsync(int sizeId, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = "SELECT * FROM `sizes` WHERE `size_id` = @SIZE_ID";

            Size? size = await dbController.GetFirstAsync<Size>(sql, new
            {
                SIZE_ID = sizeId,
            }, cancellationToken);

            return size;
        }

        public async Task UpdateAsync(Size input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = @"UPDATE `sizes` SET
`length` = @LENGTH,
`width` = @WIDTH,
`hight` = @HIGHT,
`volume` = @VOLUME
WHERE `size_id` = @SIZE_ID";

            await dbController.QueryAsync(sql, input.GetParameters(), cancellationToken);
        }
    }
}
