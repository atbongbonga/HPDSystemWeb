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
    
    public partial class UPpmt
    {
        public string LabNo { get; set; }
        public Nullable<System.DateTime> TrxDate { get; set; }
        public string Whscode { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public string Patient { get; set; }
        public Nullable<decimal> OrigAmt { get; set; }
        public Nullable<decimal> PartialAmt { get; set; }
        public string Remarks { get; set; }
        public string Stat { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string MainStat { get; set; }
    }
}
