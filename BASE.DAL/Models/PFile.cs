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
    
    public partial class PFile
    {
        public int DocEntry { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public string Program { get; set; }
        public string Filename { get; set; }
        public string FilePath { get; set; }
        public byte[] FileImg { get; set; }
    }
}