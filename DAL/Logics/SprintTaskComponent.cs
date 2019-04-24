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
            var db = new HPCOMMONEntities();

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
                        int sid = Convert.ToInt32(dr["Id"]);
                        var sprinttaskcount = db.SprintTasks.Where(i => i.SprintId == sid && i.Type == (int)Enums.TaskType.Task).Count();
                        var sprintbugcount = db.SprintTasks.Where(i => i.SprintId == sid && i.Type == (int)Enums.TaskType.Bug).Count();
                        model.Add(new ProjectSprints
                        {
                           Id = Convert.ToInt32(dr["Id"]),
                           Title = Convert.ToString(dr["Title"]),
                           TaskCount = sprinttaskcount,
                           BugCount = sprintbugcount
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


        public bool CreateSrintTask(SprintTasks SprintTask)
        {
            using (HPCOMMONEntities db = new HPCOMMONEntities())
            {
                var setting = new Settings();
                var addprinttask = new SprintTask
                {
                    SprintId = SprintTask.SprintId,
                    Title = SprintTask.Title,
                    Type = SprintTask.Type,
                    Description = SprintTask.Description,
                    AssignTo = SprintTask.AssignTo,
                    OriHr = SprintTask.OriHr,
                    RemHr = SprintTask.RemHr,
                    ComHr = SprintTask.ComHr,
                    Status = Convert.ToInt32(Enums.TaskActvity.New),
                    Priority = SprintTask.Priority,
                    Activity = SprintTask.Activity,
                    CreatedBy = setting.UserIP,
                    CreatedDate = DateTime.UtcNow
                };
                db.SprintTasks.Add(addprinttask);
                db.SaveChanges();

            }
            return true;
        }

        public bool UpdateSprintTask(SprintTasks SprintTask)
        {
            using (HPCOMMONEntities db = new HPCOMMONEntities())
            {
                var gettask = db.SprintTasks.SingleOrDefault(i => i.Id == SprintTask.Id);
                if (gettask != null)
                {
                    gettask.SprintId = SprintTask.SprintId;
                    gettask.Title = SprintTask.Title;
                    gettask.Type = SprintTask.Type;
                    gettask.Description = SprintTask.Description;
                    gettask.AssignTo = SprintTask.AssignTo;
                    gettask.OriHr = SprintTask.OriHr;
                    gettask.RemHr = SprintTask.RemHr;
                    gettask.ComHr = SprintTask.ComHr;
                    gettask.Status = SprintTask.Status;
                    gettask.Priority = SprintTask.Priority;
                    gettask.Activity = SprintTask.Activity;
                    db.SaveChanges();
                }

            }
            return true;
        }

        public bool UpdateSrintTaskActivity(int taskId, int act)
        {
            using (HPCOMMONEntities db = new HPCOMMONEntities())
            {
                var gettask = db.SprintTasks.SingleOrDefault(i => i.Id == taskId);
                if (gettask != null)
                {
                    gettask.Activity = act;
                    db.SaveChanges();
                }

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
                            Type = Convert.ToInt32(dr["Type"]),
                            Status = Convert.ToInt32(dr["Status"]),
                            Activity = Convert.ToInt32(dr["Activity"])
                        });
                    };
                    return model;
                }
                cn.Close();
            }
            return model;

        }

        public SprintTasks GetTaskDetails(int taskId)
        {
            var model = new SprintTasks();

            using (SqlConnection cn = new SqlConnection(dbcon))
            {
                cn.Open();

                String query = "SELECT * FROM dbo.SprintTasks WHERE Id = '" + taskId + "' ";


                //cm.Parameters.AddWithValue("@Id", id);

                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        model.Id = Convert.ToInt32(dr["Id"]);
                        model.SprintId = Convert.ToInt32(dr["SprintId"]);
                        model.Title = Convert.ToString(dr["Title"]);
                        model.Type = Convert.ToInt32(dr["Type"]);
                        model.Description = Convert.ToString(dr["Description"]);
                        model.AssignTo = Convert.ToString(dr["AssignTo"]);
                        model.OriHr = Convert.ToDecimal(dr["OriHr"]);
                        model.RemHr = Convert.ToDecimal(dr["RemHr"]);
                        model.ComHr = Convert.ToDecimal(dr["ComHr"]);
                        model.Status = Convert.ToInt32(dr["Status"]);
                        model.Priority = Convert.ToInt32(dr["Priority"]);
                        model.Activity = Convert.ToInt32(dr["Activity"]);
                        model.CreatedBy = Convert.ToString(dr["CreatedBy"]);
                        model.CreatedDate = Convert.ToDateTime(dr["CreatedDate"]);
                    }
                }
                cn.Close();
            }
            return model;

        }
    }
}
