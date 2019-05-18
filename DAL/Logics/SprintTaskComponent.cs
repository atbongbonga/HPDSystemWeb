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
                var addsprinttask = new SprintTask
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
                db.SprintTasks.Add(addsprinttask);
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
        public List<SprintTasks> GetSprintTask(int sprintId)
        {
            var model = new List<SprintTasks>();

            using (SqlConnection cn = new SqlConnection(dbcon))
            {
                cn.Open();

                String query = "SELECT * FROM dbo.SprintTasks WHERE SprintId = '" + sprintId + "' ";


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
        public bool CreateSprintCapacity(SprintCapacities SprintCapacity)
        {
            using (HPCOMMONEntities db = new HPCOMMONEntities())
            {
                var addsprintcapacity = new SprintCapacity
                {
                    SprintId = SprintCapacity.SprintId,
                    EmpCode = SprintCapacity.EmpCode,
                    Capacity = Convert.ToDecimal(SprintCapacity.Capacity)
                };
                db.SprintCapacities.Add(addsprintcapacity);
                db.SaveChanges();

            }
            return true;
        }
        #region GET SPRINT WORKING DAYS
        private bool CreateSprintDaysOff(SprintDaysOffs SprintDaysOff)
        {
            using (HPCOMMONEntities db = new HPCOMMONEntities())
            {
                var addsprintdaysoff = new SprintDaysOff
                {
                    SprintId = SprintDaysOff.SprintId,
                    EmpCode = SprintDaysOff.EmpCode,
                    StartDate = SprintDaysOff.StartDate,
                    EndDate = SprintDaysOff.EndDate
                };
                db.SprintDaysOffs.Add(addsprintdaysoff);
                db.SaveChanges();
            }
                return true;
        }
        private int GetWorkingDays(int sprintId)
        {
            int count = 0;
            int useddays = GetUsedWorkingDays(sprintId);
            using (HPCOMMONEntities db = new HPCOMMONEntities())
            {
                
                var getsprint = db.ProjectSprints.Select(i => i).Where(i => i.Id == sprintId).FirstOrDefault();
                DateTime sdate = Convert.ToDateTime(getsprint.StartDate);
                DateTime edate = Convert.ToDateTime(getsprint.EndDate);
                
                for (DateTime index = sdate; index < edate; index = index.AddDays(1))
                {
                    if (index.DayOfWeek != DayOfWeek.Sunday && index.DayOfWeek != DayOfWeek.Saturday)
                    {
                        count += 1;
                    }
                }   
            }
            return count - useddays;
        }
        private int GetUsedWorkingDays(int sprintId)
        {
            int count = 0;
            using (HPCOMMONEntities db = new HPCOMMONEntities())
            {

                var getsprint = db.ProjectSprints.Select(i => i).Where(i => i.Id == sprintId).FirstOrDefault();
                DateTime sdate = Convert.ToDateTime(getsprint.StartDate);
                DateTime edate = DateTime.UtcNow.Date;

                for (DateTime index = sdate; index < edate; index = index.AddDays(1))
                {
                    if (index.DayOfWeek != DayOfWeek.Sunday && index.DayOfWeek != DayOfWeek.Saturday)
                    {
                        count += 1;
                    }
                }  
            }
            return count;
        }
        #endregion

        #region TEAM WORK DETAILS
        public SprintWorkDetails TeamWorkDetails(int sprintId)
        {
            var model = new SprintWorkDetails();
            using (HPCOMMONEntities db = new HPCOMMONEntities())
            {
                model.TotalTeamWork = TotalTeamWork(sprintId);
                model.TotalTeamTaskWork = TotalTeamTaskWork(sprintId);
                return model;
            }

        }
        private decimal TotalTeamWork(int sprintId)
        {
            using (HPCOMMONEntities db = new HPCOMMONEntities())
            {
                var getsprint = db.ProjectSprints.Select(i => i).Where(i => i.Id == sprintId).FirstOrDefault();
                var getteamdaysoff = db.SprintDaysOffs.Select(i => i).Where(i => i.SprintId == sprintId && i.EmpCode == null).Count();
                int dowps = GetWorkingDays(sprintId) - getteamdaysoff;
                return Convert.ToDecimal(dowps * 9.6);
            }
            
        }
        private decimal TotalTeamTaskWork(int sprintId)
        {
            using (HPCOMMONEntities db = new HPCOMMONEntities())
            {
                var getsprintteamusedhr = db.SprintTasks.Where(i => i.SprintId == sprintId).Select(i => i.OriHr).Sum();
                return Convert.ToDecimal(getsprintteamusedhr);
            }
        }
        #endregion

        #region USER WORK DETAILS
        public List<SprintWorkDetails> UserWorkDetails(int sprintId)
        {
            var sprintmem = GetSprintMemberCapacity(sprintId);
            var model = new List<SprintWorkDetails>();
            if (sprintmem != null)
            {
                foreach (var data in sprintmem)
                {
                    model.Add(new SprintWorkDetails()
                    {
                        TotalUserWork = TotalUserWork(sprintId, data.EmpCode),
                        TotalUserTaskWork = TotalUserTaskWork(sprintId, data.EmpCode)
                    });

                }
                return model;
            }
            return model;
        }
        private decimal TotalUserWork(int sprintId, int empCode)
        {
            using (HPCOMMONEntities db = new HPCOMMONEntities())
            {
                var getsprint = db.ProjectSprints.Select(i => i).Where(i => i.Id == sprintId).FirstOrDefault();
                var getusercapacity = db.SprintCapacities.Select(i => i).Where(i => i.SprintId == sprintId && i.EmpCode == empCode).FirstOrDefault();
                var getuserdaysoff = db.SprintDaysOffs.Select(i => i).Where(i => i.SprintId == sprintId && i.EmpCode == empCode).Count();
                int dowps = GetWorkingDays(sprintId) - getuserdaysoff;
                return Convert.ToDecimal(dowps * getusercapacity.Capacity);
            }
        }
        private decimal TotalUserTaskWork(int sprintId, int empCode)
        {
            using (HPCOMMONEntities db = new HPCOMMONEntities())
            {
                var getsprintuserusedhr = db.SprintTasks.Where(i => i.SprintId == sprintId && i.AssignTo == empCode.ToString()).Select(i => i.OriHr).Sum();
                return Convert.ToDecimal(getsprintuserusedhr);
            }
        }
        #endregion


        public List<SprintMembers> GetSprintMemberCapacity(int sprintId)
        {
            var model = new List<SprintMembers>();
            var db = new HPCOMMONEntities();
            using (SqlConnection cn = new SqlConnection(dbcon))
            {
                cn.Open();
                String query = "SELECT a.EmpCode, a.EmpName, b.SprintId, b.Capacity FROM dbo.SCEmp a " +
                    "LEFT JOIN dbo.SprintCapacity b ON a.EmpCode = CAST(b.EmpCode AS VARCHAR) " +
                    "WHERE b.SprintId = "+ sprintId + " ";

                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var daysoff = new List<SprintDaysOff>();
                        int empcode = Convert.ToInt32(dr[0]);
                        daysoff = db.SprintDaysOffs.Select(i => i).Where(i => i.SprintId == sprintId && i.EmpCode == empcode).ToList();
                        model.Add(new SprintMembers
                        {
                            EmpCode = Convert.ToInt32(dr[0]),
                            EmpName = Convert.ToString(dr[1]),
                            SprintId = Convert.ToInt32(dr[2]),
                            Capacity = Convert.ToDecimal(dr[3]),
                            DaysOffCount = daysoff.Count(),
                            DaysOffList = daysoff
                        });

                    };
                }
                cn.Close();

                return model;
            }
        }
    }
}
