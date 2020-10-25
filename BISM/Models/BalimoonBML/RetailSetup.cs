﻿using System;
using System.Collections.Generic;

namespace BISM.Models.BalimoonBML
{
    public partial class RetailSetup
    {
        public int RetailSetupId { get; set; }
        public string LocalStoreNo { get; set; }
        public byte AllVisioninUse { get; set; }
        public string EanlicenseNo { get; set; }
        public string DefVatbusPostGrPrice { get; set; }
        public byte DefPriceIncludesVat { get; set; }
        public string SourceCode { get; set; }
        public string ErrorLog { get; set; }
        public byte StopOnError { get; set; }
        public string StoreNoNos { get; set; }
        public int ItemSalesStatisticson { get; set; }
        public byte PosterminalStatistics { get; set; }
        public byte StaffStatistics { get; set; }
        public byte PaymentStatistics { get; set; }
        public int DaysBeforeTransArchive { get; set; }
        public byte CommissionActive { get; set; }
        public byte CalculateinStatemPosting { get; set; }
        public byte CalculateinSalesPosting { get; set; }
        public byte ExcludeReturns { get; set; }
        public int BalAccType { get; set; }
        public string BalAccNo { get; set; }
        public byte Dimension1Mandatory { get; set; }
        public byte OnlyTwoDimensions { get; set; }
        public string DefaultPriceGroup { get; set; }
        public byte PostTotalDisc { get; set; }
        public byte PostInfocodeDisc { get; set; }
        public byte PostLineDisc { get; set; }
        public byte PostPeriodicDisc { get; set; }
        public byte PostCustDisc { get; set; }
        public byte PostCouponDisc { get; set; }
        public byte PostLineDiscOffer { get; set; }
        public byte PostTotalDiscOffer { get; set; }
        public byte PostTenderTypeDisc { get; set; }
        public int ItemPostingDate { get; set; }
        public int DefaultCustomerPosting { get; set; }
        public byte UpdateCostAmount { get; set; }
        public byte ItemLabelsforNegStock { get; set; }
        public byte ItemLabelsonPriceChange { get; set; }
        public byte PostAlwaysReserveItems { get; set; }
        public byte DeletePrintedLabels { get; set; }
        public int PoitemLookupMethod { get; set; }
        public decimal DifferenceLcy { get; set; }
        public decimal DifferencePercent { get; set; }
        public byte SaleCompareActive { get; set; }
        public string SaleCompareDateValue { get; set; }
        public int AutocreateBarcodes { get; set; }
        public string CreateItemsNoSeries { get; set; }
        public byte Pos3rdParty { get; set; }
        public string DefaultItemHierarchy { get; set; }
        public string DistributionLocation { get; set; }
        public string DefStoreHierarchy { get; set; }
        public int IniFileSectionIdentifier { get; set; }
        public string IniFilePath { get; set; }
        public int BarcodeLookupinSalesLine { get; set; }
        public string DefaultSubgroupName { get; set; }
        public byte AllowRename { get; set; }
        public string DefaultLogoFileName { get; set; }
        public byte SystemInDemomode { get; set; }
        public int PreactionCreationby { get; set; }
        public string MessageNoSeries { get; set; }
        public string ItemAttrib1Code { get; set; }
        public string ItemAttrib2Code { get; set; }
        public string ItemAttrib3Code { get; set; }
        public string ItemAttrib4Code { get; set; }
        public string ItemAttrib5Code { get; set; }
        public int PoversionNoMarkings { get; set; }
        public byte RegisterCardInformation { get; set; }
        public int LineDiscManualSequence { get; set; }
        public int LineDiscManualFunction { get; set; }
        public int TotalDiscManualSequence { get; set; }
        public int TotalDiscManualFunction { get; set; }
        public int InfocodeDiscountSequence { get; set; }
        public int InfocodeDiscountFunction { get; set; }
        public int CouponDiscountSequence { get; set; }
        public int CouponDiscountFunction { get; set; }
        public int ItemPointOfferSequence { get; set; }
        public int ItemPointOfferFunction { get; set; }
        public int TotalDiscountOfferSequence { get; set; }
        public int TotalDiscountOfferFunction { get; set; }
        public int TenderTypeDiscountSequence { get; set; }
        public int TenderTypeDiscountFunction { get; set; }
        public int MemberPointPaymentSequence { get; set; }
        public int MemberPointPaymentFunction { get; set; }
        public byte AutomStatisticsUpdate { get; set; }
        public byte UpdateStorePriceInfo { get; set; }
        public byte IncludeSpecialGroups { get; set; }
        public DateTime AbclastRunSalesFrom { get; set; }
        public DateTime AbclastRunSalesTo { get; set; }
        public string AbcdateFormula { get; set; }
        public int AbcsalesA { get; set; }
        public int AbcsalesB { get; set; }
        public int AbcsalesC { get; set; }
        public int AbcprofitA { get; set; }
        public int AbcprofitB { get; set; }
        public int AbcprofitC { get; set; }
        public DateTime AbclastRunProfitFrom { get; set; }
        public DateTime AbclastRunProfitTo { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
        public string CampaignNos { get; set; }
        public string PromotionNos { get; set; }
        public string PeriodicDiscountNos { get; set; }
        public string CouponNos { get; set; }
        public string ItemNos { get; set; }
        public string TransactionNos { get; set; }
    }
}
