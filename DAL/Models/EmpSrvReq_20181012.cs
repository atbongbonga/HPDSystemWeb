//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmpSrvReq_20181012
    {
        public int DocEntry { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public string EmpCode { get; set; }
        public string ItemCode { get; set; }
        public decimal ItemPrice { get; set; }
        public Nullable<int> Qty { get; set; }
        public Nullable<int> SQty { get; set; }
        public Nullable<decimal> SEE { get; set; }
        public Nullable<decimal> SAmt { get; set; }
        public Nullable<decimal> TotalAmt { get; set; }
        public Nullable<decimal> QtyIssue { get; set; }
        public string Remarks { get; set; }
        public string ReqType { get; set; }
        public string Size { get; set; }
        public string Stat { get; set; }
        public Nullable<int> BaseEntry { get; set; }
        public string CutOff { get; set; }
        public string Destination { get; set; }
        public Nullable<int> SDForm { get; set; }
    }
}
