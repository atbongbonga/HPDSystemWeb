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
    
    public partial class ErrorLog
    {
        public int DocEntry { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public string EmpCode { get; set; }
        public string WrkStation { get; set; }
        public string IPAdd { get; set; }
        public string Outlook { get; set; }
        public string ProgName { get; set; }
        public string ProgVer { get; set; }
        public string ProgPath { get; set; }
        public byte[] ErrPic { get; set; }
        public string ErrMsg { get; set; }
        public string ErrDtls { get; set; }
        public string ErrSrc { get; set; }
        public Nullable<int> IssueID { get; set; }
        public string Fixed { get; set; }
        public string ErrCode { get; set; }
    }
}
