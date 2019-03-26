using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HPD.Web.Areas.HPDUtility.Controllers
{
    public class HomeController : Controller
    {
        // GET: HPDUtility/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}