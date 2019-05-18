using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
namespace DAL.Entities
{
    public class SprintCapacities
    {
        public int Id { get; set; }
        public int SprintId { get; set; }
        public int EmpCode { get; set; }
        public decimal Capacity { get; set; }
    }
    public class SprintMembers : SprintCapacities
    {
        public string EmpName { get; set; }
        public int DaysOffCount { get; set; }
        public List<SprintDaysOff> DaysOffList {get; set;}
    }

}
