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
    
    public partial class PrsnlReqDtl
    {
        public int DocEntry { get; set; }
        public string Category { get; set; }
        public string Position { get; set; }
        public int Qty { get; set; }
        public string Reason { get; set; }
        public string FormalEduc { get; set; }
        public string TrainSkill { get; set; }
        public string Experience { get; set; }
        public string Others { get; set; }
        public string Stat { get; set; }
        public string Remarks { get; set; }
        public string NotedBy { get; set; }
        public Nullable<System.DateTime> NoteDate { get; set; }
        public string VerifyBy { get; set; }
        public Nullable<System.DateTime> VerifyDate { get; set; }
        public string AppBy { get; set; }
        public Nullable<System.DateTime> AppDate { get; set; }
        public string ReqStat { get; set; }
        public string ReplacementFor { get; set; }
    }
}
