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
    
    public partial class IssSale
    {
        public int Docentry { get; set; }
        public Nullable<System.DateTime> Docdate { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string Descrip { get; set; }
        public string Custodian { get; set; }
        public string EmpName { get; set; }
        public string Stat { get; set; }
        public string Stattype { get; set; }
    }
}
