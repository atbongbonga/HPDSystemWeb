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
    
    public partial class EmpInfraNew
    {
        public int DocEntry { get; set; }
        public System.DateTime DocDate { get; set; }
        public string EmpCode { get; set; }
        public int Vid { get; set; }
        public string Reason { get; set; }
        public Nullable<System.DateTime> Returned { get; set; }
        public string DownLoad { get; set; }
        public string LogID { get; set; }
        public Nullable<System.DateTime> LogDate { get; set; }
        public string LogIP { get; set; }
        public string LogStat { get; set; }
    }
}