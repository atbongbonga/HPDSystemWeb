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
    
    public partial class PyPayroll
    {
        public string DocEntry { get; set; }
        public Nullable<int> Line_Num { get; set; }
        public string Mth { get; set; }
        public string Pd { get; set; }
        public string Yr { get; set; }
        public Nullable<System.DateTime> DocDateFrom { get; set; }
        public Nullable<System.DateTime> DocDateTo { get; set; }
        public string EmpID { get; set; }
        public string EmpName { get; set; }
        public string WhsCode { get; set; }
        public string WhsName { get; set; }
        public string Dept { get; set; }
        public string CompName { get; set; }
        public string CivilSat { get; set; }
        public string ClassRate { get; set; }
        public Nullable<decimal> BscSalary { get; set; }
        public Nullable<decimal> BscEcola { get; set; }
        public Nullable<decimal> BscOA { get; set; }
        public Nullable<decimal> BscTotal { get; set; }
        public Nullable<int> SchedDay { get; set; }
        public Nullable<int> NoAbsent { get; set; }
        public Nullable<int> NoPrsntDay { get; set; }
        public Nullable<decimal> Undertime { get; set; }
        public Nullable<decimal> LateMin { get; set; }
        public Nullable<decimal> OTTI { get; set; }
        public Nullable<decimal> OTTO { get; set; }
        public Nullable<decimal> NDOT { get; set; }
        public Nullable<decimal> RDOT { get; set; }
        public Nullable<decimal> SalaryAmt { get; set; }
        public Nullable<decimal> EcolaAmt { get; set; }
        public Nullable<decimal> OAamt { get; set; }
        public Nullable<decimal> OTAmt { get; set; }
        public Nullable<decimal> LateAmt { get; set; }
        public Nullable<decimal> UTAmt { get; set; }
        public Nullable<decimal> AbstAmt { get; set; }
        public Nullable<decimal> SI { get; set; }
        public Nullable<decimal> MA { get; set; }
        public Nullable<decimal> AL { get; set; }
        public Nullable<decimal> AB { get; set; }
        public Nullable<decimal> TotEarns { get; set; }
        public Nullable<decimal> SSSEE { get; set; }
        public Nullable<decimal> SSSER { get; set; }
        public Nullable<decimal> ECC { get; set; }
        public Nullable<decimal> SSSPremCont { get; set; }
        public Nullable<decimal> PrvPhilHlth { get; set; }
        public Nullable<decimal> PhilHlthCont { get; set; }
        public Nullable<decimal> SSSLoan { get; set; }
        public Nullable<decimal> HDMFLoan { get; set; }
        public Nullable<decimal> HDMFCont { get; set; }
        public Nullable<decimal> PrevHDMF { get; set; }
        public Nullable<decimal> TITO { get; set; }
        public Nullable<decimal> AR { get; set; }
        public Nullable<decimal> UN { get; set; }
        public Nullable<decimal> CT { get; set; }
        public Nullable<decimal> Penalties { get; set; }
        public Nullable<decimal> TaxWhld { get; set; }
        public Nullable<decimal> TotDeduc { get; set; }
        public Nullable<decimal> LoansAmt { get; set; }
        public Nullable<decimal> FisthalfPay { get; set; }
        public Nullable<decimal> EL { get; set; }
        public Nullable<decimal> PL { get; set; }
        public Nullable<decimal> VL { get; set; }
        public Nullable<decimal> ACE { get; set; }
    }
}