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
    
    public partial class BrIncRate
    {
        public Nullable<decimal> RFrom { get; set; }
        public Nullable<decimal> RTo { get; set; }
        public string Level { get; set; }
        public Nullable<decimal> IncSup { get; set; }
        public Nullable<decimal> IncUp { get; set; }
        public Nullable<decimal> IncLess { get; set; }
        public Nullable<decimal> IncOther { get; set; }
        public Nullable<System.DateTime> ModDate { get; set; }
    }
}
