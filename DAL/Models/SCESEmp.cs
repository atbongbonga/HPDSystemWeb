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
    
    public partial class SCESEmp
    {
        public string EmpCode { get; set; }
        public string EmpName { get; set; }
        public byte[] EmpImg { get; set; }
        public string BranchName { get; set; }
        public string BranchCode { get; set; }
        public Nullable<int> DeptCode { get; set; }
        public Nullable<int> SecCode { get; set; }
    }
}
