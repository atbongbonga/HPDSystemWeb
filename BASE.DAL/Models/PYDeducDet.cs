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
    
    public partial class PYDeducDet
    {
        public int TransId { get; set; }
        public int Line_Num { get; set; }
        public string EmpId { get; set; }
        public string Code { get; set; }
        public Nullable<decimal> Bal { get; set; }
        public Nullable<decimal> AmtPaid { get; set; }
        public Nullable<int> Mth { get; set; }
        public Nullable<int> Pd { get; set; }
        public Nullable<int> Yr { get; set; }
        public string stat { get; set; }
        public Nullable<decimal> Ebal { get; set; }
        public string Dscrpt { get; set; }
    }
}
