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
    
    public partial class TrxlogsTestCode_HDR
    {
        public int Trxno { get; set; }
        public string TestCode { get; set; }
        public string TestName { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string Module { get; set; }
        public string Category { get; set; }
        public string Stat { get; set; }
        public string UserID { get; set; }
    }
}