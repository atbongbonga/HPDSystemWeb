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
    
    public partial class PRDeducDet
    {
        public int TransId { get; set; }
        public int Line_Num { get; set; }
        public string DocEntry { get; set; }
        public string EmpCode { get; set; }
        public Nullable<decimal> AppAmt { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> PaidDate { get; set; }
        public string PaidTag { get; set; }
        public string Remarks { get; set; }
    }
}
