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
    
    public partial class SCTPRemarksResetLog
    {
        public string EmpCode { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public string Typ { get; set; }
        public string Reason { get; set; }
        public string Remarks { get; set; }
        public string HRRemarks { get; set; }
        public string StatOic { get; set; }
        public string StatHr { get; set; }
        public string EmpRemarks { get; set; }
        public Nullable<System.DateTime> EmpTime { get; set; }
        public Nullable<System.DateTime> RTime { get; set; }
        public string ReqStat { get; set; }
        public string Hold { get; set; }
        public int DocEntry { get; set; }
        public Nullable<System.DateTime> EmpReqDate { get; set; }
        public Nullable<System.DateTime> OICStatDate { get; set; }
        public Nullable<System.DateTime> HRStatDate { get; set; }
        public string BranchName { get; set; }
        public string Penalty { get; set; }
        public string ALU { get; set; }
        public string OICEmpCode { get; set; }
        public string HREmpCode { get; set; }
        public string ResetBy { get; set; }
        public Nullable<System.DateTime> ResetDate { get; set; }
    }
}
