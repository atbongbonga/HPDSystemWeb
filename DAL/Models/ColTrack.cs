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
    
    public partial class ColTrack
    {
        public int DocEntry { get; set; }
        public Nullable<System.DateTime> CollDate { get; set; }
        public string CardCode { get; set; }
        public string AcctName { get; set; }
        public string TOC { get; set; }
        public string Contact { get; set; }
        public string SpecInstr { get; set; }
        public string CallHistory { get; set; }
        public string Collector { get; set; }
        public string AssgnArea { get; set; }
        public string Stat { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UploadBy { get; set; }
        public string AssignBy { get; set; }
        public Nullable<System.DateTime> AssignDate { get; set; }
        public string RemUC { get; set; }
        public string Messenger { get; set; }
        public string Coordinator { get; set; }
        public string CancelBy { get; set; }
        public Nullable<System.DateTime> CancelDate { get; set; }
        public string CancelRemarks { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string Confirmed { get; set; }
        public string Mother { get; set; }
        public Nullable<System.DateTime> DateFollow { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<int> QrNo { get; set; }
        public Nullable<int> TypeID { get; set; }
        public string PType { get; set; }
        public string Address { get; set; }
        public Nullable<int> ChkCount { get; set; }
        public string OtherMsgr { get; set; }
        public string AppStatus { get; set; }
        public string Itnr { get; set; }
        public Nullable<int> RR { get; set; }
        public string BranchStat { get; set; }
        public string MainUpdate { get; set; }
        public Nullable<int> Count2307 { get; set; }
        public Nullable<int> Verified2307 { get; set; }
        public Nullable<int> QRSAP { get; set; }
        public string BCWhs { get; set; }
        public Nullable<int> BCDoc { get; set; }
    }
}