using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using DAL.Logics;


namespace HPD.Web.Areas.HPDUtility.Controllers
{
    public class ProjectController : Controller
    {
        // GET: HPDUtility/Project
        public ActionResult Details(string ProjectId)
        {
            ViewBag.Message = ProjectId;
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult GetErrorListByProgram(string ProgramName)
        {
            var errorLogComponent = new ErrorLogComponent();
            var result = errorLogComponent.GetErrorByProgram(ProgramName);
            return Json(JsonConvert.SerializeObject(result), JsonRequestBehavior.AllowGet);
        }
    }
}