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
    
    public partial class kinethsam
    {
        public string Typ { get; set; }
        public string DeducEntry { get; set; }
        public string DeducCode { get; set; }
        public string BaseEntry { get; set; }
        public string BaseType { get; set; }
        public System.DateTime DocDate { get; set; }
        public string EmpCode { get; set; }
        public string Remarks { get; set; }
        public Nullable<decimal> EE { get; set; }
        public Nullable<decimal> ER { get; set; }
        public string Stat { get; set; }
        public Nullable<int> TransID { get; set; }
        public Nullable<int> DocOige { get; set; }
        public Nullable<int> OIGE { get; set; }
    }
}
