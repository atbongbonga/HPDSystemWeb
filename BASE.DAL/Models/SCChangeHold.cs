//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BASE.DAL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SCChangeHold
    {
        public int TransID { get; set; }
        public int DocEntry { get; set; }
        public string WhsCode { get; set; }
        public Nullable<System.TimeSpan> STime { get; set; }
        public Nullable<System.TimeSpan> ETime { get; set; }
        public string Leg { get; set; }
        public Nullable<decimal> TTime { get; set; }
        public string Remarks { get; set; }
        public string stat { get; set; }
        public string OIC { get; set; }
        public System.DateTime DocDate { get; set; }
        public string Empcode { get; set; }
        public Nullable<System.DateTime> SchedDate { get; set; }
        public string LMode { get; set; }
        public string AppRemarks { get; set; }
        public Nullable<System.DateTime> StatDate { get; set; }
        public string IsBreak { get; set; }
        public Nullable<int> SDuty { get; set; }
        public string ReqBy { get; set; }
        public string StatBy { get; set; }
        public string Hold { get; set; }
        public Nullable<int> DocID { get; set; }
        public int LineNum { get; set; }
        public Nullable<int> MinTI { get; set; }
        public Nullable<int> MaxTI { get; set; }
    }
}
