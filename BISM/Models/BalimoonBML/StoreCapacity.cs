using System;
using System.Collections.Generic;

namespace BISM.Models.BalimoonBML
{
    public partial class StoreCapacity
    {
        public int StoreCapacityId { get; set; }
        public string LocationCode { get; set; }
        public string ItemCategoryCode { get; set; }
        public string ProductGroupCode { get; set; }
        public string Season { get; set; }
        public decimal Goal { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
