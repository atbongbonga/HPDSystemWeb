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
    
    public partial class BCDepLog
    {
        public int DepID { get; set; }
        public int GenID { get; set; }
        public string WhsCode { get; set; }
        public Nullable<decimal> Cash { get; set; }
        public Nullable<decimal> PCF { get; set; }
        public Nullable<decimal> DepAmt { get; set; }
        public string UserID { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string Notes { get; set; }
        public Nullable<decimal> CCash { get; set; }
        public Nullable<decimal> CCheck { get; set; }
        public Nullable<decimal> CCoins { get; set; }
    }
}
