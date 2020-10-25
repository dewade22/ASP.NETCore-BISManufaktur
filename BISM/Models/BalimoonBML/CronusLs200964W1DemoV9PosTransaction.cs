using System;
using System.Collections.Generic;

namespace BISM.Models.BalimoonBML
{
    public partial class CronusLs200964W1DemoV9PosTransaction
    {
        public byte[] Timestamp { get; set; }
        public string ReceiptNo { get; set; }
        public byte NewTransaction { get; set; }
        public int TransactionType { get; set; }
        public string SalesStaff { get; set; }
        public string VatBusPostingGroup { get; set; }
        public string PriceGroupCode { get; set; }
        public string StoreNo { get; set; }
        public string PosTerminalNo { get; set; }
        public string CreatedOnPosTerminal { get; set; }
        public string StaffId { get; set; }
        public byte SupervisorRights { get; set; }
        public DateTime TransDate { get; set; }
        public DateTime OriginalDate { get; set; }
        public DateTime TransTime { get; set; }
        public string ShiftNo { get; set; }
        public DateTime ShiftDate { get; set; }
        public string InfocodeDiscGroup { get; set; }
        public string CustomerNo { get; set; }
        public string CustomerDiscGroup { get; set; }
        public decimal TransSalePmtDiff { get; set; }
        public decimal NoOfItems { get; set; }
        public decimal Rounded { get; set; }
        public int EntryStatus { get; set; }
        public decimal VatOfDiscount { get; set; }
        public decimal NoOfItemLines { get; set; }
        public decimal NoOfIncomeExpLines { get; set; }
        public decimal NoOfPaymentLines { get; set; }
        public byte NoSaleOpenDrawer { get; set; }
        public byte SaleIsReturnSale { get; set; }
        public byte ReceiptPrintedForReturn { get; set; }
        public int PreReceiptCounter { get; set; }
        public byte VatByInfoCode { get; set; }
        public decimal Counter { get; set; }
        public DateTime TimeWhenTotalPressed { get; set; }
        public DateTime TimeWhenTransClosed { get; set; }
        public string CustIdNumber { get; set; }
        public string TransCurrencyCode { get; set; }
        public decimal CurrencyFactor { get; set; }
        public byte PostAsShipment { get; set; }
        public int ManagerKey { get; set; }
        public string ManagerId { get; set; }
        public string RetrievedFromReceiptNo { get; set; }
        public string RetrievedFromStoreNo { get; set; }
        public string RetrievedFromPosTermNo { get; set; }
        public int RetrievedFromTransNo { get; set; }
        public int TableNo { get; set; }
        public int NoOfCovers { get; set; }
        public decimal ServiceCharge { get; set; }
        public string CreatedByStaffId { get; set; }
        public int ActiveTableNo { get; set; }
        public string TableGroup { get; set; }
        public int MaxSeatingCapacity { get; set; }
        public string DocumentNo { get; set; }
        public string SellToContactNo { get; set; }
        public string GiftRegistrationNo { get; set; }
        public string MemberCardNo { get; set; }
        public string MemberPriceGroup { get; set; }
        public string SalesType { get; set; }
        public string Comment { get; set; }
        public int HospTypeSequence { get; set; }
        public string OriginalSalesType { get; set; }
        public decimal StartingPointBalance { get; set; }
        public int SplitNumber { get; set; }
        public decimal OrderLimit { get; set; }
        public int TenderDeclWarningCounter { get; set; }
        public byte StartFloatEntry { get; set; }
        public string SuspendSalesType { get; set; }
        public byte ContainsForecourtItems { get; set; }
        public string IndexField { get; set; }
        public string ApplyToDocNo { get; set; }
        public string OrderNo { get; set; }
    }
}
