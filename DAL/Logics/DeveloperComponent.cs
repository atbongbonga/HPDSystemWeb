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
    public class DeveloperComponent
    {
        String dbcon = ConfigurationManager.ConnectionStrings["STAGHPCOMMON"].ConnectionString;

        public List<Developers> GetDevelopers()
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

            var model = new List<Developers>();

            using (SqlConnection cn = new SqlConnection(dbcon))
            {
                cn.Open();

                String query = "SELECT a.EmpCode, a.EmpName, a.Designation, b.EmpImg " +
                               "FROM developer a " +
                               "LEFT JOIN EMPPic b on b.EmpCode = CAST(a.EmpCode AS varchar) " +
                               "WHERE a.Designation ='" + Office.ZSquare + "' ";

                //cm.Parameters.AddWithValue("@Id", id);

                SqlCommand cmd = new SqlCommand(query, cn);
               SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        model.Add(new Developers
                        {
                            EmpCode = Convert.ToString(dr["EmpCode"]),
                            EmpName = Convert.ToString(dr["EmpName"]),
                            Designation = Convert.ToString(dr["Designation"]),
                            EmpIMG = (byte[])dr["EmpImg"]
                        });
                    };
                    return model;
                }
                cn.Close();
            }
            return model;
        }

        public List<Developers> GetSprintDeveloper(int sprintId)
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
            var model = new List<Developers>();

            using (HPCOMMONEntities db = new HPCOMMONEntities())
            {
                var getsprint = db.ProjectSprints.Where(i => i.Id.Equals(sprintId)).Select(i => i.Member).FirstOrDefault();
                if (getsprint.Count() !=0)
                {
                    String[] members = getsprint.ToString().Split(Convert.ToChar(","));
                    foreach (var empcode in members)
                    {
                        using (SqlConnection cn = new SqlConnection(dbcon))
                        {
                            cn.Open();

                            String query = "SELECT a.EmpCode, a.EmpName, a.Designation, b.EmpImg " +
                                           "FROM developer a " +
                                           "LEFT JOIN EMPPic b on b.EmpCode = CAST(a.EmpCode AS varchar) " +
                                           "WHERE a.EmpCode ='" + empcode + "' ";

                            SqlCommand cmd = new SqlCommand(query, cn);
                            SqlDataReader dr = cmd.ExecuteReader();

                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    model.Add(new Developers
                                    {
                                        EmpCode = Convert.ToString(dr["EmpCode"]),
                                        EmpName = Convert.ToString(dr["EmpName"]),
                                        Designation = Convert.ToString(dr["Designation"]),
                                        EmpIMG = (byte[])dr["EmpImg"]
                                    });
                                };
                            }
                            cn.Close();
                        }
                    }
                    return model;
                }
                
            }
            return model;
        }
    }
}
