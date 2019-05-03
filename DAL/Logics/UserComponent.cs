using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using DAL.Entities;
using DAL.Enums;
using DAL.Models;
using System.Data;

namespace DAL.Logics
{
    public class UserComponent
    {
        String dbcon = ConfigurationManager.ConnectionStrings["STAGHPCOMMON"].ConnectionString;


        public Users GetUserDetails(string EmpCode)
        {

            using (SqlConnection cn = new SqlConnection(dbcon))
            {
                cn.Open();


                String query = "SELECT a.EmpCode, a.EmpName, a.LName, a.FName, a.MName, b.EmpImg, c.UserRole, d.EmpName AS Name " +
                                          "FROM SCEmp a " +
                                          "LEFT JOIN EMPPic b on b.EmpCode = CAST(a.EmpCode AS varchar) " +
                                          "LEFT JOIN Users2 c on c.UserID = CAST(a.EmpCode AS varchar) " +
                                          "LEFT JOIN developer d on d.EmpCode = CAST(a.EmpCode AS varchar) " +
                                          "WHERE a.EmpCode ='" + EmpCode + "' ";

                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    var model = (new Users
                    {
                        UserId = Convert.ToInt32(dr["EmpCode"]),
                        FirstName = Convert.ToString(dr["Name"]),
                        LastName = Convert.ToString(dr["LName"]),
                        ProfileImg = (byte[])(dr["EmpImg"]),
                        Role = Convert.ToString(dr["UserRole"]),
                    });

                    return model;
                }
                cn.Close();
                return null;
               
            }
        }


        public bool ValidateAccount(string username, string password)
        {
            using (SqlConnection cn = new SqlConnection(dbcon))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("UserLogin", cn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = username;
                cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    var model = (new Users
                    {
                        UserId = Convert.ToInt32(dr["UserID"]),
                        Username = Convert.ToString(dr["UserName"]),
                        FirstName = Convert.ToString(dr["EmpName"]),
                        LastName = Convert.ToString(dr["EmpName"]),
                        Email = Convert.ToString(dr["EmpName"]),
                        Role = "User"
                    });

                    if (model != null) { return true; } return false;
                }
                cn.Close();
                return false;
            }
        }
    }
}
