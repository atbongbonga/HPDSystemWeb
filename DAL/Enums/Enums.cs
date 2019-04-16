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
    enum TaskStatus
    {
        New = 1,
        Developing = 2,
        Testing = 3,
        Deployed = 4
    }
}
