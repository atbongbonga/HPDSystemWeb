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
    
    public partial class CMEventLog
    {
        public long DocEntry { get; set; }
        public string CMNo { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public Nullable<long> CreatedBy { get; set; }
    }
}
