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
    
    public partial class ApplicantIntvLog
    {
        public int DocEntry { get; set; }
        public System.DateTime DocDate { get; set; }
        public string AppCode { get; set; }
        public string Interviewed { get; set; }
        public string Remarks { get; set; }
        public Nullable<bool> IntvStat { get; set; }
        public string IntvType { get; set; }
        public string LogUser { get; set; }
        public string LogIP { get; set; }
        public Nullable<System.DateTime> LogDate { get; set; }
    }
}
