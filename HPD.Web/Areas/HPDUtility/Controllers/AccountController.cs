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
using Enums = DAL.Enums;

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
                #region role designation
                //var identity = ((CustomPrincipal)HttpContext.User);
                //if (identity.Roles.Contains(Enums.Roles.Admin.ToString()))
                //{
                //    return RedirectToAction("Index", "Home");
                //}
                //else if (identity.Roles.Contains(Enums.Roles.User.ToString()))
                //{
                //    return RedirectToAction("NotFound", "Error");
                //}
                #endregion

                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
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

                    var successres = new { success = true, message = "Valid Credential" };
                   
                    return Json(JsonConvert.SerializeObject(successres),JsonRequestBehavior.AllowGet);

                }

            }
            var errorres = new { success = false, message = "Invalid Credential" };

            return Json(JsonConvert.SerializeObject(errorres), JsonRequestBehavior.AllowGet);
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