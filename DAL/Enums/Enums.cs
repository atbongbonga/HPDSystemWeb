using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Enums
{
    enum Office
    {
        ZSquare,
        DelMonte
    }
    enum SprintStatus
    {
        New = 1,
        Active = 2,
        Done = 3
    }
    enum TaskActvity
    {
        New = 1,
        Development = 2,
        Testing = 3,
        Deployment = 4
    }
    enum TaskType
    {
        Task = 0,
        Bug = 1
    }
    public enum Roles
    {
        User,
        Admin
    }
    public enum ConnState
    {
        Closed = 0,
        Open = 1
    }
    public enum Programs
    {
        All,
    }
}
