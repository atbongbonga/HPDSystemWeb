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
    
    public partial class SCEmpSignLog
    {
        public string EmpCode { get; set; }
        public byte[] EmpSign { get; set; }
        public string LogIP { get; set; }
        public string LogUser { get; set; }
        public System.DateTime LogDate { get; set; }
    }
}
