using DbController;
using ERP.Core.Models;

namespace ERP.Core.Services
{
    public class InvoiceService : IModelService<Invoice, int>
    {
        public async Task CreateAsync(Invoice input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = $@"INSERT INTO `invoices`
(
`invoice_number`,
`total_price`,
`tax`
)
VALUES
(
@INVOICE_NUMBER,
@TOTAL_PRICE,
@TAX
); {dbController.GetLastIdSql()}";

            input.InvoiceId = await dbController.GetFirstAsync<int>(sql, input.GetParameters(), cancellationToken);
        }

        public async Task DeleteAsync(Invoice input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = "DELETE FROM `invoices` WHERE `invoice_id` = @INVOICE_ID";

            await dbController.QueryAsync(sql, input.GetParameters(), cancellationToken);
        }

        public async Task<Invoice?> GetAsync(int invoiceId, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = "SELECT * FROM `invoices` WHERE `invoice_id` = @INVOICE_ID";

            Invoice? invoice = await dbController.GetFirstAsync<Invoice>(sql, new
            {
                INVOICE_ID = invoiceId,
            }, cancellationToken);

            return invoice;
        }

        public async Task UpdateAsync(Invoice input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = @"UPDATE `invoices` SET
`invoice_number` = @INVOICE_NUMBER,
`total_price` = @TOTAL_PRICE,
`tax` = @TAX
WHERE `invoice_id` = @INVOICE_ID";

            await dbController.QueryAsync(sql, input.GetParameters(), cancellationToken);
        }
    }
}
