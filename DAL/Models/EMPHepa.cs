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
    
    public partial class EMPHepa
    {
        public string EmpCode { get; set; }
        public string VaccType { get; set; }
        public Nullable<System.DateTime> VaccSched { get; set; }
        public Nullable<System.DateTime> DateInjected { get; set; }
        public string Stat { get; set; }
        public byte[] DocSign { get; set; }
        public string Doctor { get; set; }
        public Nullable<int> DocEntry { get; set; }
    }
}
