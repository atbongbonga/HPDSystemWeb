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
    
    public partial class TESTITPVD
    {
        public Nullable<decimal> TIVD_HKEY { get; set; }
        public Nullable<decimal> TIVD_SEQNO { get; set; }
        public Nullable<decimal> TIVD_LOLIMIT { get; set; }
        public Nullable<decimal> TIVD_UPLIMIT { get; set; }
        public string TIVD_VALUE { get; set; }
        public string TIVD_FLAG { get; set; }
        public Nullable<decimal> TIVD_DISP_SEQ { get; set; }
        public string TIVD_RR_DESC { get; set; }
        public string TIVD_ABNORM_FLAG { get; set; }
        public Nullable<System.DateTime> DATE_DONE { get; set; }
        public string STATUS_CREADTED { get; set; }
    }
}
