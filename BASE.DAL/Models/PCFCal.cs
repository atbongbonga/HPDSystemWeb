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
    
    public partial class PCFCal
    {
        public Nullable<int> Yr { get; set; }
        public Nullable<int> Pd { get; set; }
        public string Dy { get; set; }
        public System.DateTime Dt { get; set; }
        public string Description { get; set; }
        public string Typ { get; set; }
        public Nullable<int> Stat { get; set; }
        public string DTREntry { get; set; }
        public string ALUEntry { get; set; }
        public Nullable<System.DateTime> LeaveDL { get; set; }
        public Nullable<int> slsApp { get; set; }
    }
}
