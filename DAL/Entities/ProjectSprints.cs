using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ProjectSprints : SprintDetails
    {
        public int Id { get; set; }
        public string ProgramName { get; set; }
        public string Title { get; set; }
        public string Member { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string BP { get; set; }
        public int Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set;  }
        public bool IsBP { get; set; }
        public DateTime? DoneDate { get; set; }
    }
    public class SprintDetails
    {
        public int BugCount { get; set; }
        public int TaskCount { get; set; }
    }
}
