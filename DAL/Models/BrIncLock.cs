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
    
    public partial class BrIncLock
    {
        public string DocEntry { get; set; }
        public string EmpCode { get; set; }
        public string EmpName { get; set; }
        public string BrPrfx { get; set; }
        public string DeptPrfx { get; set; }
        public string Position { get; set; }
        public Nullable<System.DateTime> DateHired { get; set; }
        public Nullable<int> C_Yrs { get; set; }
        public Nullable<int> C_Mos { get; set; }
        public string Rating { get; set; }
        public Nullable<decimal> GrossIncentive { get; set; }
        public Nullable<decimal> ALUL { get; set; }
        public Nullable<decimal> ALUL_ { get; set; }
        public Nullable<decimal> NetIncentive { get; set; }
    }
}
