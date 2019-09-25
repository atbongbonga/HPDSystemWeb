using DAL.Logics;
using HPD.Web.CustomAuthentication;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.Http.Cors;

namespace HPD.Web.Areas.HPDUtility.api
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AccountController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }

        public IHttpActionResult Login([FromBody] Models.LoginViewModel model)
        {
            if (Membership.ValidateUser(model.UserName, model.Password))
            {
                var getuser = (CustomMembershipUser)Membership.GetUser(model.UserName, false);

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
                        1, model.UserName, DateTime.Now, DateTime.Now.AddMinutes(15), false, userData
                        );

                    string enTicket = FormsAuthentication.Encrypt(authTicket);
                    HttpCookie faCookie = new HttpCookie("hpdsysuserseccookie", enTicket);
                    HttpContext.Current.Response.Cookies.Add(faCookie);

                    var successres = new { success = true, message = "Valid Credential" , CookieName = "hpdsysuserseccookie", CookieVal = enTicket };

                    return Json(JsonConvert.SerializeObject(successres));


                }

            }
            var errorres = new { success = false, message = "Invalid Credential", CookieName = "", CookieVal = "" };
            return Json(JsonConvert.SerializeObject(errorres));

        }

        //public HttpResponseMessage Login([FromBody] Models.LoginViewModel model)
        //{
        //    if (Membership.ValidateUser(model.UserName, model.Password))
        //    {
        //        var getuser = (CustomMembershipUser)Membership.GetUser(model.UserName, false);

        //        if (getuser != null)
        //        {
        //            var userComponent = new UserComponent();
        //            var getuserdetail = userComponent.GetUserDetails(Convert.ToString(getuser.UserId));
        //            Models.CustomSerializeModel userModel = new Models.CustomSerializeModel()
        //            {
        //                UserId = getuserdetail.UserId,
        //                FirstName = getuserdetail.FirstName,
        //                LastName = getuserdetail.LastName,
        //                RoleName = getuserdetail.Role

        //            };

        //            string userData = JsonConvert.SerializeObject(userModel);
        //            FormsAuthenticationTicket authTicket = new FormsAuthenticationTicket
        //                (
        //                1, model.UserName, DateTime.Now, DateTime.Now.AddMinutes(15), true, userData
        //                );

        //            string enTicket = FormsAuthentication.Encrypt(authTicket);
        //            HttpCookie faCookie = new HttpCookie("hpdsysuserseccookie", enTicket);
        //            HttpContext.Current.Response.Cookies.Add(faCookie);

        //            //FormsAuthentication.SetAuthCookie(model.UserName, false);
        //            //FormsAuthentication.RedirectFromLoginPage(model.UserName, false);

        //            //var resp = new HttpResponseMessage();

        //            //var cookie = new CookieHeaderValue("hpdsysuserseccookie", enTicket);
        //            //cookie.Expires = DateTimeOffset.Now.AddDays(1);
        //            //cookie.Domain = Request.RequestUri.Host;
        //            //cookie.Path = "/";

        //            //resp.Headers.AddCookies(new CookieHeaderValue[] { cookie });

        //            //return resp;


        //            //HttpContext.Current.Response.Redirect(FormsAuthentication.GetRedirectUrl(model.UserName, true));

        //            //var successres = new { success = true, message = "Valid Credential" };

        //            //var newUrl = this.Url.Link("Default", new
        //            //{
        //            //    Controller = "Home",
        //            //    Action = "Index"
        //            //});

        //            return Request.CreateResponse(HttpStatusCode.OK, new { Success = true, CookieName = "hpdsysuserseccookie", CookieVal = enTicket });


        //        }

        //    }
        //    var errorres = new { success = false, message = "Invalid Credential" };

        //    return Request.CreateResponse(HttpStatusCode.NotFound,
        //                                     new { Success = true, RedirectUrl = "" });

        //}
    }
}