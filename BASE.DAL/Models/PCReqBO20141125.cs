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
    
    public partial class PCReqBO20141125
    {
        public int DocEntry { get; set; }
        public string EmpID { get; set; }
        public string EmpName { get; set; }
        public string Program { get; set; }
        public string Branch { get; set; }
        public string AccLvl { get; set; }
        public string Remarks { get; set; }
        public string Stat { get; set; }
        public Nullable<System.DateTime> DateReq { get; set; }
        public string ApprovedBy { get; set; }
        public Nullable<System.DateTime> ApprovedDate { get; set; }
        public string Dept { get; set; }
        public Nullable<int> StatReq { get; set; }
    }
}
