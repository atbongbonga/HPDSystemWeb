//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmpLeaveGen
    {
        public int GenID { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public string EmpCode { get; set; }
        public string PrevYr { get; set; }
        public Nullable<decimal> PrevTLeave { get; set; }
        public Nullable<decimal> PrevEL { get; set; }
        public Nullable<decimal> PrevPL { get; set; }
        public Nullable<decimal> PrevVL { get; set; }
        public Nullable<int> PrevAce { get; set; }
        public string NewYr { get; set; }
        public Nullable<decimal> NewTLeave { get; set; }
        public Nullable<decimal> NewEL { get; set; }
        public Nullable<decimal> NewPL { get; set; }
        public Nullable<decimal> NewVL { get; set; }
        public Nullable<int> NewAce { get; set; }
        public string GenBy { get; set; }
    }
}
