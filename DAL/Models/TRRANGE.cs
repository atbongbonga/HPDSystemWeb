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
    
    public partial class TRRANGE
    {
        public int DOCENTRY { get; set; }
        public Nullable<System.DateTime> DATE_CREATED { get; set; }
        public string TR_TI_CODE { get; set; }
        public string TR_SEX_CODE { get; set; }
        public string TR_FASTING_CODE { get; set; }
        public string TR_AGETO { get; set; }
        public string TR_AGECODE { get; set; }
        public string TR_RANGE_DESC { get; set; }
        public string TR_NORMAL_LOLIMIT { get; set; }
        public string TR_UPPER_UPLIMIT { get; set; }
        public string TR_PANIC_LOLIMIT { get; set; }
        public string TR_PANIC_UPLIMIT { get; set; }
        public string TR_MRR_DESC { get; set; }
        public string TR_UPDATE_BY { get; set; }
        public Nullable<System.DateTime> TR_UPDATE_ON { get; set; }
        public Nullable<System.DateTime> DATE_DONE { get; set; }
        public Nullable<bool> STATUS_CREATED { get; set; }
    }
}
