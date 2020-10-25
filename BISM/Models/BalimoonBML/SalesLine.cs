﻿using System;
using System.Collections.Generic;

namespace BISM.Models.BalimoonBML
{
    public partial class SalesLine
    {
        public int SalesLineId { get; set; }
        public int SalesHeaderId { get; set; }
        public int DocumentType { get; set; }
        public string DocumentNo { get; set; }
        public int SeqLineNo { get; set; }
        public string SelltoCustomerNo { get; set; }
        public int? RecordType { get; set; }
        public string RecordNo { get; set; }
        public string LocationCode { get; set; }
        public string PostingGroup { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public string UnitofMeasure { get; set; }
        public string SalesDiscountGroup { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? OutstandingQuantity { get; set; }
        public decimal? QtytoInvoice { get; set; }
        public decimal? QtytoShip { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? UnitCostLcy { get; set; }
        public decimal? Vatpercent { get; set; }
        public decimal? LineDiscountPercent { get; set; }
        public decimal? LineDiscountAmount { get; set; }
        public decimal? Amount { get; set; }
        public decimal? AmountIncludingVat { get; set; }
        public byte? AllowInvoiceDisc { get; set; }
        public decimal? GrossWeight { get; set; }
        public decimal? NetWeight { get; set; }
        public decimal? UnitsperParcel { get; set; }
        public decimal? UnitVolume { get; set; }
        public int? AppltoItemEntry { get; set; }
        public string ShortcutDimension1Code { get; set; }
        public string ShortcutDimension2Code { get; set; }
        public string CustomerPriceGroup { get; set; }
        public string JobNo { get; set; }
        public string WorkTypeCode { get; set; }
        public decimal? OutstandingAmount { get; set; }
        public decimal? QtyShippedNotInvoiced { get; set; }
        public decimal? ShippedNotInvoiced { get; set; }
        public decimal? QuantityShipped { get; set; }
        public decimal? QuantityInvoiced { get; set; }
        public string ShipmentNo { get; set; }
        public int? ShipmentLineNo { get; set; }
        public decimal? ProfitPercent { get; set; }
        public string BilltoCustomerNo { get; set; }
        public decimal? InvDiscountAmount { get; set; }
        public string PurchaseOrderNo { get; set; }
        public int? PurchOrderLineNo { get; set; }
        public byte? DropShipment { get; set; }
        public string GenBusPostingGroup { get; set; }
        public string GenProdPostingGroup { get; set; }
        public int? VatcalculationType { get; set; }
        public string TransactionType { get; set; }
        public string TransportMethod { get; set; }
        public int? AttachedtoLineNo { get; set; }
        public string ExitPoint { get; set; }
        public string Area { get; set; }
        public string TransactionSpecification { get; set; }
        public string TaxAreaCode { get; set; }
        public byte? TaxLiable { get; set; }
        public string TaxGroupCode { get; set; }
        public string VatbusPostingGroup { get; set; }
        public string VatprodPostingGroup { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? OutstandingAmountLcy { get; set; }
        public decimal? ShippedNotInvoicedLcy { get; set; }
        public int? Reserve { get; set; }
        public string BlanketOrderNo { get; set; }
        public int? BlanketOrderLineNo { get; set; }
        public decimal? VatbaseAmount { get; set; }
        public decimal? UnitCost { get; set; }
        public byte? SystemCreatedEntry { get; set; }
        public decimal? LineAmount { get; set; }
        public decimal? Vatdifference { get; set; }
        public decimal? InvDiscAmounttoInvoice { get; set; }
        public string Vatidentifier { get; set; }
        public int? IcpartnerRefType { get; set; }
        public string IcpartnerReference { get; set; }
        public decimal? PrepaymentPercent { get; set; }
        public decimal? PrepmtLineAmount { get; set; }
        public decimal? PrepmtAmtInv { get; set; }
        public decimal? PrepmtAmtInclVat { get; set; }
        public decimal? PrepaymentAmount { get; set; }
        public decimal? PrepmtVatbaseAmt { get; set; }
        public decimal? PrepaymentVatpercent { get; set; }
        public int? PrepmtVatcalcType { get; set; }
        public string PrepaymentVatidentifier { get; set; }
        public string PrepaymentTaxAreaCode { get; set; }
        public byte? PrepaymentTaxLiable { get; set; }
        public string PrepaymentTaxGroupCode { get; set; }
        public decimal? PrepmtAmttoDeduct { get; set; }
        public decimal? PrepmtAmtDeducted { get; set; }
        public byte? PrepaymentLine { get; set; }
        public decimal? PrepmtAmountInvInclVat { get; set; }
        public decimal? PrepmtAmountInvLcy { get; set; }
        public string IcpartnerCode { get; set; }
        public decimal? PrepaymentVatdifference { get; set; }
        public decimal? PrepmtVatdifftoDeduct { get; set; }
        public decimal? PrepmtVatdiffDeducted { get; set; }
        public string JobTaskNo { get; set; }
        public int? JobContractEntryNo { get; set; }
        public string VariantCode { get; set; }
        public string BinCode { get; set; }
        public decimal? QtyperUnitofMeasure { get; set; }
        public byte? Planned { get; set; }
        public string UnitofMeasureCode { get; set; }
        public decimal? QuantityBase { get; set; }
        public decimal? OutstandingQtyBase { get; set; }
        public decimal? QtytoInvoiceBase { get; set; }
        public decimal? QtytoShipBase { get; set; }
        public decimal? QtyShippedNotInvdBase { get; set; }
        public decimal? QtyShippedBase { get; set; }
        public decimal? QtyInvoicedBase { get; set; }
        public DateTime? FapostingDate { get; set; }
        public string DepreciationBookCode { get; set; }
        public byte? DepruntilFapostingDate { get; set; }
        public string DuplicateinDepreciationBook { get; set; }
        public byte? UseDuplicationList { get; set; }
        public string ResponsibilityCenter { get; set; }
        public byte? OutofStockSubstitution { get; set; }
        public string OriginallyOrderedNo { get; set; }
        public string OriginallyOrderedVarCode { get; set; }
        public string CrossReferenceNo { get; set; }
        public string UnitofMeasureCrossRef { get; set; }
        public int? CrossReferenceType { get; set; }
        public string CrossReferenceTypeNo { get; set; }
        public string ItemCategoryCode { get; set; }
        public byte? Nonstock { get; set; }
        public string PurchasingCode { get; set; }
        public string ProductGroupCode { get; set; }
        public byte? SpecialOrder { get; set; }
        public string SpecialOrderPurchaseNo { get; set; }
        public int? SpecialOrderPurchLineNo { get; set; }
        public byte? CompletelyShipped { get; set; }
        public DateTime? RequestedDeliveryDate { get; set; }
        public DateTime? PromisedDeliveryDate { get; set; }
        public string ShippingTime { get; set; }
        public string OutboundWhseHandlingTime { get; set; }
        public DateTime? PlannedDeliveryDate { get; set; }
        public DateTime? PlannedShipmentDate { get; set; }
        public string ShippingAgentCode { get; set; }
        public string ShippingAgentServiceCode { get; set; }
        public byte? AllowItemChargeAssignment { get; set; }
        public decimal? ReturnQtytoReceive { get; set; }
        public decimal? ReturnQtytoReceiveBase { get; set; }
        public decimal? ReturnQtyRcdNotInvd { get; set; }
        public decimal? RetQtyRcdNotInvdBase { get; set; }
        public decimal? ReturnRcdNotInvd { get; set; }
        public decimal? ReturnRcdNotInvdLcy { get; set; }
        public decimal? ReturnQtyReceived { get; set; }
        public decimal? ReturnQtyReceivedBase { get; set; }
        public int? ApplfromItemEntry { get; set; }
        public string ReturnReceiptNo { get; set; }
        public int? ReturnReceiptLineNo { get; set; }
        public string ReturnReasonCode { get; set; }
        public byte? AllowLineDisc { get; set; }
        public string CustomerDiscGroup { get; set; }
        public byte? KitItem { get; set; }
        public byte? BuildKit { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
        public string CukaiCode { get; set; }
        public decimal? CukaiCost { get; set; }
        public int? AppliestoDocType { get; set; }
        public string AppliestoDocNo { get; set; }
    }
}
