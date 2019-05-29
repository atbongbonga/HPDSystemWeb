using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using DAL.Logics;
using System.IO;
using DAL.Entities;
using System.Net;

namespace HPD.Web.Areas.HPDUtility.Controllers
{
    [AllowAnonymous]
    public class BPCalendarController : Controller
    {
        // GET: HPDUtility/BPCalendar
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetAllSprintList()
        {
            var sprintTaskComponent = new SprintTaskComponent();
            var result = sprintTaskComponent.GetAllSprint();
            var model = result.ToList();

            return Json(JsonConvert.SerializeObject(model), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetSprintListByDev(string empCode)
        {
            var sprintTaskComponent = new SprintTaskComponent();
            var result = sprintTaskComponent.GetSprintByDeveloper(empCode);
            var model = result.ToList();
            return Json(JsonConvert.SerializeObject(model), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetDeveloper()
        {
            var developerComponent = new DeveloperComponent();
            var result = developerComponent.GetDevelopers();
            return Json(JsonConvert.SerializeObject(result), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetSprintDeveloper(int sprintId)
        {
            var developerComponent = new DeveloperComponent();
            var result = developerComponent.GetSprintDeveloper(sprintId);
            return Json(JsonConvert.SerializeObject(result), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetDevColorCodeByProgram(string progName)
        {
            var developerComponent = new DeveloperComponent();
            var result = developerComponent.GetDevColorCodeByProgram(progName);
            return Json(JsonConvert.SerializeObject(result), JsonRequestBehavior.AllowGet);
        }
    }
}