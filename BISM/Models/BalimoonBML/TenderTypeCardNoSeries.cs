using System;
using System.Collections.Generic;

namespace BISM.Models.BalimoonBML
{
    public partial class TenderTypeCardNoSeries
    {
        public int TenderTypeCardNoSeriesId { get; set; }
        public string StoreNo { get; set; }
        public string TenderTypeCode { get; set; }
        public string CardNo { get; set; }
        public int LineNo { get; set; }
        public string Description { get; set; }
        public byte ValidonPos { get; set; }
        public string CardSeriesFrom { get; set; }
        public string CardSeriesTo { get; set; }
        public byte Combinationcard { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
