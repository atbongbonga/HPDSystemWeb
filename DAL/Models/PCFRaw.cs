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
    
    public partial class PCFRaw
    {
        public int Docentry { get; set; }
        public int LineNum { get; set; }
        public Nullable<int> Docnum { get; set; }
        public string DocCode { get; set; }
        public string DocName { get; set; }
        public string Whscode { get; set; }
        public string ATCCode { get; set; }
        public Nullable<decimal> ATCRate { get; set; }
        public Nullable<decimal> Amt { get; set; }
    }
}
