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
    
    public partial class HS_SCList
    {
        public Nullable<int> DocEntry { get; set; }
        public string Code { get; set; }
        public System.DateTime DocDate { get; set; }
        public Nullable<System.TimeSpan> STime { get; set; }
        public Nullable<System.TimeSpan> ETime { get; set; }
        public string Leg { get; set; }
        public Nullable<decimal> TTime { get; set; }
        public string Stat { get; set; }
        public string Remarks { get; set; }
        public string WhsCode { get; set; }
        public string IsBreak { get; set; }
        public Nullable<int> sduty { get; set; }
        public string PostedBy { get; set; }
        public string Hol { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string Period { get; set; }
        public Nullable<int> MinTI { get; set; }
        public Nullable<int> MaxTI { get; set; }
    }
}
