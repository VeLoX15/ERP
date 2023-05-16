namespace ERP.Core.Filters
{
    public class ConditionFilter
    {
        public string NumberFilterToSql(int value, string )
        {
            string sql;

            switch (value)
            {
                case 0:
                    sql = "";
                    break;
                case 1:
                    sql = "";
                    break;
                case 2:
                    sql = "";
                    break;
                case 3:
                    sql = "";
                    break;
                case 4:
                    sql = "";
                    break;
                case 5:
                    sql = "";
                    break;
                default:
                    sql = "";
                    break;
            }

            return sql;
        }
    }
}


public static readonly List<string> NumberCondition = new List<string>
        {
            "",
            "To",
            "<",
            ">",
            "<=",
            ">=",
        };

public static readonly List<string> DateCondition = new List<string>
        {
            "",
            "To"
        };