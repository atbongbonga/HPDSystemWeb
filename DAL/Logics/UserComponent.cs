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


        public List<Users> ValidateAccount()
        {
            var model = new List<Users>();
            using (SqlConnection cn = new SqlConnection(dbcon))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("UserLogin", cn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = "bong";
                cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = "nllnlf41514";
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    model.Add(new Users
                    {
                        UserId = Convert.ToInt32(dr["UserID"]),
                        Username = Convert.ToString(dr["UserName"]),
                        FirstName = Convert.ToString(dr["EmpName"]),
                        LastName = Convert.ToString(dr["EmpName"]),
                        Email = Convert.ToString(dr["EmpName"]),
                        Role = "User"
                    });

                    return model;
                }
                return null;
                cn.Close();
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
