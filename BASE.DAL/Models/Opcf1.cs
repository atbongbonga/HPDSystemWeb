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
    
    public partial class Opcf1
    {
        public int DocEntry { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public string PaidTo { get; set; }
        public string WhsCode { get; set; }
        public string Stat { get; set; }
        public string stattype { get; set; }
        public string EmpID { get; set; }
        public string Custodian { get; set; }
        public Nullable<decimal> ReceiveAmt { get; set; }
        public Nullable<int> Docnum { get; set; }
        public string PostBr { get; set; }
        public int BrEntry { get; set; }
        public string Dept { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string Encoder { get; set; }
        public int DocEntry1 { get; set; }
    }
}