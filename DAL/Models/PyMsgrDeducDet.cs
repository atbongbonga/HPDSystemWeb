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
    
    public partial class PyMsgrDeducDet
    {
        public int TransID { get; set; }
        public int Line_Num { get; set; }
        public string EmpId { get; set; }
        public string Code { get; set; }
        public string Dscrpt { get; set; }
        public Nullable<decimal> AppAmt { get; set; }
        public string Mth { get; set; }
        public string Pd { get; set; }
        public string Yr { get; set; }
        public Nullable<decimal> Bal { get; set; }
        public string DocEntry { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
    }
}
