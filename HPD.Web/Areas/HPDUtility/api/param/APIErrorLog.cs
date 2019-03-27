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
            public string userId { get; set; }
            public string exSys { get; set; }
            public string exImg { get; set; }
            public string exType { get; set; }
            public string vOutlook { get; set; }
        }
        public class TestAPI
        {
            public string param1 { get; set; }
            public string param2 { get; set; }
        }
    }
   
}