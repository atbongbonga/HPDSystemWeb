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
    
    public partial class amrh
    {
        public int docentry { get; set; }
        public string Docnum { get; set; }
        public string Docname { get; set; }
        public string Users { get; set; }
        public string Revision { get; set; }
        public string Retentionpd { get; set; }
        public string DisposalMethod { get; set; }
        public string Encodedby { get; set; }
        public Nullable<System.DateTime> Encodeddate { get; set; }
        public string remarks { get; set; }
        public Nullable<System.DateTime> updatedate { get; set; }
        public Nullable<int> retmonth { get; set; }
        public Nullable<int> retyr { get; set; }
        public string Initiator { get; set; }
        public Nullable<int> ord { get; set; }
    }
}
