using DbController;
using ERP.Core.Filters;
using ERP.Core.Models;
using System.Text;

namespace ERP.Core.Services
{
    public class SectionService : IModelService<Section, int, SectionFilter>
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

        public async Task<List<Section>> GetAsync(SectionFilter filter, IDbController dbController, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            StringBuilder sqlBuilder = new();
            sqlBuilder.AppendLine("SELECT w.* FROM `sections` w ");
            sqlBuilder.AppendLine("WHERE 1 = 1 ");
            sqlBuilder.AppendLine(GetFilterWhere(filter));
            sqlBuilder.AppendLine(@$"ORDER BY `section_id` DESC ");
            sqlBuilder.AppendLine(dbController.GetPaginationSyntax(filter.PageNumber, filter.Limit));

            string sql = sqlBuilder.ToString();

            List<Section> list = await dbController.SelectDataAsync<Section>(sql, GetFilterParameter(filter), cancellationToken);

            return list;
        }

        public Dictionary<string, object?> GetFilterParameter(SectionFilter filter)
        {
            return new Dictionary<string, object?>
            {
                { "NAME", filter.Name },
                { "NUMBER", filter.Number }
            };
        }

        public string GetFilterWhere(SectionFilter filter)
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

        public Task<int> GetTotalAsync(SectionFilter filter, IDbController dbController, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
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