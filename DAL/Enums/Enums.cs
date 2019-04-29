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
    enum SprintType
    {
        New = 1,
        Expired = 2,
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
    enum Roles
    {
        User,
        Admin
    }
}
