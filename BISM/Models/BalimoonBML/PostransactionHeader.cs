using System;
using System.Collections.Generic;

namespace BISM.Models.BalimoonBML
{
    public partial class PostransactionHeader
    {
        public int PostransactionHeaderId { get; set; }
        public string ReceiptNo { get; set; }
        public byte NewTransaction { get; set; }
        public int TransactionType { get; set; }
        public string SalesStaff { get; set; }
        public string VatbusPostingGroup { get; set; }
        public string PriceGroupCode { get; set; }
        public string StoreNo { get; set; }
        public string PosterminalNo { get; set; }
        public string CreatedonPosterminal { get; set; }
        public string StaffId { get; set; }
        public byte SupervisorRights { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime OriginalDate { get; set; }
        public DateTime TransTime { get; set; }
        public string ShiftNo { get; set; }
        public DateTime ShiftDate { get; set; }
        public string InfocodeDiscGroup { get; set; }
        public string CustomerNo { get; set; }
        public string CustomerDiscGroup { get; set; }
        public decimal TransactionSalePmtDiff { get; set; }
        public decimal NoofItems { get; set; }
        public decimal Rounded { get; set; }
        public int EntryStatus { get; set; }
        public decimal VatofDiscount { get; set; }
        public decimal NoofItemLines { get; set; }
        public decimal NoofIncomeExpLines { get; set; }
        public decimal NoofPaymentLines { get; set; }
        public byte NoSaleOpenDrawer { get; set; }
        public byte SaleIsReturnSale { get; set; }
        public byte ReceiptPrintedforReturn { get; set; }
        public int PreReceiptCounter { get; set; }
        public byte VatbyInfoCode { get; set; }
        public decimal Counter { get; set; }
        public DateTime TimewhenTotalPressed { get; set; }
        public DateTime TimewhenTransactionClosed { get; set; }
        public string CustIdnumber { get; set; }
        public string TransactionCurrencyCode { get; set; }
        public decimal CurrencyFactor { get; set; }
        public byte PostasShipment { get; set; }
        public int ManagerKey { get; set; }
        public string ManagerId { get; set; }
        public string RetrievedfromReceiptNo { get; set; }
        public string RetrievedfromStoreNo { get; set; }
        public string RetrievedfromPostermNo { get; set; }
        public int RetrievedfromTransactionNo { get; set; }
        public int TableNo { get; set; }
        public int NoofCovers { get; set; }
        public decimal ServiceCharge { get; set; }
        public string CreatedbyStaffId { get; set; }
        public int ActiveTableNo { get; set; }
        public string TableGroup { get; set; }
        public int MaxSeatingCapacity { get; set; }
        public string DocumentNo { get; set; }
        public string SelltoContactNo { get; set; }
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
        public string ApplytoDocNo { get; set; }
        public string OrderNo { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
