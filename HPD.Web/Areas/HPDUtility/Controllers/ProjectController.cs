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
using HPD.Web.CustomAuthentication;

namespace HPD.Web.Areas.HPDUtility.Controllers
{
    [CustomAuthorize(Roles = "Admin")]
    public class ProjectController : Controller
    {
        // GET: HPDUtility/Project
        public ActionResult Details(string ProgramName)
        {
            if (ProgramName != null)
            {
                ViewBag.Message = ProgramName;
                return View();
            }
            return RedirectToAction("NotFound", "Error");

        }
        public ActionResult Sprint(int? Id)
        {
            if (Id != null)
            {
                ViewBag.Message = Id;
                return View();
            }
            return RedirectToAction("NotFound", "Error");
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
        public ActionResult CreateProjectSprint(ProjectSprints ProjSprint)
        {
            var sprintTaskComponent = new SprintTaskComponent();
            var result = sprintTaskComponent.CreateProjectSprint(ProjSprint);
            return Json(JsonConvert.SerializeObject(result), JsonRequestBehavior.AllowGet);

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

        public ActionResult CreateSprintTask(SprintTasks SprintTask)
        {
            SprintTask.Description = SprintTask.Description != null ? WebUtility.HtmlDecode(SprintTask.Description) : null;
            var sprintTaskComponent = new SprintTaskComponent();
            var result = sprintTaskComponent.CreateSrintTask(SprintTask);
            return Json(JsonConvert.SerializeObject(result), JsonRequestBehavior.AllowGet);
        }
        public ActionResult UpdateSprintTask(SprintTasks SprintTask)
        {
            SprintTask.Description = SprintTask.Description != null ? WebUtility.HtmlDecode(SprintTask.Description) : null;
            var sprintTaskComponent = new SprintTaskComponent();
            var result = sprintTaskComponent.UpdateSprintTask(SprintTask);
            return Json(JsonConvert.SerializeObject(result), JsonRequestBehavior.AllowGet);
        }
        public ActionResult UpdateSprintTaskActivity(int taskId,int act)
        {
            var sprintTaskComponent = new SprintTaskComponent();
            var result = sprintTaskComponent.UpdateSrintTaskActivity(taskId, act);
            return Json(JsonConvert.SerializeObject(result), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetSprintTask(int SprintId)
        {
            var sprintTaskComponent = new SprintTaskComponent();
            var result = sprintTaskComponent.GetSprintTask(SprintId);
            return Json(JsonConvert.SerializeObject(result), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetTaskDetails(int taskId)
        {
            var sprintTaskComponent = new SprintTaskComponent();
            var result = sprintTaskComponent.GetTaskDetails(taskId);
            return Json(JsonConvert.SerializeObject(result), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetSprintMemberCapacity(int sprintId)
        {
            var sprintTaskComponent = new SprintTaskComponent();
            var result = sprintTaskComponent.GetSprintMemberCapacity(sprintId);
            return Json(JsonConvert.SerializeObject(result), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetTeamWorkDetails(int sprintId)
        {
            var sprintTaskComponent = new SprintTaskComponent();
            var result = sprintTaskComponent.TeamWorkDetails(sprintId);
            return Json(JsonConvert.SerializeObject(result), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetUserWorkDetails(int sprintId)
        {
            var sprintTaskComponent = new SprintTaskComponent();
            var result = sprintTaskComponent.UserWorkDetails(sprintId);
            return Json(JsonConvert.SerializeObject(result), JsonRequestBehavior.AllowGet);
        }
    }
}
