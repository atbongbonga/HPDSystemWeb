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
        public ActionResult Details(string ProgramName)
        {
            ViewBag.Message = ProgramName;
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult GetErrorListByProgram(string ProgramName)
        {
            var draw = Request.Form.GetValues("draw").FirstOrDefault();
            var start = Request.Form.GetValues("start").FirstOrDefault();
            var length = Request.Form.GetValues("length").FirstOrDefault();

            var errorLogComponent = new ErrorLogComponent();
            var result = errorLogComponent.GetErrorByProgram(ProgramName);
            var model = result.Skip(Convert.ToInt32(start)).Take(Convert.ToInt32(length)).ToList();

            return Json(new { draw = draw, recordsFiltered = result.Count(), recordsTotal = result.Count(), data = model });
            //return Json(JsonConvert.SerializeObject(result), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetProjectSprintList(string ProgramName)
        {
            var sprintTaskComponent = new SprintTaskComponent();
            var result = sprintTaskComponent.GetProjectSprintList(ProgramName);
            var model = result.ToList();

            return Json(JsonConvert.SerializeObject(model), JsonRequestBehavior.AllowGet);
        }
        public ActionResult CreateProjectSprint(string path)
        {
            //var sprintTaskComponent = new SprintTaskComponent();
            //var result = sprintTaskComponent.CreateProjectSprint(ProgramName);
            //var model = result.ToList();

            return Json(JsonConvert.SerializeObject(path), JsonRequestBehavior.AllowGet);
            
        }
    }
}