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
    
    public partial class BiAppLogsBck
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public int LineId { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public string WhsCode { get; set; }
        public string EmpCode { get; set; }
        public string Patient { get; set; }
        public string ItemCode { get; set; }
        public Nullable<int> Qty { get; set; }
        public Nullable<decimal> Amt { get; set; }
        public string Stat { get; set; }
        public Nullable<decimal> AppAmt { get; set; }
        public string LabNum { get; set; }
        public string Remarks { get; set; }
        public string Payment { get; set; }
        public string Encoder { get; set; }
        public string PID { get; set; }
        public string PIDname { get; set; }
        public Nullable<decimal> Benefit { get; set; }
        public Nullable<decimal> Cash { get; set; }
        public Nullable<decimal> SD { get; set; }
        public string AppState { get; set; }
        public string AppRemarks { get; set; }
        public int LogId { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string IpAdd { get; set; }
    }
}
