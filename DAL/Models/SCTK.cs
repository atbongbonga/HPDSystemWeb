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
    
    public partial class SCTK
    {
        public int DocEntry { get; set; }
        public string EmpCode { get; set; }
        public System.DateTime DocDate { get; set; }
        public Nullable<System.DateTime> TimeIn { get; set; }
        public Nullable<System.DateTime> LunchOut { get; set; }
        public Nullable<System.DateTime> LunchIn { get; set; }
        public Nullable<System.DateTime> TimeOut { get; set; }
        public string SupStat { get; set; }
        public string SupEmpCode { get; set; }
        public Nullable<System.DateTime> SupDate { get; set; }
        public Nullable<System.DateTime> ReqDate { get; set; }
        public string ReqStat { get; set; }
    }
}