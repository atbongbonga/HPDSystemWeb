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
    
    public partial class HPDProgram
    {
        public int ProgramID { get; set; }
        public string ProgramName { get; set; }
        public string Description { get; set; }
        public string Developer { get; set; }
        public string InCharge { get; set; }
        public string ProgVer { get; set; }
        public Nullable<int> Active { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<System.DateTime> ModDate { get; set; }
        public string ModBy { get; set; }
    }
}