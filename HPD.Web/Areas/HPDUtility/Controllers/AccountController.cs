using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HPD.Web.Areas.HPDUtility.Controllers
{
    public class AccountController : Controller
    {
        // GET: HPDUtility/Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}