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
    
    public partial class OPCF003
    {
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
        public Nullable<int> BrEntry { get; set; }
        public string Dept { get; set; }
        public string Encoder { get; set; }
        public int Docentry { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public string RHRemarks { get; set; }
        public Nullable<int> BNC { get; set; }
        public string DocCode { get; set; }
        public string ATCCode { get; set; }
        public Nullable<decimal> ATCRate { get; set; }
        public Nullable<byte> isRet { get; set; }
        public Nullable<byte> isSls { get; set; }
        public Nullable<byte> SlsStat { get; set; }
        public string CashierID { get; set; }
        public Nullable<int> UtilsID { get; set; }
        public Nullable<int> PymtID { get; set; }
    }
}
