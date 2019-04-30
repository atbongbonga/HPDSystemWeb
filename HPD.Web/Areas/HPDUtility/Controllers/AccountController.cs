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
    [AllowAnonymous]
    public class AccountController : Controller
    {
        // GET: HPDUtility/Account
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel loginvm)
        {

            if (Membership.ValidateUser(loginvm.UserName, loginvm.Password))
            {
                var getuser = (CustomMembershipUser)Membership.GetUser(loginvm.UserName, false);
                
                if (getuser != null)
                {
                    var userComponent = new UserComponent();
                    var getuserdetail = userComponent.GetUserDetails(Convert.ToString(getuser.UserId));
                    Models.CustomSerializeModel userModel = new Models.CustomSerializeModel()
                    {
                        UserId = getuserdetail.UserId,
                        FirstName = getuserdetail.FirstName,
                        LastName = getuserdetail.LastName,
                        RoleName = getuserdetail.Role

                    };
                    
                    string userData = JsonConvert.SerializeObject(userModel);
                    FormsAuthenticationTicket authTicket = new FormsAuthenticationTicket
                        (
                        1, loginvm.UserName, DateTime.Now, DateTime.Now.AddMinutes(15), false, userData
                        );

                    string enTicket = FormsAuthentication.Encrypt(authTicket);
                    HttpCookie faCookie = new HttpCookie("userseccookie", enTicket);
                    Response.Cookies.Add(faCookie);

                    ViewBag.Message = "Valid Credential";
                    return RedirectToAction("Index", "Home");

                }

            }
            ViewBag.Message = "Invalid Credential";
            return View(); 
        }

        public ActionResult Logout()
        {
            HttpCookie cookie = new HttpCookie("userseccookie", "");
            cookie.Expires = DateTime.Now.AddDays(-10);
            cookie.Value = null;
            Response.Cookies.Add(cookie);

            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Account");
        }
    }
}