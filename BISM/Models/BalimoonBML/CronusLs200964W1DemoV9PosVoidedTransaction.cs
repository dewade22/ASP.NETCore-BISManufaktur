using System;
using System.Collections.Generic;

namespace BISM.Models.BalimoonBML
{
    public partial class CronusLs200964W1DemoV9PosVoidedTransaction
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
        public DateTime TransTime { get; set; }
        public string ShiftNo { get; set; }
        public DateTime ShiftDate { get; set; }
        public string InfocodeDiscGroup { get; set; }
        public string CustomerNo { get; set; }
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
        public decimal Counter { get; set; }
        public DateTime TimeWhenTotalPressed { get; set; }
        public DateTime TimeWhenTransClosed { get; set; }
        public string CustIdNumber { get; set; }
        public string TransCurrencyCode { get; set; }
        public decimal CurrencyFactor { get; set; }
        public byte PostAsShipment { get; set; }
        public byte[] Picture { get; set; }
        public int ManagerKey { get; set; }
        public string ManagerId { get; set; }
        public string RetrievedFromReceiptNo { get; set; }
        public int TableNo { get; set; }
        public int NoOfCovers { get; set; }
        public decimal ServiceCharge { get; set; }
        public string InUseOnTill { get; set; }
        public string CreatedByStaffId { get; set; }
        public int ActiveTableNo { get; set; }
        public string TableGroup { get; set; }
        public string SalesType { get; set; }
        public byte Replicated { get; set; }
        public int ReplicationCounter { get; set; }
    }
}
