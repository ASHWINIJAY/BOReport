//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POScreen.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class vw_FetchInvWarehouse
    {
        public string StockCode { get; set; }
        public string Warehouse { get; set; }
        public Nullable<decimal> QtyOnHand { get; set; }
        public Nullable<decimal> QtyAllocated { get; set; }
        public Nullable<decimal> QtyOnOrder { get; set; }
        public Nullable<decimal> QtyRemaining { get; set; }
    }
}