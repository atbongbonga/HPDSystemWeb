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
    
    public partial class EmpEventsExcluded
    {
        public int DocEntry { get; set; }
        public string BranchCode { get; set; }
        public string DeptCode { get; set; }
        public string SecCode { get; set; }
        public string Reason { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    }
}
