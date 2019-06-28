using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class DataDictionary
    {
        public string DatabaseName { get; set; }
        public string Description { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string DataType { get; set; }
        public string MaxLenght { get; set; }
    }
    public class DataDictionaryInfo
    {
        public string LogicalName { get; set; }
        public string DataFileSize { get; set; }
        public string LogFileSize { get; set; }
        public string DatabaseTableCount { get; set; }
        public string DataDictionaryCount { get; set; }
        public string TableName { get; set; }
        public string TableDesc { get; set; }
        public string TableDataCount { get; set; }
    }
    public class DatabaseUsageInfo
    {
        public string DataFileSize { get; set; }
        public string LogFileSize { get; set; }
    }
}
