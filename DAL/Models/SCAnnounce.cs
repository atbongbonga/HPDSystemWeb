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
    
    public partial class SCAnnounce
    {
        public int DocEntry { get; set; }
        public System.DateTime DocDate { get; set; }
        public System.DateTime SchedDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Perform { get; set; }
        public string EmpCode { get; set; }
    }
}
