using DbController;
using ERP.Core.Models;

namespace ERP.Core.Services
{
    public class AddressService : IModelService<Address, int>
    {
        public async Task CreateAsync(Address input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = $@"INSERT INTO `addresses`
(
`street`,
`house_number`,
`city`,
`state`,
`postal_code`,
`country_id`
)
VALUES
(
@STREET,
@HOUSE_NUMBER,
@CITY,
@STATE,
@POSTAL_CODE,
@COUNTRY_ID
); {dbController.GetLastIdSql()}";

            input.AddressId = await dbController.GetFirstAsync<int>(sql, input.GetParameters(), cancellationToken);
        }

        public async Task DeleteAsync(Address input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = "DELETE FROM `addresses` WHERE `address_id` = @ADDRESS_ID";

            await dbController.QueryAsync(sql, input.GetParameters(), cancellationToken);
        }

        public async Task<Address?> GetAsync(int addressId, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = "SELECT * FROM `addresses` WHERE `address_id` = @ADDRESS_ID";

            Address? address = await dbController.GetFirstAsync<Address>(sql, new
            {
                ADDRESS_ID = addressId,
            }, cancellationToken);

            return address;
        }

        public async Task UpdateAsync(Address input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = @"UPDATE `addresses` SET
`street` = @STREET,
`house_number` = @HOUSE_NUMBER,
`city` = @CITY,
`state` = @STATE,
`postal_code` = @POSTAL_CODE,
`country_id = @COUNTRY_ID
WHERE `material_id` = @MATERIAL_ID";

            await dbController.QueryAsync(sql, input.GetParameters(), cancellationToken);
        }
    }
}
