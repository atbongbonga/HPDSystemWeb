using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using DAL.Entities;
using DAL.Enums;
using DAL.Models;

namespace DAL.Logics
{
    public class ErrorLogComponent
    {
        String dbcon = ConfigurationManager.ConnectionStrings["STAGHPCOMMON"].ConnectionString;

        public string CreateErrorlog()
        {
            return null;
        }
        public List<ErrorLogs> GetErrorLogs()
        {
            using (HPCOMMONEntities db = new HPCOMMONEntities())
            {
                //By Current Day
                var list = from a in db.ErrorLogs
                           join b in db.SCEmps on a.EmpCode equals b.EmpCode
                           where a.DocDate >= DateTime.UtcNow
                           //&& a.DocDate <= DateTime.Now
                           select a;
                var res = list.ToList();

                List<ErrorLogs> lstrrl = new List<ErrorLogs>();
                foreach (var lst in res)
                {
                    lstrrl.Add(new ErrorLogs
                    {
                        DocEntry = lst.DocEntry,
                        EmpCode = lst.EmpCode,
                        ErrMsg = lst.ErrMsg,
                        DocDate = lst.DocDate
                    });
                }
                return lstrrl;
            }

        }
        public bool CreateErroLog(string DocDate, string EmpCode, string WrkStation, string IPAdd, string Outlook, string ProgNameErr, string ProgVerErr, string ProgPath, string ErrMsgErr, string ErrSrc, string ErrDtls, string IssueID, string ErrCode)
        {
            using (HPCOMMONEntities db = new HPCOMMONEntities())
            {
                var adderrlog = new ErrorLog
                {
                    DocDate = Convert.ToDateTime(DocDate),
                    EmpCode = EmpCode,
                    WrkStation = WrkStation,
                    IPAdd = IPAdd,
                    Outlook = Outlook,
                    ProgName = ProgNameErr,
                    ProgVer = ProgVerErr,
                    ProgPath = ProgPath,
                    ErrMsg = ErrMsgErr,
                    ErrSrc = ErrSrc,
                    ErrDtls = ErrDtls,
                    IssueID = Convert.ToInt32(IssueID),
                    ErrCode = ErrCode
                };
                db.ErrorLogs.Add(adderrlog);
                db.SaveChanges();
            }

            return true;
        }
        public List<ErrorByIncharge> GetErrorCountByIncharge()
        {
            #region Entities Logic
            //using (HPCOMMONEntities db = new HPCOMMONEntities())
            //{
            //    //By Current Day
            //    var list = from a in db.ErrorLogs
            //               join b in db.Programs on a.ProgName equals b.Program1
            //               group b by b.InCharge into newGroup
            //               //&& a.DocDate <= DateTime.Now
            //               select newGroup;
            //    var res = list.ToList();

            //    List<ErrorByIncharge> lstrrl = new List<ErrorByIncharge>();
            //    foreach (var lst in res)
            //    {
            //        lstrrl.Add(new ErrorByIncharge
            //        {
            //            InCharge = lst.Key,
            //            IssueCount = lst.Count()
            //        });
            //    }
            //    return lstrrl;
            //}
            #endregion

            var model = new List<ErrorByIncharge>();

            using (SqlConnection cn = new SqlConnection(dbcon))
            {
                cn.Open();

                String query = "SELECT b.InCharge, COUNT(1) IssueCount, c.EmpCode, " +
                               "(SELECT EmpImg FROM EMPPic WHERE EmpCode = CAST(c.EmpCode AS varchar)) EmpImg " +
                               "FROM ErrorLog a " +
                               "LEFT JOIN Programs b on a.ProgName = b.Program " +
                               "LEFT JOIN developer c on c.EmpName = b.InCharge " +
                               "WHERE c.Designation ='" + Office.ZSquare + "' " +
                               "GROUP BY b.InCharge, c.EmpCode ";

                //cm.Parameters.AddWithValue("@Id", id);

                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        model.Add(new ErrorByIncharge
                        {
                            InCharge = Convert.ToString(dr["InCharge"]),
                            IssueCount = Convert.ToInt32(dr["IssueCount"]),
                            InChargeIMG = (byte[])dr["EmpImg"]
                        });
                    };
                    return model;
                }
                cn.Close();
            }
            return model;
        }
        public List<ErrorByProgram> GetErrorCountByProgram(string InCharge)
        {
            #region HPCOMMONEntities Query
            //using (HPCOMMONEntities db = new HPCOMMONEntities())
            //{

            //    var list = from a in db.ErrorLogs
            //               join b in db.Programs on a.ProgName equals b.Program1
            //               where b.InCharge == InCharge
            //               group a by a.ProgName  into newGroup
            //               //&& a.DocDate <= DateTime.Now
            //               select newGroup;
            //    var res = list.ToList();

            //    List<ErrorByProgram> lstrrl = new List<ErrorByProgram>();
            //    foreach (var lst in res)
            //    {
            //        lstrrl.Add(new ErrorByProgram
            //        {
            //            ProgramName = lst.Key,
            //            IssueCount = lst.Count()
            //        });
            //    }
            //    return lstrrl;
            //}
            #endregion

            var model = new List<ErrorByProgram>();

            using (SqlConnection cn = new SqlConnection(dbcon))
            {
                cn.Open();

                String query = "SELECT a.ProgName,COUNT(1) IssueCount " +
                               "FROM ErrorLog a " +
                               "LEFT JOIN Programs b on a.ProgName = b.Program " +
                               "WHERE b.InCharge='" + InCharge + "' " +
                               "GROUP BY a.ProgName ";

                //cm.Parameters.AddWithValue("@Id", id);

                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        model.Add(new ErrorByProgram
                        {
                            ProgramName = Convert.ToString(dr["ProgName"]),
                            IssueCount = Convert.ToInt32(dr["IssueCount"]),
                        });
                    };
                    return model;
                }
            }
            return model;
        }
        public List<ErrorLogs> GetErrorByProgram(string ProgramName)
        {
            #region Entities Logic
            //using (HPCOMMONEntities db = new HPCOMMONEntities())
            //{

            //    var list = from a in db.ErrorLogs
            //               join b in db.Programs on a.ProgName equals b.Program1
            //               where a.ProgName == ProgramName
            //               orderby a.DocDate
            //               //&& a.DocDate <= DateTime.Now
            //               select a;
            //    var res = list.ToList();

            //    List<ErrorLogs> lstrrl = new List<ErrorLogs>();
            //    foreach (var lst in res)
            //    {
            //        lstrrl.Add(new ErrorLogs
            //        {
            //            ErrCode = lst.ErrCode,
            //            ErrMsg = lst.ErrMsg,
            //            DocEntry = lst.DocEntry,
            //            DocDate = lst.DocDate

            //        });
            //    }
            //    return lstrrl;
            //}
            #endregion

            var model = new List<ErrorLogs>();

            using (SqlConnection cn = new SqlConnection(dbcon))
            {
                cn.Open();

                String query = "SELECT a.* " +
                               "FROM ErrorLog a " +
                               "LEFT JOIN Programs b on a.ProgName = b.Program " +
                               "WHERE a.ProgName='" + ProgramName + "' " +
                               "ORDER BY a.DocDate ";

                //cm.Parameters.AddWithValue("@Id", id);

                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        model.Add(new ErrorLogs
                        {
                            ErrCode = Convert.ToString(dr["ErrCode"]),
                            ErrMsg = Convert.ToString(dr["ErrMsg"]),
                            DocEntry = Convert.ToInt32(dr["DocEntry"]),
                            DocDate = Convert.ToDateTime(dr["DocDate"])
                        });
                    };
                    return model;
                }
            }
            return model;

        }
    }
}
