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

            if (value is int || value is decimal)
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
            else if (value is string stringValue && !string.IsNullOrWhiteSpace(stringValue))
            {
                sql = $@"AND UPPER(`{key.ToLower()}`) LIKE '%{stringValue.ToUpper()}%' ";
            }
            else if (value is DateTime dateTime)
            {
                switch (dict[$"{key}_OPERATOR"])
                {
                    case 0:
                        sql = $@" AND `{key.ToLower()}` = '{dateTime:yyyy-MM-dd HH:mm:ss}' ";
                        break;
                    case 1:
                        if (DateTime.TryParse(dict[$"{key}_RANGE"]?.ToString(), out var dateTimeRange))
                        {
                            sql = $@" AND `{key.ToLower()}` BETWEEN '{dateTime:yyyy-MM-dd HH:mm:ss}' AND '{dateTimeRange:yyyy-MM-dd HH:mm:ss}' ";
                        }
                        break;
                }
            }
            else if (value is bool boolean)
            {
                sql = $@" AND `{key.ToLower()}` = {(boolean ? "TRUE" : "FALSE")} ";
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

