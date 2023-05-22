using System.Collections;
using System.Collections.Generic;

namespace ERP.Core.Filters
{
    public class ConditionFilter
    {
        public static string FilterToSql(Dictionary<string, object?> dict, int i)
        {
            string sql = string.Empty;

            if (dict.Values.ElementAt(i) is int)
            {
                switch (dict[$"{dict.Keys.ElementAt(1)}_OPERATOR"])
                {
                    case 0:
                        sql = $@" AND `{dict.Keys.ElementAt(i).ToLower()}` = @{dict.Values.ElementAt(i)}";
                        break;
                    case 1:
                        sql = $@" AND WHERE `{dict.Keys.ElementAt(i).ToLower()}` BETWEEN {dict.Values.ElementAt(i)} AND {dict[$"{dict.Keys.ElementAt(1)}_RANGE"]}";
                        break;
                    case 2:
                        sql = $@" AND WHERE `{dict.Keys.ElementAt(i).ToLower()}` <= {dict.Values.ElementAt(i)}";
                        break;
                    case 3:
                        sql = $@" AND WHERE `{dict.Keys.ElementAt(i).ToLower()}` >= {dict.Values.ElementAt(i)}"; ;
                        break;
                }
            }
            else if (dict.Values.ElementAt(i) is string)
            {
                sql = $@" AND `{dict.Keys.ElementAt(i).ToLower()}` = @{dict.Values.ElementAt(i)}";
            }
            else if (dict.Values.ElementAt(i) is DateTime)
            {
                switch (dict[$"{dict.Keys.ElementAt(1)}_OPERATOR"])
                {
                    case 0:
                        sql = $@" AND `{dict.Keys.ElementAt(i).ToLower()}` = @{dict.Values.ElementAt(i)}";
                        break;
                    case 1:
                        sql = $@" AND WHERE `{dict.Keys.ElementAt(i).ToLower()}` BETWEEN {dict.Values.ElementAt(i)} AND {dict[$"{dict.Keys.ElementAt(1)}_RANGE"]}";
                        break;
                }
            }

            return sql;
        }

        public static readonly List<string> NumberCondition = new List<string>
        {
            "",
            "To",
            "<=",
            ">="
        };

        public static readonly List<string> DateCondition = new List<string>
        {
            "",
            "To"
        };
    }
}

