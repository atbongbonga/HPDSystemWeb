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
    
    public partial class DOHReq
    {
        public int DocEntry { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public string ReqBy { get; set; }
        public string IDNo { get; set; }
        public string BranchCode { get; set; }
        public string Position { get; set; }
        public string AppBy { get; set; }
        public Nullable<System.DateTime> AppDate { get; set; }
        public string RcvBy { get; set; }
        public Nullable<System.DateTime> RcvDate { get; set; }
        public string NotBy { get; set; }
        public Nullable<System.DateTime> NotDate { get; set; }
        public string ReqStat { get; set; }
        public Nullable<int> DocID { get; set; }
    }
}
