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
    
    public partial class PyMsgrPenal
    {
        public string vTag { get; set; }
        public string EmpCode { get; set; }
        public string EmpName { get; set; }
        public System.DateTime DocDate { get; set; }
        public string Typ { get; set; }
        public Nullable<System.DateTime> Stime { get; set; }
        public Nullable<System.DateTime> Etime { get; set; }
        public Nullable<decimal> amt { get; set; }
        public string DocEntry { get; set; }
    }
}
