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
    
    public partial class EMPLeave
    {
        public string EmpCode { get; set; }
        public int Yr { get; set; }
        public Nullable<decimal> TotalLeave { get; set; }
        public Nullable<decimal> EL { get; set; }
        public Nullable<decimal> PL { get; set; }
        public Nullable<decimal> VL { get; set; }
        public Nullable<int> Ace { get; set; }
    }
}
