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
    
    public partial class EmpLeaveList
    {
        public int DocEntry { get; set; }
        public string EmpCode { get; set; }
        public System.DateTime DocDate { get; set; }
        public string Leg { get; set; }
        public string Remarks { get; set; }
        public Nullable<System.DateTime> DateApproved { get; set; }
        public string ApprovedBy { get; set; }
    }
}
