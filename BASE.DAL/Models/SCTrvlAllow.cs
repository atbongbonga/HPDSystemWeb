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
    
    public partial class SCTrvlAllow
    {
        public int DocEntry { get; set; }
        public Nullable<System.DateTime> ReqDate { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public string EmpCode { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string SupStat { get; set; }
        public string SupEmpCode { get; set; }
        public Nullable<System.DateTime> SupStatDate { get; set; }
        public string MgmtStat { get; set; }
        public string MgmtEmpCode { get; set; }
        public Nullable<System.DateTime> MgmtStatDate { get; set; }
        public string HRStat { get; set; }
        public string HREmpCode { get; set; }
        public Nullable<System.DateTime> HRStatDate { get; set; }
        public string ReqStat { get; set; }
        public string StatRemarks { get; set; }
        public string LnchBrk { get; set; }
        public Nullable<System.DateTime> BreakIn { get; set; }
        public Nullable<System.DateTime> BreakOut { get; set; }
        public Nullable<int> BrnchID { get; set; }
    }
}
