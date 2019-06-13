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
                    ErrCode = ErrCode,
                    Fixed = "N"
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

                String query = "SELECT a.InCharge, COUNT(b.DocEntry) IssueCount, c.EmpCode, (SELECT EmpImg FROM EMPPic WHERE EmpCode = CAST(c.EmpCode AS varchar)) EmpImg " +
                  "FROM Programs a " +
                  "LEFT JOIN ErrorLog b on a.Program = b.ProgName AND b.Fixed = 'N' " +
                  "LEFT JOIN developer c on a.InCharge = c.EmpName " +
                  "WHERE c.Designation = '" + Enums.Office.ZSquare + "' GROUP BY a.InCharge, c.EmpCode ";

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
                #region OLD QUERY  
                //String query = "SELECT a.Program, COUNT(b.DocEntry) IssueCount " +
                //    "FROM Programs a " +
                //    "LEFT JOIN ErrorLog b on a.Program = b.ProgName AND b.fixed = 'N' " +
                //    "WHERE a.InCharge='" + InCharge + "' AND a.Active=1 " +
                //    "GROUP BY a.Program";

                //String query = "SELECT a.Program, COUNT(b.DocEntry) IssueCount " +
                //    "FROM dbo.Programs a " +
                //    "LEFT JOIN dbo.ErrorLog b ON a.Program = b.ProgName AND b.Fixed = 'N' AND b.ErrCode NOT IN(SELECT ErrCode FROM dbo.ErrorException) " +
                //    "WHERE a.InCharge='" + InCharge + "' AND a.Active=1 " +
                //    "GROUP BY a.Program ";

                #endregion

                String query = "SELECT a.Program, COUNT(a.Cnt) IssueCount " +
                    "FROM(SELECT a.Program, b.ErrCode, b.ErrMsg, SUM(b.DocEntry) Cnt " +
                    "FROM dbo.Programs a " +
                    "LEFT JOIN dbo.ErrorLog b on a.Program = b.ProgName AND b.Fixed = 'N' " +
                    "AND b.ErrCode NOT IN(SELECT ErrCode FROM dbo.ErrorException) " +
                    "WHERE a.InCharge='" + InCharge + "' AND a.Active = 1 " +
                    "GROUP BY a.Program, b.ErrCode, b.ErrMsg) a " +
                    "GROUP BY a.Program ";

                //cm.Parameters.AddWithValue("@Id", id);

                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        model.Add(new ErrorByProgram
                        {
                            ProgramName = Convert.ToString(dr["Program"]),
                            IssueCount = Convert.ToInt32(dr["IssueCount"]),
                        });
                    };
                    return model;
                }
                cn.Close();
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

                #region OLD Query


                //String query = "SELECT a.* " +
                //               "FROM ErrorLog a " +
                //               "LEFT JOIN Programs b on a.ProgName = b.Program " +
                //               "WHERE a.Fixed='" + "N" + "' AND a.ProgName='" + ProgramName + "' " +
                //               "ORDER BY a.DocDate DESC ";

                //String query = "SELECT a.* " +
                //    "FROM ErrorLog a " +
                //    "LEFT JOIN Programs b on a.ProgName = b.Program " +
                //    "WHERE a.Fixed = 'N' AND  a.ProgName='" + ProgramName + "' AND a.ErrCode NOT IN(SELECT ErrCode FROM dbo.ErrorException) " +
                //    "ORDER BY a.DocDate DESC ";
                #endregion

                String query = "SELECT a.ErrCode, a.ErrMsg, a.DocEntry, a.DocDate " +
                    "FROM(SELECT a.ErrCode, a.ErrMsg, a.ProgName, MAX(a.DocEntry) DocEntry, CAST(MAX(a.DocDate) AS VARCHAR) DocDate " +
                    "FROM ErrorLog a " +
                    "LEFT JOIN Programs b on a.ProgName = b.Program " +
                    "WHERE a.Fixed = 'N' AND a.ErrCode NOT IN(SELECT ErrCode FROM dbo.ErrorException) " +
                    "GROUP BY a.ErrCode, a.ErrMsg, a.ProgName) a " +
                    "WHERE a.ProgName='" + ProgramName + "' ";

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

                    return model.ToList();
                }
                cn.Close();

            }

            return model.ToList();

        }

        public ErrorLogs GetErrorByDocEntry(string DocEntry)
        {

            var model = new ErrorLogs();

            using (SqlConnection cn = new SqlConnection(dbcon))
            {
                cn.Open();

                String query = "SELECT a.* " +
                    "FROM ErrorLog a " +
                    "LEFT JOIN Programs b on a.ProgName = b.Program " +
                    "WHERE a.Fixed = 'N' AND  a.DocEntry='" + DocEntry + "' AND a.ErrCode NOT IN(SELECT ErrCode FROM dbo.ErrorException) " +
                    "ORDER BY a.DocDate DESC ";

                //cm.Parameters.AddWithValue("@Id", id);

                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    model = new ErrorLogs
                        {
                            ErrCode = Convert.ToString(dr["ErrCode"]),
                            ErrMsg = Convert.ToString(dr["ErrMsg"]),
                            DocEntry = Convert.ToInt32(dr["DocEntry"]),
                            ErrDtls = Convert.ToString(dr["ErrDtls"]),
                            DocDate = Convert.ToDateTime(dr["DocDate"])
                        };
                    return model;
                }
                cn.Close();

            }

            return model;
        }

        public string GetErrorSolution(string ErrorCode)
        {
            using (HPCOMMONEntities db = new HPCOMMONEntities())
            {
                var geterrorsol = db.ErrorSols.Where(i => i.ErrCode == ErrorCode).FirstOrDefault();
                if (geterrorsol != null)
                {
                    return geterrorsol.ErrSol;
                }
                return null;
            }
        }

        public bool FixProgramBug(string ErrorCode, string Program)
        {
            using (HPCOMMONEntities db = new HPCOMMONEntities())
            {
                var geterrorsol = db.ErrorLogs.Where(i => i.ErrCode == ErrorCode && i.ProgName == Program).FirstOrDefault();
                if (geterrorsol != null)
                {
                    geterrorsol.Fixed = "Y";
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public bool CreateUpdateErrorSolution(string ErrorCode, string ErrorSol)
        {
            using (HPCOMMONEntities db = new HPCOMMONEntities())
            {
                var geterrorsol = db.ErrorSols.Where(i => i.ErrCode == ErrorCode).FirstOrDefault();
                if (geterrorsol == null)
                {
                    var errorsol = new ErrorSol()
                    {
                        ErrCode = ErrorCode,
                        ErrSol = ErrorSol
                    };
                    db.ErrorSols.Add(errorsol);
                    db.SaveChanges();
                }
                else
                {
                    geterrorsol.ErrSol = ErrorSol;
                    db.SaveChanges();
                }
            }
            return true;
        }

        public bool AddBugToErrorException(string ErrorCode, string ErrorDesc)
        {
            using (HPCOMMONEntities db = new HPCOMMONEntities())
            {
                var checkeerrex = db.ErrorExceptions.Where(i => i.ErrCode == ErrorCode).FirstOrDefault();
                if (checkeerrex == null)
                {
                    var errorexception = new ErrorException()
                    {
                        ErrCode = ErrorCode,
                        Dscrpt = ErrorDesc
                    };
                    db.ErrorExceptions.Add(errorexception);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }

        } 
    }
}
