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
    
    public partial class PMChange
    {
        public string LabNo { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public string Patient { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public Nullable<decimal> Amt { get; set; }
        public Nullable<System.DateTime> TrxDate { get; set; }
        public string Remarks { get; set; }
        public string Stat { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CPMode { get; set; }
        public string NPMode { get; set; }
    }
}
