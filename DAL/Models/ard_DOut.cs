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
    
    public partial class ard_DOut
    {
        public int DocEntry { get; set; }
        public int LinNum { get; set; }
        public string Itemcode { get; set; }
        public string ItemDesc { get; set; }
        public Nullable<int> Qty { get; set; }
        public string Unit { get; set; }
    }
}