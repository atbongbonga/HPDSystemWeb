//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BASE.DAL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MiList
    {
        public int DocEntry { get; set; }
        public string MissionID { get; set; }
        public System.DateTime DocDate { get; set; }
        public string MiDesc { get; set; }
        public string MiArea { get; set; }
        public Nullable<System.DateTime> STime { get; set; }
        public Nullable<System.DateTime> ETime { get; set; }
        public Nullable<System.DateTime> CTime { get; set; }
        public Nullable<System.DateTime> ATime { get; set; }
        public string MiStatus { get; set; }
        public Nullable<System.DateTime> StatDate { get; set; }
    }
}
