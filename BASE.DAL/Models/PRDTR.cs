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
    
    public partial class PRDTR
    {
        public string DocEntry { get; set; }
        public string EmpCode { get; set; }
        public string EmpName { get; set; }
        public string BranchName { get; set; }
        public string DeptName { get; set; }
        public string EmpComName { get; set; }
        public System.DateTime DocDate { get; set; }
        public string STimeIn { get; set; }
        public Nullable<System.DateTime> TimeIn { get; set; }
        public string STimeOut { get; set; }
        public Nullable<System.DateTime> TimeOut { get; set; }
        public string SBreakIn { get; set; }
        public Nullable<System.DateTime> BreakIn { get; set; }
        public string SBreakOut { get; set; }
        public Nullable<System.DateTime> BreakOut { get; set; }
        public string SBreakIn1 { get; set; }
        public Nullable<System.DateTime> BreakIn1 { get; set; }
        public string SBreakOut1 { get; set; }
        public Nullable<System.DateTime> BreakOut1 { get; set; }
        public string SLunchOut { get; set; }
        public Nullable<System.DateTime> LunchOut { get; set; }
        public string SLunchIn { get; set; }
        public Nullable<System.DateTime> LunchIn { get; set; }
        public Nullable<System.DateTime> STime { get; set; }
        public Nullable<System.DateTime> ETime { get; set; }
        public string Stat { get; set; }
        public string Leg { get; set; }
        public Nullable<int> IsBreak { get; set; }
        public Nullable<int> SDuty { get; set; }
        public string Holiday { get; set; }
        public Nullable<decimal> TDays { get; set; }
        public Nullable<decimal> THrs { get; set; }
        public Nullable<int> SCAbsent { get; set; }
        public Nullable<int> SCLate { get; set; }
        public Nullable<int> SCUndertime { get; set; }
        public Nullable<int> SCLunch { get; set; }
        public Nullable<decimal> DPres { get; set; }
        public Nullable<decimal> DPresHrs { get; set; }
        public Nullable<decimal> DAbs { get; set; }
        public Nullable<decimal> DAbsHrs { get; set; }
        public Nullable<decimal> DLate { get; set; }
        public Nullable<decimal> DLateMin { get; set; }
        public Nullable<decimal> DLunch { get; set; }
        public Nullable<decimal> DLunchMin { get; set; }
        public Nullable<decimal> DUt { get; set; }
        public Nullable<decimal> DUtMin { get; set; }
        public Nullable<decimal> OTTO { get; set; }
        public Nullable<decimal> OTTI { get; set; }
        public Nullable<decimal> ND { get; set; }
        public Nullable<decimal> NDOT { get; set; }
        public Nullable<decimal> RDOT { get; set; }
        public Nullable<decimal> TotOT { get; set; }
        public Nullable<System.DateTime> OTApp { get; set; }
        public Nullable<decimal> DOA { get; set; }
        public Nullable<decimal> DCOLA { get; set; }
    }
}
