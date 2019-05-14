using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using DAL.Logics;
using HPD.Web.CustomAuthentication;

namespace HPD.Web.Areas.HPDUtility.Controllers
{
    public class DataDictionaryController : Controller
    {
        // GET: HPDUtility/DataDictionary
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ServerLogin(string servername, string username, string password)
        {
            var datadictionaryComponent = new DataDictionaryComponent();
            var result = datadictionaryComponent.ServerLogin(servername, username, password);
            return Json(JsonConvert.SerializeObject(result), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetServerDatabaseList(string servername, string username, string password)
        {
            var datadictionaryComponent = new DataDictionaryComponent();
            var result = datadictionaryComponent.GetServerDatabaseList(servername, username, password);
            return Json(JsonConvert.SerializeObject(result), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetDatabaseTableList(string servername, string dbname, string username, string password)
        {
            var datadictionaryComponent = new DataDictionaryComponent();
            var result = datadictionaryComponent.GetDatabaseTableList(servername, dbname, username, password);
            return Json(JsonConvert.SerializeObject(result), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult GetTableProperty(string servername, string dbname, string tblname, string username, string password)
        {
            var draw = Request.Form.GetValues("draw").FirstOrDefault();
            var start = Request.Form.GetValues("start").FirstOrDefault();
            var length = Request.Form.GetValues("length").FirstOrDefault();

            var datadictionaryComponent = new DataDictionaryComponent();
            var result = datadictionaryComponent.GetTableProperty(servername, dbname, tblname, username, password);
            var model = result.Skip(Convert.ToInt32(start)).Take(Convert.ToInt32(length)).ToList();
            return Json(new { draw = draw, recordsFiltered = result.Count(), recordsTotal = result.Count(), data = model });
            //return Json(JsonConvert.SerializeObject(result), JsonRequestBehavior.AllowGet);
        }
        public ActionResult SaveExtendedProperty(string servername, string dbname, string tblname, string username, string password, string colname, string coldesc)
        {
            var datadictionaryComponent = new DataDictionaryComponent();
            var result = datadictionaryComponent.SaveExtendedProperty(servername, dbname, tblname, username, password, colname, coldesc);
            return Json(JsonConvert.SerializeObject(result), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetDatabaseInformation(string servername, string dbname, string tblname, string username, string password)
        {
            var datadictionaryComponent = new DataDictionaryComponent();
            var result = datadictionaryComponent.GetDatabaseInformation(servername, dbname, tblname, username, password);
            return Json(JsonConvert.SerializeObject(result), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetDatabaseUsageGraph(string servername, string dbname, string tblname, string username, string password)
        {
            var datadictionaryComponent = new DataDictionaryComponent();
            var result = datadictionaryComponent.GetDatabaseUsageGraph(servername, dbname, tblname, username, password);
            return Json(JsonConvert.SerializeObject(result), JsonRequestBehavior.AllowGet);
        }
    }
}