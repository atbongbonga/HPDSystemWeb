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
    
    public partial class MiPatDet
    {
        public string PatientID { get; set; }
        public string TestCode { get; set; }
        public string Stat { get; set; }
        public string WhsCode { get; set; }
        public Nullable<System.DateTime> UpdDt { get; set; }
        public int Docentry { get; set; }
        public string EmpID { get; set; }
        public string MissionID { get; set; }
    }
}
