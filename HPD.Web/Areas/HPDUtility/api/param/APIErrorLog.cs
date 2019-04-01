using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HPD.Web.Areas.HPDUtility.api.param
{
    public class APIErrorLog
    {
        public class CreateErrorLog
        {
            public string DocDate { get; set; }
            public string EmpCode { get; set; }
            public string WrkStation { get; set; }
            public string IPAdd { get; set; }
            public string Outlook { get; set; }
            public string ProgNameErr { get; set; }
            public string ProgVerErr { get; set; }
            public string ProgPath { get; set; }
            public string ErrMsgErr { get; set; }
            public string ErrDtls { get; set; }
            public string ErrSrc { get; set; }
            public string IssueID { get; set; }
            public string ErrCode { get; set; }
        }
        public class TestAPI
        {
            public string param1 { get; set; }
            public string param2 { get; set; }
        }
    }
   
}