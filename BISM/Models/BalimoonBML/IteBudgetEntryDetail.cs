﻿using System;
using System.Collections.Generic;

namespace BISM.Models.BalimoonBML
{
    public partial class IteBudgetEntryDetail
    {
        public string Name { get; set; }
        public DateTime? Date { get; set; }
        public string ForeCastItemNo { get; set; }
        public decimal? ForeCastQty { get; set; }
        public string Description { get; set; }
        public string ProductionBomno { get; set; }
        public string RecordNo { get; set; }
        public string PartDescription { get; set; }
        public decimal QtyperUnitofMeasure { get; set; }
        public decimal? ScrapPercent { get; set; }
        public decimal? LotSize { get; set; }
        public decimal? UnitCost { get; set; }
        public string Uom { get; set; }
    }
}
