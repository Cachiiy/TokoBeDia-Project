using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Model;

namespace TokoBeDia.Factory
{
    public class RoleFactory
    {
        public static Role CreateRoles(
            int roleID,
            string roleName)
        {
            Role role = new Role();
            role.roleID = roleID;
            role.roleName = roleName;

            return role;
        }
    }
}