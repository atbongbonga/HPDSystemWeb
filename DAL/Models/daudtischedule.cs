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
    
    public partial class daudtischedule
    {
        public int docentry { get; set; }
        public string task { get; set; }
        public string branch { get; set; }
        public string emp { get; set; }
        public Nullable<System.DateTime> sched { get; set; }
        public string complete { get; set; }
        public Nullable<System.DateTime> comdate { get; set; }
        public string pd { get; set; }
        public string yr { get; set; }
        public string edtby { get; set; }
        public Nullable<System.DateTime> edtdt { get; set; }
        public Nullable<System.DateTime> edtolddt { get; set; }
    }
}