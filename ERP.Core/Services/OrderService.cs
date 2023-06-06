using DbController;
using ERP.Core.Filters;
using ERP.Core.Models;
using System.Text;

namespace ERP.Core.Services
{
    public class OrderService : IModelService<Order, int, OrderFilter>
    {
        private readonly CustomerService _customerService;
        private readonly InvoiceService _invoiceService;
        private readonly AddressService _addressService;
        private readonly SizeService _sizeService;

        public OrderService(CustomerService customerService, InvoiceService invoiceService, AddressService addressService, SizeService sizeService)
        {
            _customerService = customerService;
            _invoiceService = invoiceService;
            _addressService = addressService;
            _sizeService = sizeService;
        }

        public async Task CreateAsync(Order input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = $@"INSERT INTO `orders`
(
`order_id`,
`order_number`,
`customer_id`,
`invoice_id`,
`weight`,
`size_id`,
`payment_method`,
`shipping_method`,
`delivery_address_id`,
`billing_address_id`,
`order_date`,
`delivery_date`,
`invoice_date`,
`order_status_public`,
`order_status_intern`,
`discount_id`,
`order_note`
)
VALUES
(
@ORDER_ID,
@ORDER_NUMBER,
@CUSTOMER_ID,
@INVOICE_ID,
@WEIGHT,
@SIZE_ID,
@PAYMENT_METHOD,
@SHIPPING_METHOD,
@DELIVERY_ADDRESS_ID,
@BILLING_ADDRESS_ID,
@ORDER_DATE,
@DELIVERY_DATE,
@INVOICE_DATE,
@ORDER_STATUS_PUBLIC,
@ORDER_STATUS_INTERN,
@DISCOUNT_ID,
@ORDER_NOTE
); {dbController.GetLastIdSql()}";

            input.OrderId = await dbController.GetFirstAsync<int>(sql, input.GetParameters(), cancellationToken);

            await _customerService.CreateAsync(input.Customer, dbController, cancellationToken);
            await _invoiceService.CreateAsync(input.Invoice, dbController, cancellationToken);
            await _sizeService.CreateAsync(input.Size, dbController, cancellationToken);
            await _addressService.CreateAsync(input.DeliveryAddress, dbController, cancellationToken);
            await _addressService.CreateAsync(input.BillingAddress, dbController, cancellationToken);

        }

        public async Task DeleteAsync(Order input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = "DELETE FROM `orders` WHERE `order_id` = @ORDER_ID";

            await dbController.QueryAsync(sql, input.GetParameters(), cancellationToken);

            await _customerService.DeleteAsync(input.Customer, dbController, cancellationToken);
            await _invoiceService.DeleteAsync(input.Invoice, dbController, cancellationToken);
            await _sizeService.DeleteAsync(input.Size, dbController, cancellationToken);
            await _addressService.DeleteAsync(input.DeliveryAddress, dbController, cancellationToken);
            await _addressService.DeleteAsync(input.BillingAddress, dbController, cancellationToken);
        }

        public async Task<Order?> GetAsync(int orderId, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = "SELECT * FROM `orders` WHERE `order_id` = @ORDER_ID";

            Order? order = await dbController.GetFirstAsync<Order>(sql, new
            {
                ORDER_ID = orderId,
            }, cancellationToken);

            if (order is not null)
            {
                order.Customer = await _customerService.GetAsync(order.CustomerId, dbController, cancellationToken) ?? new();
                order.Invoice = await _invoiceService.GetAsync(order.InvoiceId, dbController, cancellationToken) ?? new();
                order.Size = await _sizeService.GetAsync(order.SizeId, dbController, cancellationToken) ?? new();
                order.DeliveryAddress = await _addressService.GetAsync(order.DeliveryAddressId, dbController, cancellationToken) ?? new();
                order.DeliveryAddress = await _addressService.GetAsync(order.BillingAddressId, dbController, cancellationToken) ?? new();
            }

            return order;
        }

        public async Task<List<Order>> GetAsync(OrderFilter filter, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            StringBuilder sqlBuilder = new();
            sqlBuilder.AppendLine("SELECT o.* FROM `orders` o ");
            sqlBuilder.AppendLine("WHERE 1 = 1 ");
            sqlBuilder.AppendLine(GetFilterWhere(filter));
            sqlBuilder.AppendLine(@$"ORDER BY `order_number` DESC ");
            sqlBuilder.AppendLine(dbController.GetPaginationSyntax(filter.PageNumber, filter.Limit));

            string sql = sqlBuilder.ToString();

            List<Order> list = await dbController.SelectDataAsync<Order>(sql, GetFilterParameter(filter), cancellationToken);

            if (list.Any())
            {
                IEnumerable<int> addressIds = list.Select(x => x.DeliveryAddressId);
                sql = $"SELECT * FROM `addresses` WHERE `address_id` IN ({string.Join(",", addressIds)})";
                List<Address> addresses = await dbController.SelectDataAsync<Address>(sql, null, cancellationToken);

                foreach (var item in list)
                {
                    item.DeliveryAddress = addresses.FirstOrDefault(x => x.AddressId == item.DeliveryAddressId) ?? new();
                }
            }

            if (list.Any())
            {
                IEnumerable<int> addressIds = list.Select(x => x.BillingAddressId);
                sql = $"SELECT * FROM `addresses` WHERE `address_id` IN ({string.Join(",", addressIds)})";
                List<Address> addresses = await dbController.SelectDataAsync<Address>(sql, null, cancellationToken);

                foreach (var item in list)
                {
                    item.BillingAddress = addresses.FirstOrDefault(x => x.AddressId == item.BillingAddressId) ?? new();
                }
            }

            if (list.Any())
            {
                IEnumerable<int> sizeIds = list.Select(x => x.SizeId);
                sql = $"SELECT * FROM `sizes` WHERE `size_id` IN ({string.Join(",", sizeIds)})";
                List<Size> sizes = await dbController.SelectDataAsync<Size>(sql, null, cancellationToken);

                foreach (var item in list)
                {
                    item.Size = sizes.FirstOrDefault(x => x.SizeId == item.SizeId) ?? new();
                }
            }

            return list;
        }

        public Dictionary<string, object?> GetFilterParameter(OrderFilter filter)
        {
            return new Dictionary<string, object?>
            {
                { "ORDER_NUMBER", filter.OrderNumber },
                { "WEIGHT", filter.Weight },
                { "LENGTH", filter.Length },
                //{ "PAYMENT_METHOD", filter.PaymentMethod },
                //{ "SHIPPING_METHOD", filter.ShippingMethod },
                { "ORDER_DATE", filter.OrderDate },
                { "DELIVERY_DATE", filter.DeliveryDate },
                { "INVOICE_DATE", filter.InvoiceDate },
                //{ "ORDER_STATUS_PUBLIC", filter.OrderStatusPublic },
                //{ "ORDER_STATUS_INTERN", filter.OrderStatusIntern },

                { "WEIGHT_OPERATOR", filter.WeightOperator },
                { "LENGTH_OPERATOR", filter.LengthOperator },
                { "ORDER_DATE_OPERATOR", filter.OrderDateOperator },
                { "DELIVERY_DATE_OPERATOR", filter.DeliveryDateOperator },
                { "INVOICE_DATE_OPERATOR", filter.InvoiceDateOperator },

                { "WEIGHT_RANGE", filter.WeightRange },
                { "LENGTH_RANGE", filter.LengthRange },
                { "ORDER_DATE_RANGE", filter.OrderDateRange },
                { "DELIVERY_DATE_RANGE", filter.DeliveryDateRange },
                { "INVOICE_DATE_RANGE", filter.InvoiceDateRange }

            };
        }

        public string GetFilterWhere(OrderFilter filter)
        {
            StringBuilder sqlBuilder = new();

            Dictionary<string, object?> filterParameters = GetFilterParameter(filter);

            for (int i = 0; i <= 4; i++)
            {
                string conditionSql = ConditionFilter.FilterToSql(filterParameters, i);
                sqlBuilder.AppendLine(conditionSql);
            }

            string sql = sqlBuilder.ToString();
            return sql;
        }

        public async Task<int> GetTotalAsync(OrderFilter filter, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            StringBuilder sqlBuilder = new();
            sqlBuilder.AppendLine("SELECT COUNT(*) FROM `orders` WHERE 1 = 1");
            sqlBuilder.AppendLine(GetFilterWhere(filter));

            string sql = sqlBuilder.ToString();

            int result = await dbController.GetFirstAsync<int>(sql, GetFilterParameter(filter), cancellationToken);

            return result;
        }

        public async Task UpdateAsync(Order input, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            string sql = @"UPDATE `orders` SET
`order_id` = @ORDER_ID,
`order_number` = @ORDER_NUMBER,
`customer_id` = @CUSTOMER_ID,
`invoice_id` = @INVOICE_ID,
`weight` = @WEIGHT,
`size_id` = @SIZE_ID,
`payment_method` = @PAYMENT_METHOD,
`shipping_method` = @SHIPPING_METHOD,
`delivery_address_id` = @DELIVERY_ADDRESS_ID,
`billing_address_id` = @BILLING_ADDRESS_ID,
`order_date` = @ORDER_DATE,
`delivery_date` = @DELIVERY_DATE,
`invoice_date` = @INVOICE_DATE,
`order_status_public` = @ORDER_STATUS_PUBLIC,
`order_status_intern` = @ORDER_STATUS_INTERN,
`discount_id` = @DISCOUNT_ID,
`order_note` = @ORDER_NOT
WHERE `article_id` = @ARTICLE_ID";

            await dbController.QueryAsync(sql, input.GetParameters(), cancellationToken);

            await _customerService.UpdateAsync(input.Customer, dbController, cancellationToken);
            await _invoiceService.UpdateAsync(input.Invoice, dbController, cancellationToken);
            await _sizeService.UpdateAsync(input.Size, dbController, cancellationToken);
            await _addressService.UpdateAsync(input.DeliveryAddress, dbController, cancellationToken);
            await _addressService.UpdateAsync(input.BillingAddress, dbController, cancellationToken);
        }
    }
}
