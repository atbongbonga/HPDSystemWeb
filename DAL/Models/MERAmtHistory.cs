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
    
    public partial class MERAmtHistory
    {
        public int Docentry { get; set; }
        public Nullable<int> Empcode { get; set; }
        public string Transtype { get; set; }
        public Nullable<decimal> Transpo { get; set; }
        public Nullable<decimal> Parking { get; set; }
        public string Branchcode { get; set; }
        public Nullable<decimal> Phone { get; set; }
        public Nullable<decimal> Internet { get; set; }
        public Nullable<decimal> MealAllow { get; set; }
        public string EffectPr { get; set; }
        public string EffectYr { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public string Stat { get; set; }
    }
}
