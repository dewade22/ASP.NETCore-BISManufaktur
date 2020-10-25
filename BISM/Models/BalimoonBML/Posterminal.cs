using System;
using System.Collections.Generic;

namespace BISM.Models.BalimoonBML
{
    public partial class Posterminal
    {
        public int PosterminalId { get; set; }
        public string No { get; set; }
        public string StoreNo { get; set; }
        public string Description { get; set; }
        public string Placement { get; set; }
        public int StatementMethod { get; set; }
        public byte TerminalStatement { get; set; }
        public string DefaultPriceGroup { get; set; }
        public byte NotActive { get; set; }
        public int ClosingStatus { get; set; }
        public string TerminalNetworkId { get; set; }
        public string TerminalIpaddress { get; set; }
        public int TerminalConnection { get; set; }
        public byte DisplayTerminalClosed { get; set; }
        public byte DisplayLinkedItem { get; set; }
        public decimal FraudSortField { get; set; }
        public byte ManagerKeyonReturn { get; set; }
        public int SlipifReturn { get; set; }
        public byte OpenDraweratLilo { get; set; }
        public byte OnlyTotalinSuspTrans { get; set; }
        public byte ExitAfterEachTrans { get; set; }
        public int AutoLogoffAfterMin { get; set; }
        public byte ReturninTransaction { get; set; }
        public int ItemNoonReceipt { get; set; }
        public byte PrintReceiptforNegAdj { get; set; }
        public string EftstoreNo { get; set; }
        public string EftposterminalNo { get; set; }
        public int RcptTextMaxLength { get; set; }
        public int NoofTopBottomLines { get; set; }
        public byte ReceiptBarcode { get; set; }
        public int ReceiptSetupLocation { get; set; }
        public int DisplayTextMaxLength { get; set; }
        public string CustomerDisplayText1 { get; set; }
        public string CustomerDisplayText2 { get; set; }
        public int PrintReceiptType { get; set; }
        public int ReceiptBarcodeWidth { get; set; }
        public int ReceiptBarcodeHeight { get; set; }
        public byte OnlineTransBackup { get; set; }
        public string BackupDatabase { get; set; }
        public long SumofTransNo { get; set; }
        public int CountofTrans { get; set; }
        public string NoSeries { get; set; }
        public string TableGroup { get; set; }
        public byte TableViewatLogon { get; set; }
        public int OperationalMode { get; set; }
        public byte RecPrintingOffbyDefault { get; set; }
        public string DefaultSalesType { get; set; }
        public string LastZreport { get; set; }
        public string HardwareProfile { get; set; }
        public string MenuProfile { get; set; }
        public string InterfaceProfile { get; set; }
        public string FunctionalityProfile { get; set; }
        public byte PrintVatrefundChecks { get; set; }
        public byte PrintSuspendwithPrepayment { get; set; }
        public byte PrintNumberofItems { get; set; }
        public byte PrintTotalSavings { get; set; }
        public string SecondHardwareProfile { get; set; }
        public byte PrintSecondReceipt { get; set; }
        public string SalesTypeFilter { get; set; }
        public string CopyofMenuProfile { get; set; }
        public string CopyofInterfaceProfile { get; set; }
        public string InventoryMainMenu { get; set; }
        public int InventoryNoofRecords { get; set; }
        public string ForecourtTerminalId { get; set; }
        public string SalesOrderNos { get; set; }
        public int ItemFilteringMethod { get; set; }
        public int VendorFilteringMethod { get; set; }
        public int CustomerFilteringMethod { get; set; }
        public byte ShowNumberpad { get; set; }
        public int InventoryDeviceType { get; set; }
        public string DeviceUniqueId { get; set; }
        public string DeviceLicenseKey { get; set; }
        public string WarrantyHotelTerminalGuid { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
