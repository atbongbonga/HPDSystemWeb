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
    
    public partial class AuditRequestLog
    {
        public int docentry { get; set; }
        public string Task { get; set; }
        public string empname { get; set; }
        public string LogDate { get; set; }
        public string stat { get; set; }
        public string yr { get; set; }
        public string pd { get; set; }
        public string approveby { get; set; }
        public string approvedate { get; set; }
    }
}
