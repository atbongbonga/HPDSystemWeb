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
    
    public partial class EmpLeaveYrLogTEST
    {
        public int DocEntry { get; set; }
        public System.DateTime DocDate { get; set; }
        public string EmpCode { get; set; }
        public int Yr { get; set; }
        public Nullable<decimal> TotalLeave { get; set; }
        public Nullable<decimal> EL { get; set; }
        public Nullable<decimal> PL { get; set; }
        public Nullable<decimal> VL { get; set; }
        public string Status { get; set; }
        public Nullable<decimal> CTotalLeave { get; set; }
        public Nullable<decimal> CEL { get; set; }
        public Nullable<decimal> CPL { get; set; }
        public Nullable<decimal> CVL { get; set; }
        public Nullable<System.DateTime> ModDate { get; set; }
        public string ModBy { get; set; }
    }
}
