﻿using System;
using System.Collections.Generic;

namespace BISM.Models.BalimoonBML
{
    public partial class PurchaseRequisitionLine
    {
        public int RequisitionLineId { get; set; }
        public int? RequisitionheaderId { get; set; }
        public string DocumentNo { get; set; }
        public int SeqLineNo { get; set; }
        public int? RecordType { get; set; }
        public string RecordNo { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public decimal? Quantity { get; set; }
        public string UnitofMeasure { get; set; }
        public string VendorNo { get; set; }
        public decimal? DirectUnitCost { get; set; }
        public string VatbusPostingGroup { get; set; }
        public string VatprodPostingGroup { get; set; }
        public string InventoryPostingGroup { get; set; }
        public DateTime? DueDate { get; set; }
        public string RequesterId { get; set; }
        public byte? Confirmed { get; set; }
        public string ShortcutDimension1Code { get; set; }
        public string ShortcutDimension2Code { get; set; }
        public string LocationCode { get; set; }
        public int? RecurringMethod { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string RecurringFrequency { get; set; }
        public DateTime? OrderDate { get; set; }
        public string VendorItemNo { get; set; }
        public string SalesOrderNo { get; set; }
        public int? SalesOrderLineNo { get; set; }
        public string SelltoCustomerNo { get; set; }
        public string ShiptoCode { get; set; }
        public string OrderAddressCode { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? CurrencyFactor { get; set; }
        public string ProdOrderNo { get; set; }
        public string VariantCode { get; set; }
        public string BinCode { get; set; }
        public decimal? QtyperUnitofMeasure { get; set; }
        public string UnitofMeasureCode { get; set; }
        public decimal? QuantityBase { get; set; }
        public int? DemandType { get; set; }
        public int? DemandSubtype { get; set; }
        public string DemandOrderNo { get; set; }
        public int? DemandLineNo { get; set; }
        public int? DemandRefNo { get; set; }
        public int? Status { get; set; }
        public DateTime? DemandDate { get; set; }
        public decimal? DemandQuantity { get; set; }
        public decimal? DemandQuantityBase { get; set; }
        public decimal? NeededQuantity { get; set; }
        public decimal? NeededQuantityBase { get; set; }
        public byte? Reserve { get; set; }
        public decimal? QtyperUomdemand { get; set; }
        public string UnitOfMeasureCodeDemand { get; set; }
        public string SupplyFrom { get; set; }
        public string OriginalItemNo { get; set; }
        public string OriginalVariantCode { get; set; }
        public int? Level { get; set; }
        public decimal? DemandQtyAvailable { get; set; }
        public string UserId { get; set; }
        public string ItemCategoryCode { get; set; }
        public byte? Nonstock { get; set; }
        public string PurchasingCode { get; set; }
        public string ProductGroupCode { get; set; }
        public string TransferfromCode { get; set; }
        public DateTime? TransferShipmentDate { get; set; }
        public decimal? LineDiscountPercent { get; set; }
        public int? OrderPromisingSubLineNo { get; set; }
        public string RoutingNo { get; set; }
        public string OperationNo { get; set; }
        public string WorkCenterNo { get; set; }
        public int? ProdOrderLineNo { get; set; }
        public byte? Mpsorder { get; set; }
        public int? PlanningFlexibility { get; set; }
        public int? RoutingReferenceNo { get; set; }
        public string GenProdPostingGroup { get; set; }
        public string GenBusinessPostingGroup { get; set; }
        public int? LowLevelCode { get; set; }
        public string ProductionBomversionCode { get; set; }
        public string RoutingVersionCode { get; set; }
        public int? RoutingType { get; set; }
        public decimal? OriginalQuantity { get; set; }
        public decimal? FinishedQuantity { get; set; }
        public decimal? RemainingQuantity { get; set; }
        public DateTime? OriginalDueDate { get; set; }
        public decimal? ScrapPercent { get; set; }
        public DateTime? StartingDate { get; set; }
        public DateTime? StartingTime { get; set; }
        public DateTime? EndingDate { get; set; }
        public DateTime? EndingTime { get; set; }
        public string ProductionBomno { get; set; }
        public decimal? IndirectCostPercent { get; set; }
        public decimal? OverheadRate { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? CostAmount { get; set; }
        public int? ReplenishmentSystem { get; set; }
        public string RefOrderNo { get; set; }
        public int? RefOrderType { get; set; }
        public int? RefOrderStatus { get; set; }
        public int? RefLineNo { get; set; }
        public string NoSeries { get; set; }
        public decimal? FinishedQtyBase { get; set; }
        public decimal? QuantityPo { get; set; }
        public decimal? RemainingQtyBase { get; set; }
        public int? RelatedtoPlanningLine { get; set; }
        public int? PlanningLevel { get; set; }
        public int? PlanningLineOrigin { get; set; }
        public int? ActionMessage { get; set; }
        public byte? AcceptActionMessage { get; set; }
        public decimal? NetQuantityBase { get; set; }
        public DateTime? StartingDateTime { get; set; }
        public DateTime? EndingDateTime { get; set; }
        public string OrderPromisingId { get; set; }
        public int? OrderPromisingLineNo { get; set; }
        public int? OrderPromisingLineId { get; set; }
        public int? Priority { get; set; }
        public string RequestNotes { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
        public string Picture { get; set; }
    }
}
