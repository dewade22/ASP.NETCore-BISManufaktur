﻿using System;
using System.Collections.Generic;

namespace BISM.Models.BalimoonBML
{
    public partial class PurchaseInvoiceHeader
    {
        public int PurchaseInvoiceHeaderId { get; set; }
        public string PurchaseInvoiceHeaderNo { get; set; }
        public int? DocStatus { get; set; }
        public string BuyfromVendorNo { get; set; }
        public string PaytoVendorNo { get; set; }
        public string PaytoName { get; set; }
        public string PaytoName2 { get; set; }
        public string PaytoAddress { get; set; }
        public string PaytoAddress2 { get; set; }
        public string PaytoCity { get; set; }
        public string PaytoContact { get; set; }
        public string YourReference { get; set; }
        public string ShiptoCode { get; set; }
        public string ShiptoName { get; set; }
        public string ShiptoName2 { get; set; }
        public string ShiptoAddress { get; set; }
        public string ShiptoAddress2 { get; set; }
        public string ShiptoCity { get; set; }
        public string ShiptoContact { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? PostingDate { get; set; }
        public DateTime? ExpectedReceiptDate { get; set; }
        public string PostingDescription { get; set; }
        public string PaymentTermsCode { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal? PaymentDiscountPercent { get; set; }
        public DateTime? PmtDiscountDate { get; set; }
        public string ShipmentMethodCode { get; set; }
        public string LocationCode { get; set; }
        public string ShortcutDimension1Code { get; set; }
        public string ShortcutDimension2Code { get; set; }
        public string VendorPostingGroup { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? CurrencyFactor { get; set; }
        public byte? PricesIncludingVat { get; set; }
        public string InvoiceDiscCode { get; set; }
        public string LanguageCode { get; set; }
        public string PurchaserCode { get; set; }
        public string OrderNo { get; set; }
        public string ReceiptNo { get; set; }
        public int? NoPrinted { get; set; }
        public string OnHold { get; set; }
        public int? AppliestoDocType { get; set; }
        public string AppliestoDocNo { get; set; }
        public string BalAccountNo { get; set; }
        public string VendorOrderNo { get; set; }
        public string VendorInvoiceNo { get; set; }
        public string VatregistrationNo { get; set; }
        public string SelltoCustomerNo { get; set; }
        public string ReasonCode { get; set; }
        public string GenBusPostingGroup { get; set; }
        public string TransactionType { get; set; }
        public string TransportMethod { get; set; }
        public string Vatcountry { get; set; }
        public string BuyfromVendorName { get; set; }
        public string BuyfromVendorName2 { get; set; }
        public string BuyfromAddress { get; set; }
        public string BuyfromAddress2 { get; set; }
        public string BuyfromCity { get; set; }
        public string BuyfromContact { get; set; }
        public string PaytoPostCode { get; set; }
        public string PaytoCountrye { get; set; }
        public string BuyfromPostCode { get; set; }
        public string BuyfromCountry { get; set; }
        public string BuyfromFaxNo { get; set; }
        public string BuyfromPhoneNo { get; set; }
        public string ShiptoPostCode { get; set; }
        public string ShiptoCountry { get; set; }
        public int? BalAccountType { get; set; }
        public string OrderAddressCode { get; set; }
        public string EntryPoint { get; set; }
        public byte? Correction { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string Area { get; set; }
        public string TransactionSpecification { get; set; }
        public string PaymentMethodCode { get; set; }
        public string PreAssignedNoSeries { get; set; }
        public string NoSeries { get; set; }
        public string OrderNoSeries { get; set; }
        public string PreAssignedNo { get; set; }
        public string UserId { get; set; }
        public string SourceCode { get; set; }
        public string TaxAreaCode { get; set; }
        public byte? TaxLiable { get; set; }
        public string VatbusPostingGroup { get; set; }
        public decimal? VatbaseDiscountPercent { get; set; }
        public string PrepaymentNoSeries { get; set; }
        public byte? PrepaymentInvoice { get; set; }
        public string PrepaymentOrderNo { get; set; }
        public string QuoteNo { get; set; }
        public string CampaignNo { get; set; }
        public string BuyfromContactNo { get; set; }
        public string PaytoContactNo { get; set; }
        public string ResponsibilityCenter { get; set; }
        public string StoreNo { get; set; }
        public string ItemRegistrationNo { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
        public decimal? Amount { get; set; }
        public decimal? AmountIncludingVat { get; set; }
    }
}
