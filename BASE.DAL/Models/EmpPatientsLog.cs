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
    
    public partial class EmpPatientsLog
    {
        public string PID { get; set; }
        public string PName { get; set; }
        public string EmpCode { get; set; }
        public string Relation { get; set; }
        public int LineNum { get; set; }
        public string TaggedBy { get; set; }
        public System.DateTime TaggedDate { get; set; }
    }
}
