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
    
    public partial class PCFDelete
    {
        public int Docentry { get; set; }
        public Nullable<int> BrEntry { get; set; }
        public int Ln { get; set; }
        public string Reason { get; set; }
        public string Deleteby { get; set; }
        public Nullable<System.DateTime> DateDeleted { get; set; }
        public string Stat { get; set; }
        public Nullable<System.DateTime> AppDate { get; set; }
        public string AppBy { get; set; }
        public int DelID { get; set; }
    }
}
