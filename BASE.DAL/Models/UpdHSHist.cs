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
    
    public partial class UpdHSHist
    {
        public int BaseEntry { get; set; }
        public Nullable<int> DocEntry { get; set; }
        public Nullable<System.DateTime> Docdate { get; set; }
        public string LabNo { get; set; }
        public string ItemCode { get; set; }
        public Nullable<decimal> HSFee { get; set; }
        public string HSCode { get; set; }
        public Nullable<System.DateTime> PostDate { get; set; }
        public string PostBy { get; set; }
        public string IPAdd { get; set; }
        public string Medtech { get; set; }
        public string CnServer { get; set; }
    }
}
