using System;
using System.Collections.Generic;

namespace BISM.Models.BalimoonBML
{
    public partial class TenderTypeCardSetup
    {
        public int TenderTypeCardSetupId { get; set; }
        public string StoreNo { get; set; }
        public string TenderTypeCode { get; set; }
        public string CardNo { get; set; }
        public string Description { get; set; }
        public int AccountType { get; set; }
        public string AccountNo { get; set; }
        public string AccountName { get; set; }
        public string DifferenceGlacc { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyonTotalsCode { get; set; }
        public byte CountingRequired { get; set; }
        public byte ChangeAllowed { get; set; }
        public byte ManualAuthorization { get; set; }
        public byte CardNumberSwiped { get; set; }
        public byte SameCardAllowed { get; set; }
        public byte MarkingOnly { get; set; }
        public decimal ChargePercent { get; set; }
        public string ChargetoAccountNo { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
