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
    public class SprintTaskComponent
    {
        String dbcon = ConfigurationManager.ConnectionStrings["STAGHPCOMMON"].ConnectionString;
        public List<ProjectSprints> GetProjectSprintList(string ProgramName)
        {
            var model = new List<ProjectSprints>();

            using (SqlConnection cn = new SqlConnection(dbcon))
            {
                cn.Open();

                String query = "SELECT * FROM dbo.ProjectSprints WHERE ProgramName = '" + ProgramName + "' ";


                //cm.Parameters.AddWithValue("@Id", id);

                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        model.Add(new ProjectSprints
                        {
                           Id = Convert.ToInt32(dr["Id"]),
                           Title = Convert.ToString(dr["Title"])
                        });
                    };
                    return model;
                }
                cn.Close();
            }
            return model;
        }

        public bool CreateProjectSprint(ProjectSprints ProjSprint)
        {
            using (HPCOMMONEntities db = new HPCOMMONEntities())
            {
                var setting = new Settings();
                var addprosprint = new ProjectSprint
                {
                    Title = ProjSprint.Title,
                    ProgramName = ProjSprint.ProgramName,
                    Member = ProjSprint.Member,
                    StartDate = ProjSprint.StartDate,
                    EndDate = ProjSprint.EndDate,
                    BP = ProjSprint.BP,
                    Status = Convert.ToInt32(Enums.SprintType.New),
                    CreatedBy = setting.UserIP,
                    CreatedDate = DateTime.UtcNow
                };
                db.ProjectSprints.Add(addprosprint);
                db.SaveChanges();

            }
            return true;
        }

        public List<SprintTasks> GetSprintTask(int SprintId)
        {
            var model = new List<SprintTasks>();

            using (SqlConnection cn = new SqlConnection(dbcon))
            {
                cn.Open();

                String query = "SELECT * FROM dbo.SprintTasks WHERE SprintId = '" + SprintId + "' ";


                //cm.Parameters.AddWithValue("@Id", id);

                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        model.Add(new SprintTasks
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            Title = Convert.ToString(dr["Title"]),
                            Status = Convert.ToInt32(dr["Status"])
                        });
                    };
                    return model;
                }
                cn.Close();
            }
            return model;

        }
    }
}
