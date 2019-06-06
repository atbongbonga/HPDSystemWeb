using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using DAL.Logics;
using HPD.Web.CustomAuthentication;
using DAL.Entities;

namespace HPD.Web.Areas.HPDUtility.Controllers
{
    [CustomAuthorize(Roles = "Admin,User")]
    public class HomeController : Controller
    {
        
        // GET: HPDUtility/Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetErrorLogs()
        {
            var errorLogComponent = new ErrorLogComponent();
            var result = errorLogComponent.GetErrorLogs();
            return Json(JsonConvert.SerializeObject(result), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult GetErrorCountByIncharge()
        {
            var errorLogComponent = new ErrorLogComponent();
            var result = errorLogComponent.GetErrorCountByIncharge();
            return Json(JsonConvert.SerializeObject(result), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult GetErrorCountByInchargeProgram(string InCharge)
        {
            var errorLogComponent = new ErrorLogComponent();
            var result = errorLogComponent.GetErrorCountByProgram(InCharge);
            return Json(JsonConvert.SerializeObject(result), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult GetUserProfileImage()
        {
            var identity = ((CustomPrincipal)HttpContext.User);
            if (identity != null)
            {
                var userComponent = new UserComponent();
                var result = userComponent.GetUserDetails(Convert.ToString(identity.UserId));
                return Json(JsonConvert.SerializeObject(result), JsonRequestBehavior.AllowGet);
            }
            return null;
            
        }

        public ActionResult CreateOtherProjectSprint(ProjectSprints ProjSprint)
        {
            var identity = ((CustomPrincipal)HttpContext.User);
            ProjSprint.CreatedBy = identity.UserId.ToString();

            var sprintTaskComponent = new SprintTaskComponent();
            var result = sprintTaskComponent.CreateOtherProjectSprint(ProjSprint);
            return Json(JsonConvert.SerializeObject(result), JsonRequestBehavior.AllowGet);

        }


    }
}