using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class SprintTasks
    {
        public int Id { get; set; }
        public int SprintId { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }
        public string AssignTo { get; set; }
        public decimal OriHr { get; set; }
        public decimal RemHr { get; set; }
        public decimal ComHr { get; set; }
        public int Status { get; set; }
        public int Priority { get; set; }
        public int Activity { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
