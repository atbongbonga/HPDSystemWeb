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
    
    public partial class ApplicantEmpBckLog
    {
        public int DocEntry { get; set; }
        public int AppCode { get; set; }
        public Nullable<System.DateTime> IncFrom { get; set; }
        public Nullable<System.DateTime> IncTo { get; set; }
        public string Position { get; set; }
        public string CompanyName { get; set; }
        public string Supervisor { get; set; }
        public string Reason { get; set; }
        public string Basic { get; set; }
        public string Other { get; set; }
        public string LogUser { get; set; }
        public string LogIP { get; set; }
        public Nullable<System.DateTime> LogDate { get; set; }
    }
}
