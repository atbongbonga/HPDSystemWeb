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
    
    public partial class ITDB_Meeting
    {
        public int DocEntry { get; set; }
        public string Title { get; set; }
        public string Objective { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public string InCharge { get; set; }
        public string Location { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CreateBy { get; set; }
    }
}
