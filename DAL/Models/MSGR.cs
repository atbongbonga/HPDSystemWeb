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
    
    public partial class MSGR
    {
        public string MsgrID { get; set; }
        public string MsgrName { get; set; }
        public string EmpType { get; set; }
        public Nullable<bool> Stat { get; set; }
        public Nullable<int> AreaCode { get; set; }
    }
}