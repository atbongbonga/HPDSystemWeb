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
    
    public partial class ALULTag
    {
        public string EmpCode { get; set; }
        public System.DateTime DocDate { get; set; }
        public string ALUL { get; set; }
        public Nullable<System.DateTime> DTRTime { get; set; }
        public string DTRType { get; set; }
        public string Remarks { get; set; }
        public string HR { get; set; }
        public string Declined { get; set; }
        public string DecRemarks { get; set; }
        public string Stat { get; set; }
        public Nullable<System.DateTime> HRdate { get; set; }
        public Nullable<System.DateTime> DecDate { get; set; }
    }
}
