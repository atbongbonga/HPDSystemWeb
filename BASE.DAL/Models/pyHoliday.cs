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
    
    public partial class pyHoliday
    {
        public int DocEntry { get; set; }
        public string Empcode { get; set; }
        public string Empname { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public string DocDay { get; set; }
        public string DateType { get; set; }
        public Nullable<System.DateTime> TimeIn { get; set; }
        public Nullable<System.DateTime> TimeOut { get; set; }
        public string Dayleg { get; set; }
    }
}
