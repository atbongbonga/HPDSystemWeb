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
    
    public partial class KMReadingAllowance
    {
        public int DocEntry { get; set; }
        public int RangeFrom { get; set; }
        public int RangeTo { get; set; }
        public decimal Allowance { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    }
}
