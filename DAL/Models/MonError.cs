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
    
    public partial class MonError
    {
        public int DocEntry { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public string ErrMess { get; set; }
        public string FrmName { get; set; }
        public string BtnName { get; set; }
        public string IpAdd { get; set; }
        public Nullable<int> EmpID { get; set; }
        public string ProgName { get; set; }
    }
}
