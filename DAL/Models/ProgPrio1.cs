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
    
    public partial class ProgPrio1
    {
        public int DocEntry { get; set; }
        public string DueDate { get; set; }
        public string DoneDate { get; set; }
        public string Programmer { get; set; }
        public string Priority1 { get; set; }
        public string ProgName { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> BaseEntry { get; set; }
    }
}
