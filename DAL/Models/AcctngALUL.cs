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
    
    public partial class AcctngALUL
    {
        public string Empid { get; set; }
        public string Empname { get; set; }
        public Nullable<int> Absent { get; set; }
        public Nullable<int> Late { get; set; }
        public Nullable<int> Undertime { get; set; }
        public Nullable<int> LunchLate { get; set; }
        public Nullable<int> Dayoff { get; set; }
        public string Remarks { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<int> PL { get; set; }
        public Nullable<decimal> EL { get; set; }
        public Nullable<int> VL { get; set; }
        public string Others { get; set; }
        public Nullable<int> Notice { get; set; }
        public Nullable<System.DateTime> DateSaved { get; set; }
        public Nullable<System.DateTime> GenerateDate { get; set; }
        public string PostStat { get; set; }
        public int Docentry { get; set; }
        public Nullable<int> Ace { get; set; }
        public string SaveBy { get; set; }
    }
}
