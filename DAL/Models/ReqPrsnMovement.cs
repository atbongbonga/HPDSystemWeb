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
    
    public partial class ReqPrsnMovement
    {
        public int DocEntry { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public string EmpCode { get; set; }
        public string ReqType { get; set; }
        public string PrevValue { get; set; }
        public string NewValue { get; set; }
        public Nullable<System.DateTime> EffDate { get; set; }
        public string Reason { get; set; }
        public string ReqStat { get; set; }
        public string ReqBy { get; set; }
        public string MgmtStat { get; set; }
        public Nullable<System.DateTime> MgmtStatDate { get; set; }
        public string MgmtEmpCode { get; set; }
        public string MgmtRmrks { get; set; }
        public string HrStat { get; set; }
        public Nullable<System.DateTime> HrStatDate { get; set; }
        public string HrEmpCode { get; set; }
        public string HrRmrks { get; set; }
    }
}
