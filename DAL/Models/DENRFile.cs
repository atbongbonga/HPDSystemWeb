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
    
    public partial class DENRFile
    {
        public int Docentry { get; set; }
        public int Ln { get; set; }
        public string DocName { get; set; }
        public byte[] DocFile { get; set; }
        public string DocPath { get; set; }
        public string DocExt { get; set; }
        public string Filename { get; set; }
        public string doctype { get; set; }
        public string uploaddate { get; set; }
        public Nullable<System.DateTime> expdate { get; set; }
        public Nullable<System.DateTime> issdate { get; set; }
        public Nullable<System.DateTime> renewdate { get; set; }
        public string del { get; set; }
    }
}
