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
    
    public partial class PrsnlReqList
    {
        public int DocEntry { get; set; }
        public string Position { get; set; }
        public string EmpCode { get; set; }
        public string Remarks { get; set; }
        public string ReqPos { get; set; }
        public Nullable<System.DateTime> Tentative { get; set; }
        public Nullable<System.DateTime> Deploy { get; set; }
        public Nullable<int> UnOffAppCode { get; set; }
    }
}
