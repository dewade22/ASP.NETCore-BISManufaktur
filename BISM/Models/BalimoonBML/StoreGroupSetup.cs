using System;
using System.Collections.Generic;

namespace BISM.Models.BalimoonBML
{
    public partial class StoreGroupSetup
    {
        public int StoreGroupSetupId { get; set; }
        public string StoreCode { get; set; }
        public string StoreGroup { get; set; }
        public int Type { get; set; }
        public int LevelNo { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
