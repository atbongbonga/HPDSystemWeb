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
    
    public partial class PYWTC
    {
        public int DocEntry { get; set; }
        public string Code { get; set; }
        public string CDesc { get; set; }
        public Nullable<decimal> CMin { get; set; }
        public Nullable<decimal> CMax { get; set; }
        public Nullable<decimal> Perc { get; set; }
        public Nullable<decimal> Plus { get; set; }
        public string Type { get; set; }
    }
}
