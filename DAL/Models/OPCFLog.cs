//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OPCFLog
    {
        public int BaseEntry { get; set; }
        public Nullable<int> Docentry { get; set; }
        public string StatType { get; set; }
        public Nullable<decimal> OrigAmt { get; set; }
        public Nullable<decimal> SpentAmt { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public string BNCStat { get; set; }
        public string whscode { get; set; }
        public Nullable<int> isSales { get; set; }
    }
}
