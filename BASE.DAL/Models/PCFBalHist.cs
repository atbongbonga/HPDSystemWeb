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
    
    public partial class PCFBalHist
    {
        public string CustodID { get; set; }
        public string Whscode { get; set; }
        public System.DateTime AsOfDate { get; set; }
        public Nullable<decimal> PCFBal { get; set; }
        public Nullable<decimal> CashOnhand { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<decimal> Shouldbe { get; set; }
    }
}
