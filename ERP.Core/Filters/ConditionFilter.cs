using Google.Protobuf.WellKnownTypes;

namespace ERP.Core.Filters
{
    public class ConditionFilter
    {
        public static string FilterToSql(Dictionary<string, object?> dict, int i)
        {
            string sql = string.Empty;

            var value = dict.Values.ElementAt(i);

            string key = dict.Keys.ElementAt(i);

            if ((value is int || value is decimal) && value is not null)
            {
                switch (dict[$"{key}_OPERATOR"])
                {
                    case 0:
                        sql = $@"AND `{key.ToLower()}` = {value} ";
                        break;
                    case 1:
                        sql = $@"AND `{key.ToLower()}` BETWEEN {value} AND {dict[$"{key}_RANGE"]} ";
                        break;
                    case 2:
                        sql = $@"AND `{key.ToLower()}` <= {value} ";
                        break;
                    case 3:
                        sql = $@"AND `{key.ToLower()}` >= {value} ";
                        break;
                }
            }
            else if (value is string stringValue && !string.IsNullOrWhiteSpace(value as string))
            {
                sql = $@"AND UPPER(`{key.ToLower()}`) LIKE '%{stringValue.ToUpper()}%' ";
            }
            else if (value is DateTime && value is not null)
            {
                switch (dict[$"{key}_OPERATOR"])
                {
                    case 0:
                        sql = $@" AND `{key.ToLower()}` = {value} ";
                        break;
                    case 1:
                        sql = $@" AND `{key.ToLower()}` BETWEEN {value} AND {dict[$"{key}_RANGE"]} ";
                        break;
                }
            }
            else if (value is bool boolean && value is not null)
            {
                if (boolean)
                {
                    sql = $@" AND `{key.ToLower()}` = TRUE ";
                } 
                else
                {
                    sql = $@" AND `{key.ToLower()}` = FALSE ";
                }
            }

            return sql;
        }

        public static readonly List<string> NumberOperator = new List<string>
        {
            "Select",
            "To",
            "<=",
            ">="
        };

        public static readonly List<string> DateOperator = new List<string>
        {
            "Select",
            "To"
        };
    }
}

