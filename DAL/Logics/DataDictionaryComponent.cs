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
    public class DataDictionaryComponent
    {
        public bool ServerLogin(string servername, string username, string password)
        {
            String connstr = "Server=" + servername + ";Database=Master;Integrated Security=False;UID=" + username + ";PWD=" + password + "";
            using (SqlConnection cn = new SqlConnection(connstr))
            {
                try
                {
                    cn.Open();
                    cn.Close();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }

        public List<DataDictionary> GetServerDatabaseList(string servername, string username, string password)
        {
            String connstr = "Server=" + servername + ";Database=Master;Integrated Security=False;UID=" + username + ";PWD=" + password + "";
            var model = new List<DataDictionary>();
            using (SqlConnection cn = new SqlConnection(connstr))
            {
                cn.Open();
                String query = "SELECT NAME FROM SYS.DATABASES ORDER BY NAME";

                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        model.Add(new DataDictionary
                        {
                            DatabaseName = Convert.ToString(dr[0])
                        });
                    };
                    return model;
                }
                cn.Close();
            }
            return model;
        }

        public List<DataDictionary> GetDatabaseTableList(string servername, string dbname, string username, string password)
        {
            String connstr = "Server=" + servername + ";Database=" + dbname + ";Integrated Security=False;UID=" + username + ";PWD=" + password + "";
            var model = new List<DataDictionary>();
            using (SqlConnection cn = new SqlConnection(connstr))
            {
                cn.Open();
                String query = "SELECT NAME FROM SYS.OBJECTS WHERE TYPE_DESC = 'USER_TABLE' ORDER BY NAME";

                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        model.Add(new DataDictionary
                        {
                            TableName = Convert.ToString(dr[0])
                        });
                    };
                    return model;
                }
                cn.Close();
            }
            return model;
        }

        public List<DataDictionary> GetTableProperty(string servername, string dbname, string tblname, string username, string password)
        {
            String connstr = "Server=" + servername + ";Database=" + dbname + ";Integrated Security=False;UID=" + username + ";PWD=" + password + "";
            var model = new List<DataDictionary>();
            using (SqlConnection cn = new SqlConnection(connstr))
            {
                cn.Open();
                String query = "SELECT sc.Column_ID Ln, sc.name [Column], t.Name [DataType], sc.max_length [MaxLength], sep.value [Description] " +
                  "FROM SYS.tables st " +
                  "INNER JOIN SYS.columns sc on st.object_id = sc.object_id " +
                  "INNER JOIN SYS.types t ON sc.user_type_id = t.user_type_id " +
                  "LEFT JOIN SYS.extended_properties sep on st.object_id = sep.major_id and " +
                  "sc.column_id = sep.minor_id " +
                  "WHERE st.name = '" + tblname + "' " +
                  "ORDER BY sc.Column_ID ";

                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        model.Add(new DataDictionary
                        {
                            ColumnName = Convert.ToString(dr["Column"]),
                            DataType = Convert.ToString(dr["DataType"]),
                            Description = Convert.ToString(dr["Description"])
                        });
                    };
                    return model;
                }
                cn.Close();
            }
            return model;
        }

        public bool SaveExtendedProperty(string servername, string dbname, string tblname, string username, string password, string colname, string coldesc)
        {
            String connstr = "Server=" + servername + ";Database=" + dbname + ";Integrated Security=False;UID=" + username + ";PWD=" + password + "";
            var model = new List<DataDictionary>();
            using (SqlConnection cn = new SqlConnection(connstr))
            {
                cn.Open();
                String query = "SELECT TOP 1 1 FROM sys.extended_properties a INNER JOIN sys.tables b ON a.major_id = a.major_id WHERE b.name = '" + tblname +  "' And a.name ='" + colname + "' ";
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    dr.Close();
                    String qry = "EXEC sp_updateextendedproperty " +
                          "@name = N'" + colname + "', @value = '" + coldesc + "', " +
                          "@level0type=N'SCHEMA', @level0name=N'dbo', " +
                          "@level1type=N'TABLE', @level1name=N'" + tblname + "',  " +
                          "@level2type=N'COLUMN', @level2name=N'" + colname + "' ";
                    cmd = new SqlCommand(qry, cn);
                    dr = cmd.ExecuteReader();
                    return true;
                }
                else
                {
                    dr.Close();
                    String qry = "EXEC sp_addextendedproperty " +
                          "@name = N'" + colname + "', @value = '" + coldesc + "', " +
                          "@level0type=N'SCHEMA', @level0name=N'dbo', " +
                          "@level1type=N'TABLE', @level1name=N'" + tblname + "',  " +
                          "@level2type=N'COLUMN', @level2name=N'" + colname + "' ";
                    cmd = new SqlCommand(qry, cn);
                    dr = cmd.ExecuteReader();
                    return true;
                }
                   
                cn.Close();
            }
        }
        public DataDictionaryInfo GetDatabaseInformation(string servername, string dbname, string tblname, string username, string password)
        {
            String connstr = "Server=" + servername + ";Database=" + dbname + ";Integrated Security=False;UID=" + username + ";PWD=" + password + "";
            var model = new DataDictionaryInfo();
            using (SqlConnection cn = new SqlConnection(connstr))
            {
                cn.Open();
                String query = "with fs as (SELECT * FROM sys.master_files) " +
                    "SELECT(SELECT Name)DatabaseName, " +
                    "(SELECT CAST(SUM((size * 8) / 1024) AS VARCHAR) FROM fs WHERE TYPE = 0 and fs.database_id = db.database_id) DataFileSizeMB, " +
                    "(SELECT CAST(SUM((size * 8) / 1024) AS VARCHAR) FROM fs WHERE TYPE = 1 and fs.database_id = db.database_id) LogFileSizeMB, " +
                    "(SELECT CAST(COUNT(*)AS VARCHAR) FROM sys.tables ) TotalTableCount, " +
                    "(SELECT CAST(COUNT(*)AS VARCHAR) FROM dbo."+ tblname +") TotalTableDataCount " +
                    "FROM sys.databases db WHERE db.name = '" + dbname + "' ";

                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        model.LogicalName = Convert.ToString(dr[0]);
                        model.DataFileSize = Convert.ToString(dr[1]);
                        model.LogFileSize = Convert.ToString(dr[2]);
                        model.DatabaseTableCount = Convert.ToString(dr[3]);
                        model.TableName = Convert.ToString(tblname);
                        model.TableDataCount = Convert.ToString(dr[4]);
                    }
                }
                return model;
            }
        }
        
    }
}
