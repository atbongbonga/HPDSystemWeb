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
    
    public partial class TaskList
    {
        public Nullable<System.DateTime> DocDate { get; set; }
        public string ProgName { get; set; }
        public string ProgDesc { get; set; }
        public string Task { get; set; }
        public string Solution { get; set; }
        public Nullable<int> Stat { get; set; }
        public string Developer { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> DateDelivered { get; set; }
        public int LineNum { get; set; }
        public Nullable<System.DateTime> TargetDate { get; set; }
        public string RequestBy { get; set; }
        public string Priority { get; set; }
        public string Percentage { get; set; }
        public Nullable<int> InclExcl { get; set; }
        public int DocEntry { get; set; }
        public string Type { get; set; }
        public string ProgType { get; set; }
    }
}