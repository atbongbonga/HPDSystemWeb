using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class SprintWorkDetails
    {
        public string EmpName { get; set; }
        public decimal TotalTeamWork { get; set; }
        public decimal TotalTeamTaskWork { get; set; }
        public decimal TotalUserWork { get; set; }
        public decimal TotalUserTaskWork { get; set; }
        public decimal TotalActivityWork { get; set; }
    }
}
