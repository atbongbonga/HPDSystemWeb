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
    
    public partial class PFRlvrPymt
    {
        public int DocEntry { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public string RlvrName { get; set; }
        public Nullable<int> BaseEntry { get; set; }
        public string WhsCode { get; set; }
        public Nullable<System.DateTime> RefDate { get; set; }
        public Nullable<int> WithBreak { get; set; }
        public Nullable<System.TimeSpan> STime { get; set; }
        public Nullable<System.TimeSpan> ETime { get; set; }
        public Nullable<System.TimeSpan> ActSTime { get; set; }
        public Nullable<System.TimeSpan> ActETime { get; set; }
        public Nullable<System.TimeSpan> TotHrs { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<decimal> GrossAmt { get; set; }
        public Nullable<int> EWTRate { get; set; }
        public Nullable<decimal> EWTAmt { get; set; }
        public Nullable<decimal> TotPay { get; set; }
        public string PostBy { get; set; }
        public string IPAdd { get; set; }
        public string FundFrom { get; set; }
        public Nullable<int> PCFEntry { get; set; }
        public Nullable<System.TimeSpan> TotBrk { get; set; }
        public string GenID { get; set; }
        public Nullable<System.DateTime> GenDate { get; set; }
        public string GenBy { get; set; }
        public string GenIP { get; set; }
        public Nullable<decimal> DiscrepAmt { get; set; }
        public Nullable<int> PFEntry { get; set; }
    }
}
