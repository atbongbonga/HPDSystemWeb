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
    
    public partial class dauditgoal
    {
        public int docentry { get; set; }
        public string pd { get; set; }
        public string yr { get; set; }
        public string keyr { get; set; }
        public string obj { get; set; }
        public string encodedby { get; set; }
        public Nullable<System.DateTime> encodeddt { get; set; }
        public string goal { get; set; }
        public string risk { get; set; }
        public string control { get; set; }
    }
}