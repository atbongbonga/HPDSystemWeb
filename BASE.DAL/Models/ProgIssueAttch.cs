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
    
    public partial class ProgIssueAttch
    {
        public int DocEntry { get; set; }
        public int Linenum { get; set; }
        public string FilName { get; set; }
        public string FilePath { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public string EmpCode { get; set; }
        public string EmpName { get; set; }
        public string IFName { get; set; }
    }
}
