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
    
    public partial class sapcm_BK
    {
        public int DocEntry { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public string LabNo { get; set; }
        public string BaseEntry { get; set; }
        public string CardCode { get; set; }
        public Nullable<System.DateTime> DateRec { get; set; }
        public string WhsCode { get; set; }
        public string CMDMno { get; set; }
        public string Reason { get; set; }
        public Nullable<decimal> AdjAmt { get; set; }
        public Nullable<decimal> DocTotal { get; set; }
        public string Stat { get; set; }
        public string DocStatus { get; set; }
        public string CMApp { get; set; }
        public Nullable<System.DateTime> DoneDate { get; set; }
        public string Category { get; set; }
        public string EmpId { get; set; }
        public string PMode { get; set; }
        public string SDEmpID { get; set; }
        public Nullable<decimal> SDAmt { get; set; }
        public Nullable<int> SDDocEntry { get; set; }
        public Nullable<System.DateTime> BillAppDate { get; set; }
        public string BillAppBy { get; set; }
        public string RetainLabNo { get; set; }
        public string DoneBy { get; set; }
        public Nullable<int> PFStat { get; set; }
    }
}
