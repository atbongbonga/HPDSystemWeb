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
    
    public partial class ALABANG_008_PrsnlReq_20180706
    {
        public int DocEntry { get; set; }
        public System.DateTime DocDate { get; set; }
        public string BranchCode { get; set; }
        public string DeptCode { get; set; }
        public string SecCode { get; set; }
        public Nullable<bool> Probationary { get; set; }
        public Nullable<bool> OnCal { get; set; }
        public string ReqBy { get; set; }
        public string Stat { get; set; }
        public string Remarks { get; set; }
    }
}
