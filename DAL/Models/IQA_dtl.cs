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
    
    public partial class IQA_dtl
    {
        public string RefNo { get; set; }
        public int LineNum { get; set; }
        public string ChapISO1 { get; set; }
        public string ChapISO2 { get; set; }
        public string TypeFinding { get; set; }
        public string Findings { get; set; }
        public string ImmAction { get; set; }
        public string Analysis { get; set; }
        public string PrevAction { get; set; }
        public string Effectiveness { get; set; }
        public string Section { get; set; }
        public string ImgBefore { get; set; }
        public string ImgAfter { get; set; }
        public string Stat { get; set; }
        public string StatPerFind { get; set; }
        public Nullable<System.DateTime> StatPerFindDate { get; set; }
        public Nullable<bool> Repeated { get; set; }
        public string Auditees { get; set; }
        public string Branch { get; set; }
        public string Dept { get; set; }
        public string StatOC { get; set; }
        public Nullable<System.DateTime> StatOCDate { get; set; }
        public Nullable<bool> FV { get; set; }
        public Nullable<int> Seq { get; set; }
        public Nullable<System.DateTime> PerRPTDateModified { get; set; }
        public string whscode { get; set; }
        public string delstat { get; set; }
        public string delby { get; set; }
        public Nullable<System.DateTime> deldt { get; set; }
        public string imgpath { get; set; }
    }
}