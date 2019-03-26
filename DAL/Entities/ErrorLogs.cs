using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.DAL.Entities
{
    public class ErrorLogs
    {
        public int DocEntry { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public string EmpCode { get; set; }
        public string WrkStation { get; set; }
        public string IPAdd { get; set; }
        public string Outlook { get; set; }
        public string ProgName { get; set; }
        public string ProgVer { get; set; }
        public string ProgPath { get; set; }
        public byte[] ErrPic { get; set; }
        public string ErrMsg { get; set; }
        public string ErrDtls { get; set; }
        public string ErrSrc { get; set; }
        public Nullable<int> IssueID { get; set; }
        public string Fixed { get; set; }
        public string ErrCode { get; set; }

    }
    public class ErrorByIncharge
    {
        public string InCharge { get; set; }
        public int IssueCount { get; set; }
        public byte[] InChargeIMG { get; set; }
    }
    public class ErrorByProgram
    {
        public string ProgramName { get; set; }
        public int IssueCount { get; set; }
    }
}
