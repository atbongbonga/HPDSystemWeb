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
    
    public partial class POS_AUT_GLOBAL_CMT
    {
        public int DOCENTRY { get; set; }
        public string AUTO_COMMENT_GLOBAL_ID { get; set; }
        public string CREATED_BY { get; set; }
        public string UPDATED_BY { get; set; }
        public Nullable<System.DateTime> CREATED_ON { get; set; }
        public Nullable<System.DateTime> UPDATED_ON { get; set; }
        public string GLOBAL_COMMENT { get; set; }
        public string GLOBAL_COMMENT_TYPE { get; set; }
        public string IS_VALID { get; set; }
        public Nullable<System.DateTime> DATE_OF_EFFECTIVITY { get; set; }
    }
}