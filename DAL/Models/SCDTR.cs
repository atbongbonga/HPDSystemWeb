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
    
    public partial class SCDTR
    {
        public string EmpName { get; set; }
        public string IDNo { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public string DocDay { get; set; }
        public Nullable<System.DateTime> TimeIn { get; set; }
        public Nullable<System.DateTime> BreakOut { get; set; }
        public Nullable<System.DateTime> BreakIn { get; set; }
        public Nullable<System.DateTime> LunchOut { get; set; }
        public Nullable<System.DateTime> LunchIn { get; set; }
        public Nullable<System.DateTime> BreakOut1 { get; set; }
        public Nullable<System.DateTime> BreakIn1 { get; set; }
        public Nullable<System.DateTime> TimeOut { get; set; }
        public Nullable<int> TotalTime { get; set; }
        public Nullable<int> TotalBreak { get; set; }
        public string FileName { get; set; }
        public int DocEntry { get; set; }
        public int LineNum { get; set; }
        public string WhsCode { get; set; }
        public string SheetName { get; set; }
        public string EmpCode { get; set; }
    }
}