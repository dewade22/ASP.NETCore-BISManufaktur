using System;
using System.Collections.Generic;

namespace BISM.Models.BalimoonBML
{
    public partial class CronusLs200964W1DemoV9PosVoidedTransLine
    {
        public byte[] Timestamp { get; set; }
        public string ReceiptNo { get; set; }
        public int LineNo { get; set; }
        public int EntryType { get; set; }
        public string BarcodeNo { get; set; }
        public string Number { get; set; }
        public int EntryStatus { get; set; }
        public string CurrencyCode { get; set; }
        public string VariantCode { get; set; }
        public string Description { get; set; }
        public string UnitOfMeasure { get; set; }
        public string StoreNo { get; set; }
        public string PosTerminalNo { get; set; }
        public string SalesStaff { get; set; }
        public decimal Price { get; set; }
        public decimal NetPrice { get; set; }
        public decimal Quantity { get; set; }
        public string PriceGroupCode { get; set; }
        public string VatCode { get; set; }
        public decimal Vat { get; set; }
        public decimal Discount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal CostAmount { get; set; }
        public decimal CostPrice { get; set; }
        public decimal NetAmount { get; set; }
        public decimal VatAmount { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountInCurrency { get; set; }
        public string CardType { get; set; }
        public string CardCustomerCoupItemNo { get; set; }
        public string VatBusPostingGroup { get; set; }
        public string VatProdPostingGroup { get; set; }
        public string ItemDiscGroup { get; set; }
        public byte NoDiscountAllowed { get; set; }
        public int CardEntryNo { get; set; }
        public string CouponEanOrg { get; set; }
        public byte ItemNumberScanned { get; set; }
        public byte PriceInBarcode { get; set; }
        public byte PriceChange { get; set; }
        public byte WeightManuallyEntered { get; set; }
        public byte ScaleItem { get; set; }
        public byte QuantityInBarcode { get; set; }
        public int DispensePrinting { get; set; }
        public byte LinkedNoNotOrig { get; set; }
        public byte OrigOfALinkedItemList { get; set; }
        public byte PriceOverride { get; set; }
        public byte ItemDeptNegative { get; set; }
        public byte CountAsOne { get; set; }
        public string ItemPostingGroup { get; set; }
        public decimal TotalRoundedAmt { get; set; }
        public decimal OrgPriceIncVat { get; set; }
        public decimal OrgPriceExcVat { get; set; }
        public byte[] Picture { get; set; }
        public int DiscInfoLineNo { get; set; }
        public byte DiscountTriggered { get; set; }
        public decimal QuantityDiscounted { get; set; }
        public int PeriodicDiscType { get; set; }
        public string PeriodicDiscGroup { get; set; }
        public byte InfoCodeDiscDisable { get; set; }
        public decimal InfoCodeDisc { get; set; }
        public decimal PeriodicDisc { get; set; }
        public string PromotionNo { get; set; }
        public int MixMatchLineNo { get; set; }
        public decimal LineDisc { get; set; }
        public decimal TotalDisc { get; set; }
        public int TotDiscInfoLineNo { get; set; }
        public decimal TotalDiscAmount { get; set; }
        public decimal CustomerPrice { get; set; }
        public decimal CustomerDisc { get; set; }
        public decimal CustomerQtyUsed { get; set; }
        public int ParentLine { get; set; }
        public int RoundNo { get; set; }
        public int CoverNo { get; set; }
        public byte Marked { get; set; }
        public byte Replicated { get; set; }
        public int ReplicationCounter { get; set; }
        public decimal DiscountAmtForPrinting { get; set; }
    }
}
