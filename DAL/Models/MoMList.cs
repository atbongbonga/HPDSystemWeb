//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MoMList
    {
        public int DocEntry { get; set; }
        public Nullable<System.DateTime> DocSDate { get; set; }
        public Nullable<System.DateTime> DocEDate { get; set; }
        public string Title { get; set; }
        public string Reg { get; set; }
        public string Incharge { get; set; }
        public byte[] Pic { get; set; }
    }
}
