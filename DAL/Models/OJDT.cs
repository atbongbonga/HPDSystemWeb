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
    
    public partial class OJDT
    {
        public int TransID { get; set; }
        public string TransType { get; set; }
        public Nullable<int> Baseref { get; set; }
        public Nullable<System.DateTime> refdate { get; set; }
        public string Remarks { get; set; }
        public string ref1 { get; set; }
        public string ref2 { get; set; }
        public string ref3 { get; set; }
        public string Stat { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string OrigCode { get; set; }
        public Nullable<System.DateTime> PostDate { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public Nullable<System.DateTime> DocDueDate { get; set; }
    }
}
