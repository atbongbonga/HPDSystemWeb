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
    
    public partial class PYPnlty
    {
        public string Empid { get; set; }
        public int TransId { get; set; }
        public string Code { get; set; }
        public string Dscrpt { get; set; }
        public string Stat { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public Nullable<decimal> DocTotal { get; set; }
        public string Mth { get; set; }
    }
}
