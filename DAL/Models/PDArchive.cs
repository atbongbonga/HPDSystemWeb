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
    
    public partial class PDArchive
    {
        public int Docentry { get; set; }
        public string DocFilename { get; set; }
        public string Doctype { get; set; }
        public string UploadBy { get; set; }
        public Nullable<System.DateTime> UploadDate { get; set; }
        public byte[] DocFile { get; set; }
        public Nullable<int> BatchName { get; set; }
        public string FolderPath { get; set; }
        public string Program { get; set; }
        public Nullable<int> Linenum { get; set; }
        public Nullable<System.DateTime> UploadDt { get; set; }
        public Nullable<int> IsDel { get; set; }
        public string DelBy { get; set; }
        public Nullable<System.DateTime> DelDate { get; set; }
    }
}
