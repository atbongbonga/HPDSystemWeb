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
    
    public partial class BiFrzReq
    {
        public int BFRId { get; set; }
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public int LineId { get; set; }
        public string EmpCode { get; set; }
        public string ItemCode { get; set; }
        public string Remarks { get; set; }
        public string ReqBy { get; set; }
        public System.DateTime DateReq { get; set; }
        public Nullable<System.DateTime> DateApp { get; set; }
        public string AppBy { get; set; }
        public string BFRStat { get; set; }
    }
}