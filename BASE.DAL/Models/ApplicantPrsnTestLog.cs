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
    
    public partial class ApplicantPrsnTestLog
    {
        public string AppCode { get; set; }
        public Nullable<System.DateTime> DateApplied { get; set; }
        public Nullable<int> QId { get; set; }
        public string QAnswer { get; set; }
        public string LogUser { get; set; }
        public string LogIP { get; set; }
        public Nullable<System.DateTime> LogDate { get; set; }
    }
}
