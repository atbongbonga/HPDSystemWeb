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
    
    public partial class EmpResignReq
    {
        public string EmpCode { get; set; }
        public Nullable<System.DateTime> DateResigned { get; set; }
        public Nullable<System.DateTime> DateFiled { get; set; }
        public string Reason { get; set; }
        public string Remarks { get; set; }
        public string RLetter { get; set; }
        public string ALetter { get; set; }
        public Nullable<bool> CompanyID { get; set; }
        public Nullable<bool> ATMCard { get; set; }
        public Nullable<bool> ExitInterview { get; set; }
        public Nullable<bool> Clearance { get; set; }
        public string NamePlate { get; set; }
        public Nullable<bool> COE { get; set; }
        public Nullable<System.DateTime> COEDate { get; set; }
        public Nullable<bool> AccCard { get; set; }
        public Nullable<int> ASCTrain { get; set; }
        public Nullable<System.DateTime> ASCDateIss { get; set; }
        public Nullable<System.DateTime> ASCDateExp { get; set; }
        public Nullable<int> ASCCopy { get; set; }
        public Nullable<int> DTTrain { get; set; }
        public Nullable<System.DateTime> DTDateIss { get; set; }
        public Nullable<System.DateTime> DTDateExp { get; set; }
        public Nullable<int> DTCopy { get; set; }
        public Nullable<int> HIVTrain { get; set; }
        public Nullable<System.DateTime> HIVDateIss { get; set; }
        public Nullable<System.DateTime> HIVDateExp { get; set; }
        public Nullable<int> HIVCopy { get; set; }
    }
}