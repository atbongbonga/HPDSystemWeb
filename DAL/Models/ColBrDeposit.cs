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
    
    public partial class ColBrDeposit
    {
        public int DocEntry { get; set; }
        public string WhsCode { get; set; }
        public string PType { get; set; }
        public Nullable<System.DateTime> DepositDate { get; set; }
        public Nullable<decimal> DocTotal { get; set; }
        public string Bank { get; set; }
        public string Remarks { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string FileFormat { get; set; }
        public Nullable<int> CTDoc { get; set; }
    }
}
