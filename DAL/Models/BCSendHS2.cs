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
    
    public partial class BCSendHS2
    {
        public int DocEntry { get; set; }
        public string CashierID { get; set; }
        public string WhsCode { get; set; }
        public string LabNo { get; set; }
        public string CardCode { get; set; }
        public string PxName { get; set; }
        public string PMode { get; set; }
        public Nullable<decimal> Amt { get; set; }
        public string Remarks { get; set; }
        public Nullable<System.DateTime> TrxDate { get; set; }
        public Nullable<int> GenID { get; set; }
        public string DBTerm { get; set; }
        public string LISRemarks { get; set; }
        public string PxAge { get; set; }
        public string Stat { get; set; }
        public string CMNo { get; set; }
        public Nullable<int> IsCM { get; set; }
        public Nullable<decimal> MxCash { get; set; }
        public Nullable<decimal> MxCard { get; set; }
        public string CardName { get; set; }
        public Nullable<int> Import { get; set; }
        public Nullable<decimal> AppAmt { get; set; }
        public string PType { get; set; }
    }
}
