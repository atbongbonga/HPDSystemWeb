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
    
    public partial class PyMsgrDeduction
    {
        public int TransID { get; set; }
        public string EmpId { get; set; }
        public string Code { get; set; }
        public string Descrpt { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public Nullable<decimal> DocTotal { get; set; }
        public string status { get; set; }
        public string BrDept { get; set; }
        public Nullable<decimal> NoOfSD { get; set; }
        public string PdType { get; set; }
        public Nullable<decimal> AppAmt { get; set; }
        public string Remarks { get; set; }
    }
}
