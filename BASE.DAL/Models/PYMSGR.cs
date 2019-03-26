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
    
    public partial class PYMSGR
    {
        public Nullable<int> DocEntry { get; set; }
        public string EmpCode { get; set; }
        public System.DateTime DocDate { get; set; }
        public Nullable<decimal> FirstRead { get; set; }
        public Nullable<decimal> LastRead { get; set; }
        public Nullable<decimal> Used { get; set; }
        public Nullable<decimal> AvePerKmLit { get; set; }
        public Nullable<decimal> AveLitUsed { get; set; }
        public Nullable<decimal> CostPerLit { get; set; }
        public Nullable<decimal> CostGasUsed { get; set; }
        public Nullable<decimal> MAllowDay { get; set; }
        public string Remarks { get; set; }
        public string Status { get; set; }
        public Nullable<decimal> GasRefilled { get; set; }
        public Nullable<decimal> ORnum { get; set; }
        public string Empname { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> DateUpdate { get; set; }
        public string Updateby { get; set; }
        public Nullable<decimal> ActualLiterUsed { get; set; }
    }
}