using DbController;
using ERP.Core.Filters;
using ERP.Core.Models;
using System.Text;

namespace ERP.Core.Services
{
    public class CustomerService : IModelService<Customer, int, CustomerFilter>
    {
        public async Task CreateAsync(Customer input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = $@"INSERT INTO `customers`
(
`customer_number`,
`username`,
`password`,
`salt`,
`salutation`,
`first_name`,
`last_name`,
`email`,
`telefon`,
`standard_payment_methode`,
`registration_date`,
`customer_status`,
`comment`
)
VALUES
(
@CUSTOMER_NUMBER,
@USERNAME,
@PASSWORD,
@SALT,
@SALUTATION,
@FIRST_NAME,
@LAST_NAME,
@EMAIL,
@TELEFON,
@STANDARD_PAYMENT_METHODE,
@REGISTRATION_DATE,
@CUSTOMER_STATUS,
@COMMENT
); {dbController.GetLastIdSql()}";

            input.CustomerId = await dbController.GetFirstAsync<int>(sql, input.GetParameters(), cancellationToken);
        }

        public async Task DeleteAsync(Customer input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = "DELETE FROM `customers` WHERE `customer_id` = @CUSTOMER_ID";

            await dbController.QueryAsync(sql, input.GetParameters(), cancellationToken);
        }

        public async Task<Customer?> GetAsync(int customerId, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = "SELECT * FROM `customers` WHERE `customer_id` = @CUSTOMER_ID";

            Customer? customer = await dbController.GetFirstAsync<Customer>(sql, new
            {
                CUSTOMER_ID = customerId,
            }, cancellationToken);

            return customer;
        }

        public async Task<List<Customer>> GetAsync(CustomerFilter filter, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            StringBuilder sqlBuilder = new();
            sqlBuilder.AppendLine("SELECT c.* FROM `customers` c ");
            sqlBuilder.AppendLine("WHERE 1 = 1 ");
            sqlBuilder.AppendLine(GetFilterWhere(filter));
            sqlBuilder.AppendLine(@$"ORDER BY `customer_id` DESC ");
            sqlBuilder.AppendLine(dbController.GetPaginationSyntax(filter.PageNumber, filter.Limit));

            string sql = sqlBuilder.ToString();

            List<Customer> list = await dbController.SelectDataAsync<Customer>(sql, GetFilterParameter(filter), cancellationToken);

            return list;
        }

        public Dictionary<string, object?> GetFilterParameter(CustomerFilter filter)
        {
            return new Dictionary<string, object?>
            {
                { "CUSTOMER_NUMBER", filter.CustomerNumber },
                { "USERNAME", filter.UserName },
                { "FIRST_NAME", filter.FirstName },
                { "LAST_NAME", filter.LastName },
                { "EMAIL", filter.Email },
                { "TELEFON", filter.Telefon },
                { "REGISTRATION_DATE", filter.RegistrationDate },

                { "REGISTRATION_DATE_OPERATOR", filter.RegistrationDateOperator },

                { "REGISTRATION_DATE_RANGE", filter.RegistrationDateRange }

            };
        }

        public string GetFilterWhere(CustomerFilter filter)
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

        public async Task<int> GetTotalAsync(CustomerFilter filter, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            StringBuilder sqlBuilder = new();
            sqlBuilder.AppendLine("SELECT COUNT(*) FROM `customers` WHERE 1 = 1");
            sqlBuilder.AppendLine(GetFilterWhere(filter));

            string sql = sqlBuilder.ToString();

            int result = await dbController.GetFirstAsync<int>(sql, GetFilterParameter(filter), cancellationToken);

            return result;
        }

        public async Task UpdateAsync(Customer input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = @"UPDATE `customers` SET
`customer_number` = @CUSTOMER_NUMBER,
`username` = @USERNAME,
`password` = @PASSWORD,
`salt` = @SALT,
`salutation` = @SALUTATION,
`first_name` = @FIRST_NAME,
`last_name` = @LAST_NAME,
`email` = @EMAIL,
`telefon` = @TELEFON,
`standard_payment_methode` = @STANDARD_PAYMENT_METHODE,
`registration_date` = @REGISTRATION_DATE,
`customer_status` = @CUSTOMER_STATUS,
`comment` = @COMMENT
WHERE `customer_id` = @CUSTOMER_ID";

            await dbController.QueryAsync(sql, input.GetParameters(), cancellationToken);
        }
    }
}
