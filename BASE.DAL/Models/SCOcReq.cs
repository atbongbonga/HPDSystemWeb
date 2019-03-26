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
    
    public partial class SCOcReq
    {
        public Nullable<int> DocEntry { get; set; }
        public string OcCode { get; set; }
        public string Position { get; set; }
        public string WhsCode { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public Nullable<System.TimeSpan> STime { get; set; }
        public Nullable<System.TimeSpan> ETime { get; set; }
        public Nullable<decimal> TTime { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> IsBreak { get; set; }
        public string ReqStat { get; set; }
        public string ReqBy { get; set; }
        public Nullable<System.DateTime> ReqDate { get; set; }
        public string HRStat { get; set; }
        public Nullable<System.DateTime> HRStatDate { get; set; }
        public string HREmpCode { get; set; }
        public int DocID { get; set; }
        public Nullable<System.DateTime> TimeIn { get; set; }
        public Nullable<System.DateTime> LunchOut { get; set; }
        public Nullable<System.DateTime> LunchIn { get; set; }
        public Nullable<System.DateTime> TimeOut { get; set; }
        public Nullable<System.DateTime> DTRDate { get; set; }
    }
}
