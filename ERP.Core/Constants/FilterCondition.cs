namespace ERP.Core.Constants
{
    public static class FilterCondition
    {
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
    }
}