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
    
    public partial class PDSuggest
    {
        public int Docentry { get; set; }
        public string Descr { get; set; }
        public string Stat { get; set; }
        public string SuggestBy { get; set; }
        public Nullable<System.DateTime> SuggestDate { get; set; }
        public Nullable<System.DateTime> AppDate { get; set; }
        public string AppBy { get; set; }
        public Nullable<int> SortID { get; set; }
        public string Category { get; set; }
    }
}
