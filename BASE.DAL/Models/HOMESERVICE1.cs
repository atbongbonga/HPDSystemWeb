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
    
    public partial class HOMESERVICE1
    {
        public int docentry { get; set; }
        public string whscode { get; set; }
        public string u_labno { get; set; }
        public Nullable<System.DateTime> docdate { get; set; }
        public string itemcode { get; set; }
        public string u_patient { get; set; }
        public Nullable<decimal> linetotal { get; set; }
        public string basecard { get; set; }
        public string cardname { get; set; }
        public string u_paymenttyp { get; set; }
        public string SAPCode { get; set; }
        public string MTCode { get; set; }
        public string MTName { get; set; }
        public string HSCode { get; set; }
        public string HSDesc { get; set; }
        public Nullable<decimal> HSFee { get; set; }
        public Nullable<decimal> HSRate { get; set; }
        public Nullable<decimal> @override { get; set; }
        public Nullable<decimal> PFAmt { get; set; }
        public Nullable<System.DateTime> HSTIME { get; set; }
        public Nullable<System.DateTime> Paydate { get; set; }
        public string EmpCode { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    }
}
