using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using DAL.Logics;
using HPD.Web.CustomAuthentication;
using HPD.Web.Areas.HPDUtility.Models;

namespace HPD.Web.Areas.HPDUtility.Controllers
{
    public class AccountController : Controller
    {
        // GET: HPDUtility/Account
        public ActionResult Index(string ReturnUrl = "")
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            ViewBag.ReturnUrl = ReturnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        //[ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel loginvm)
        {
            string ReturnUrl = "";
            //var userComponent = new UserComponent();

            if (Membership.ValidateUser(loginvm.UserName, loginvm.Password))
            {
                var user = (CustomMembershipUser)Membership.GetUser(loginvm.UserName, false);
                if (user != null)
                {
                    Models.CustomSerializeModel userModel = new Models.CustomSerializeModel()
                    {
                        UserId = user.UserId,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        RoleName = user.Role
                    };

                    string userData = JsonConvert.SerializeObject(userModel);
                    FormsAuthenticationTicket authTicket = new FormsAuthenticationTicket
                        (
                        1, loginvm.UserName, DateTime.Now, DateTime.Now.AddMinutes(15), false, userData
                        );

                    string enTicket = FormsAuthentication.Encrypt(authTicket);
                    HttpCookie faCookie = new HttpCookie("Cookie1", enTicket);
                    Response.Cookies.Add(faCookie);
                }

                if (Url.IsLocalUrl(ReturnUrl))
                {
                    return Redirect(ReturnUrl);
                }
                else
                {
                    return RedirectToAction("Index","Home");
                }
            }
            return View();
        }

        public ActionResult Logout()
        {
            HttpCookie cookie = new HttpCookie("Cookie1", "");
            cookie.Expires = DateTime.Now.AddDays(-10);
            cookie.Value = null;
            Response.Cookies.Add(cookie);

            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Account", null);
        }
        //public ActionResult Login(string u, string p)
        //{
        //    return View();
        //}
    }
}