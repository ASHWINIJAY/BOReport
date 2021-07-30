using System;

namespace POScreen.DAL.DTO
{
    public class POList
    {
        public int PurchaseOrderNo { get; set; }
        public string Supplier { get; set; }
        public string SupplierName { get; set; }
        public string Currency { get; set; }
        public DateTime MlastDueDate { get; set; }
        public DateTime MLastReceiptDate { get; set; }
        public string MCompletedFlag { get; set; }
        public string MStockCode { get; set; }
        public string MStockDescription { get; set; }
        public int OrderQty { get; set; }
        public int MReceivedQty { get; set; }
        public string ShipmentNumber { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public string SupplierCode { get; set; }
        public string MWarehouse { get; set; }
        public string ShipmentType { get; set; }
        public string ContainerNumber { get; set; }
        public string DeliveryLocation { get; set; }
        public string PurchaseOrder { get; set; }
        //public string Supplier { get; set; }
        //public string SupplierName { get; set; }
        //public string MStockCode { get; set; }
        public Nullable<decimal> MOrderQty { get; set; }
        // public decimal MReceivedQty { get; set; }
        public Nullable<System.DateTime> MLatestDueDate { get; set; }
        public Nullable<System.DateTime> MLastReceiptDat { get; set; }
        public string MCompleteFlag { get; set; }
       // public string Currency { get; set; }
        public string MStockDes { get; set; }
        public decimal Line { get; set; }
        public int PO { get; set; }
    }
  
}
