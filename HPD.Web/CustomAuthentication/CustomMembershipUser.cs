using System;
using DAL.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace HPD.Web.CustomAuthentication
{
    public class CustomMembershipUser : MembershipUser
    {
        #region User Properties

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        //public ICollection<Role> Roles { get; set; }

        #endregion

        public CustomMembershipUser(Users user):base("CustomMembership", user.Username, user.UserId, user.Email, string.Empty, string.Empty, true, false, DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now)
        {
            UserId = user.UserId;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Role = user.Role;
        }
    }
}