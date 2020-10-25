using System;
using System.Collections.Generic;

namespace BISM.Models.BalimoonBML
{
    public partial class StoreLocation
    {
        public int StoreLocationId { get; set; }
        public string StoreNo { get; set; }
        public string LocationCode { get; set; }
        public byte SalesLocation { get; set; }
        public byte SpecialOrderLocation { get; set; }
        public byte LayawayLocation { get; set; }
        public byte ClaimLocation { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
