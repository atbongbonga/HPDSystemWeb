using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace HPD.Web.Areas.HPDUtility.Controllers
{
    public class ErrorController : Controller
    {
        // GET: HPDUtility/Error
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult NotFound()
        {

            HttpCookie cookie = new HttpCookie("userseccookie", "");
            cookie.Expires = DateTime.Now.AddDays(-10);
            cookie.Value = null;
            Response.Cookies.Add(cookie);

            FormsAuthentication.SignOut();
            return View();
        }
    }
}