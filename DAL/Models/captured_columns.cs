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
    
    public partial class captured_columns
    {
        public int object_id { get; set; }
        public string column_name { get; set; }
        public Nullable<int> column_id { get; set; }
        public string column_type { get; set; }
        public int column_ordinal { get; set; }
        public Nullable<bool> is_computed { get; set; }
    }
}
