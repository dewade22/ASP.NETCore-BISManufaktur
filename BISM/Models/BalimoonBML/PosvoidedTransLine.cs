using System;
using System.Collections.Generic;

namespace BISM.Models.BalimoonBML
{
    public partial class PosvoidedTransLine
    {
        public int PosvoidedTransLineId { get; set; }
        public string ReceiptNo { get; set; }
        public int SeqLineNo { get; set; }
        public int? EntryType { get; set; }
        public string BarcodeNo { get; set; }
        public string Number { get; set; }
        public int? EntryStatus { get; set; }
        public string CurrencyCode { get; set; }
        public string VariantCode { get; set; }
        public string Description { get; set; }
        public string UnitofMeasure { get; set; }
        public string StoreNo { get; set; }
        public string PosterminalNo { get; set; }
        public string SalesStaff { get; set; }
        public decimal? Price { get; set; }
        public decimal? NetPrice { get; set; }
        public decimal? Quantity { get; set; }
        public string PriceGroupCode { get; set; }
        public string Vatcode { get; set; }
        public decimal? Vatpercent { get; set; }
        public decimal? DiscountPercent { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? CostAmount { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal? NetAmount { get; set; }
        public decimal? Vatamount { get; set; }
        public decimal? Amount { get; set; }
        public decimal? AmountInCurrency { get; set; }
        public string CardType { get; set; }
        public string CardCustomerCoupItemNo { get; set; }
        public string VatBusPostingGroup { get; set; }
        public string VatProdPostingGroup { get; set; }
        public string ItemDiscGroup { get; set; }
        public byte? NoDiscountAllowed { get; set; }
        public int? CardEntryNo { get; set; }
        public string CouponEanorg { get; set; }
        public byte? ItemNumberScanned { get; set; }
        public byte? PriceinBarcode { get; set; }
        public byte? PriceChange { get; set; }
        public byte? WeightmanuallyEntered { get; set; }
        public byte? ScaleItem { get; set; }
        public byte? QuantityinBarcode { get; set; }
        public int? DispensePrinting { get; set; }
        public byte? LinkedNonotOrig { get; set; }
        public byte? OrigofaLinkedItemList { get; set; }
        public byte? PriceOverride { get; set; }
        public byte? ItemDeptNegative { get; set; }
        public byte? CountasOne { get; set; }
        public string ItemPostingGroup { get; set; }
        public decimal? TotalRoundedAmt { get; set; }
        public decimal? OrgPriceIncVat { get; set; }
        public decimal? OrgPriceExcVat { get; set; }
        public string PictureFileName { get; set; }
        public int? DiscInfoSeqLineNo { get; set; }
        public byte? DiscountTriggered { get; set; }
        public decimal? QuantityDiscounted { get; set; }
        public int? PeriodicDiscType { get; set; }
        public string PeriodicDiscGroup { get; set; }
        public byte? InfoCodeDiscDisable { get; set; }
        public decimal? InfoCodeDiscPercent { get; set; }
        public decimal? PeriodicDiscPercent { get; set; }
        public string PromotionNo { get; set; }
        public int? MixnMatchSeqLineNo { get; set; }
        public decimal? LineDiscPercent { get; set; }
        public decimal? TotalDiscPercent { get; set; }
        public int? TotDiscInfoSeqLineNo { get; set; }
        public decimal? TotalDiscAmount { get; set; }
        public decimal? CustomerPrice { get; set; }
        public decimal? CustomerDiscPercent { get; set; }
        public decimal? CustomerQtyUsed { get; set; }
        public int? ParentLine { get; set; }
        public int? RoundNo { get; set; }
        public int? CoverNo { get; set; }
        public byte? Marked { get; set; }
        public byte? Replicated { get; set; }
        public int? ReplicationCounter { get; set; }
        public decimal? DiscountAmtForPrinting { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
