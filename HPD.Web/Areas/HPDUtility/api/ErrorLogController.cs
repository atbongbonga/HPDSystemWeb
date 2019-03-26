using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL.Logics;

namespace HPD.Web.Areas.HPDUtility.api
{
    public class ErrorLogController : ApiController
    {

        [HttpPost]
        public bool CreateErrorMessage(string empcode, string errmsg, string ipadd, string empid, string program, DateTime createddate, string type, string errpic)
        {
            var errorLogComponent = new ErrorLogComponent();
            var result = errorLogComponent.CreateErroLog(empcode, errmsg, ipadd, empid, program, createddate, type, errpic);
            return true;
        }
    }
}