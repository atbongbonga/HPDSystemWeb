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
    
    public partial class SALES_PERITEM
    {
        public int Docentry { get; set; }
        public int Linenum { get; set; }
        public Nullable<System.DateTime> Docdate { get; set; }
        public Nullable<int> Yr { get; set; }
        public Nullable<int> Pd { get; set; }
        public Nullable<int> Day { get; set; }
        public string U_DEPT { get; set; }
        public string itemcode { get; set; }
        public string ItemName { get; set; }
        public Nullable<decimal> Sales { get; set; }
        public string whscode { get; set; }
        public string u_labno { get; set; }
    }
}
