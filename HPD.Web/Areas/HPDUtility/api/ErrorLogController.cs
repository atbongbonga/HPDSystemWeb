using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL.Logics;
using HPD.Web.Areas.HPDUtility.api.param;
using static HPD.Web.Areas.HPDUtility.api.param.APIErrorLog;

namespace HPD.Web.Areas.HPDUtility.api
{
    public class ErrorLogController : ApiController
    {

        [HttpPost]
        public bool CreateErrorMessage(CreateErrorLog errorlog)
        {
            var errorLogComponent = new ErrorLogComponent();
            var result = errorLogComponent.CreateErroLog(errorlog.DocDate,errorlog.EmpCode, errorlog.WrkStation, errorlog.IPAdd, errorlog.Outlook, errorlog.ProgNameErr, errorlog.ProgVerErr, errorlog.ProgPath, errorlog.ErrMsgErr, errorlog.ErrSrc, errorlog.ErrDtls, errorlog.IssueID, errorlog.ErrCode);
            return true;                                 
        }                                                

        [HttpPost]
        public bool APITest(TestAPI param)   
        {
            return true;
        }
    }                                                 
}                                                     
                                                      
                                                                                         