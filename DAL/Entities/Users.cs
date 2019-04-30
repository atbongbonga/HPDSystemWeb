using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Users
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] ProfileImg { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
    public class UserDetails : Users
    {
        public string EmpCode { get; set; }

        

    }
}
