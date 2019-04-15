using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using DAL.Logics;

namespace HPD.Web.Areas.HPDUtility.Controllers
{
    public class HomeController : Controller
    {
        // GET: HPDUtility/Home
        public ActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        [AllowAnonymous]
        public ActionResult CreateErrorLog()
        {
            var errorLogComponent = new ErrorLogComponent();
            //var result = errorLogComponent.CreateErroLog("001", "sample");
            //return Json(JsonConvert.SerializeObject(result), JsonRequestBehavior.AllowGet);
            return null;
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult GetErrorLogs()
        {
            var errorLogComponent = new ErrorLogComponent();
            var result = errorLogComponent.GetErrorLogs();
            return Json(JsonConvert.SerializeObject(result), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult GetErrorCountByIncharge()
        {
            var errorLogComponent = new ErrorLogComponent();
            var result = errorLogComponent.GetErrorCountByIncharge();
            return Json(JsonConvert.SerializeObject(result), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult GetErrorCountByInchargeProgram(string InCharge)
        {
            var errorLogComponent = new ErrorLogComponent();
            var result = errorLogComponent.GetErrorCountByProgram(InCharge);
            return Json(JsonConvert.SerializeObject(result), JsonRequestBehavior.AllowGet);
        }

    }
}