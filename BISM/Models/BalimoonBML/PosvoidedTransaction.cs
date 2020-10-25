using System;
using System.Collections.Generic;

namespace BISM.Models.BalimoonBML
{
    public partial class PosvoidedTransaction
    {
        public int PosvoidedTransactionId { get; set; }
        public string ReceiptNo { get; set; }
        public byte? NewTransaction { get; set; }
        public int? TransactionType { get; set; }
        public string SalesStaff { get; set; }
        public string VatbusPostingGroup { get; set; }
        public string PriceGroupCode { get; set; }
        public string StoreNo { get; set; }
        public string PosterminalNo { get; set; }
        public string CreatedonPosterminal { get; set; }
        public string StaffId { get; set; }
        public byte? SupervisorRights { get; set; }
        public DateTime? TransDate { get; set; }
        public DateTime? TransTime { get; set; }
        public string ShiftNo { get; set; }
        public DateTime? ShiftDate { get; set; }
        public string InfocodeDiscGroup { get; set; }
        public string CustomerNo { get; set; }
        public decimal? TransSalePmtDiff { get; set; }
        public decimal? NoofItems { get; set; }
        public decimal? Rounded { get; set; }
        public int? EntryStatus { get; set; }
        public decimal? VatofDiscount { get; set; }
        public decimal? NoofItemLines { get; set; }
        public decimal? NoofIncomeExpLines { get; set; }
        public decimal? NoofPaymentLines { get; set; }
        public byte? NoSaleOpenDrawer { get; set; }
        public byte? SaleIsReturnSale { get; set; }
        public byte? ReceiptPrintedforReturn { get; set; }
        public decimal? Counter { get; set; }
        public DateTime? TimewhenTotalPressed { get; set; }
        public DateTime? TimewhenTransClosed { get; set; }
        public string CustIdnumber { get; set; }
        public string TransCurrencyCode { get; set; }
        public decimal? CurrencyFactor { get; set; }
        public byte? PostasShipment { get; set; }
        public string Picture { get; set; }
        public int? ManagerKey { get; set; }
        public string ManagerId { get; set; }
        public string RetrievedfromReceiptNo { get; set; }
        public int? TableNo { get; set; }
        public int? NoofCovers { get; set; }
        public decimal? ServiceCharge { get; set; }
        public string InUseonTill { get; set; }
        public int? ActiveTableNo { get; set; }
        public string TableGroup { get; set; }
        public string SalesType { get; set; }
        public byte? Replicated { get; set; }
        public int? ReplicationCounter { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
