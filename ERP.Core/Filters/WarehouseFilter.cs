﻿using ERP.Core.Filters.Abstract;

namespace ERP.Core.Filters
{
    public class WarehouseFilter : PageFilterBase
    {
        public string? Name { get; set; }
        public int? Number { get; set; }
    }
}
