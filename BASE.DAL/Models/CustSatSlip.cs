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
    
    public partial class CustSatSlip
    {
        public int DocEntry { get; set; }
        public string BranchCode { get; set; }
        public string Rating { get; set; }
        public string PComment { get; set; }
        public string NComment { get; set; }
        public string SrcInfo { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
    }
}