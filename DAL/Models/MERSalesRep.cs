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
    
    public partial class MERSalesRep
    {
        public string EmpCode { get; set; }
        public string TransType { get; set; }
        public Nullable<decimal> Transpo { get; set; }
        public Nullable<decimal> Parking { get; set; }
        public string BranchCode { get; set; }
        public Nullable<decimal> Phone { get; set; }
        public Nullable<decimal> Internet { get; set; }
        public Nullable<decimal> MealAllow { get; set; }
        public string pr { get; set; }
        public string yr { get; set; }
        public Nullable<int> PrCnt { get; set; }
        public Nullable<int> Docentry { get; set; }
    }
}