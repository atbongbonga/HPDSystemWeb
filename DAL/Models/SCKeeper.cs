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
    
    public partial class SCKeeper
    {
        public string EmpCode { get; set; }
        public System.DateTime DocDate { get; set; }
        public string WhsCode { get; set; }
        public Nullable<int> DocEntry { get; set; }
        public Nullable<System.DateTime> TimeIn { get; set; }
        public Nullable<System.DateTime> TimeOut { get; set; }
        public Nullable<System.DateTime> BreakIn { get; set; }
        public Nullable<System.DateTime> BreakOut { get; set; }
        public Nullable<System.DateTime> BreakIn1 { get; set; }
        public Nullable<System.DateTime> BreakOut1 { get; set; }
        public Nullable<System.DateTime> LunchOut { get; set; }
        public Nullable<System.DateTime> LunchIn { get; set; }
        public Nullable<System.DateTime> STime { get; set; }
        public Nullable<System.DateTime> ETime { get; set; }
        public string Stat { get; set; }
        public Nullable<int> TDays { get; set; }
        public Nullable<decimal> THrs { get; set; }
        public Nullable<int> SCAbsent { get; set; }
        public Nullable<int> SCLate { get; set; }
        public Nullable<int> SCUndertime { get; set; }
        public Nullable<int> SCLunch { get; set; }
        public string Leg { get; set; }
        public string Holiday { get; set; }
        public Nullable<decimal> DPres { get; set; }
        public Nullable<decimal> DLate { get; set; }
        public Nullable<System.TimeSpan> DLateMin { get; set; }
        public Nullable<decimal> DAbs { get; set; }
        public Nullable<decimal> DUt { get; set; }
        public Nullable<System.TimeSpan> DUtMin { get; set; }
        public Nullable<decimal> OTTO { get; set; }
        public string OTTAG { get; set; }
        public Nullable<decimal> DCola { get; set; }
        public Nullable<decimal> DOA { get; set; }
        public string Type { get; set; }
        public Nullable<decimal> RDOT { get; set; }
        public Nullable<decimal> NDOT { get; set; }
        public Nullable<decimal> OTTI { get; set; }
        public Nullable<System.DateTime> DateApproved { get; set; }
        public string Remarks { get; set; }
        public string DocDay { get; set; }
        public Nullable<decimal> totOT { get; set; }
        public Nullable<decimal> HOT { get; set; }
        public Nullable<decimal> DLunch { get; set; }
        public Nullable<System.TimeSpan> DPresHrs { get; set; }
        public Nullable<System.TimeSpan> DLunchMin { get; set; }
        public Nullable<System.TimeSpan> DAbsHrs { get; set; }
        public string EmpName { get; set; }
        public string Active { get; set; }
        public Nullable<decimal> DUtMin1 { get; set; }
    }
}
