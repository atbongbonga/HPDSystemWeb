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
    
    public partial class OEMP
    {
        public string EmpID { get; set; }
        public string EmpName { get; set; }
        public string WhsCode { get; set; }
        public string Active { get; set; }
        public string Position { get; set; }
        public string isResign { get; set; }
        public string isRegular { get; set; }
        public Nullable<System.DateTime> DateHired { get; set; }
    }
}
