using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Model;

namespace TokoBeDia.Repository
{
    public class RoleRepository
    {
        static TokoBeDiaContainer db = new TokoBeDiaContainer();
        public static Role getRoleUser(
            int roleID)
        {
            Role roleX = (from role in db.Roles
                          where role.roleID == roleID
                          select role).FirstOrDefault();

            return roleX;
        }
    }
}