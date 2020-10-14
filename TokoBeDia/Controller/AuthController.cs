using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Handler;
using TokoBeDia.Model;

namespace TokoBeDia.Controller
{
    public class AuthController
    {
        public static Boolean checkUser(string email, string password, out string userid, out string username, out string useremail, out string userrole)
        {
            User user = ItemAuthHandler.checkUser(email, password);
            userid = user.userID.ToString();
            username = user.userName.ToString();
            useremail = user.userEmail.ToString();
            int roleId = user.RoleID.Value;

            Role role = ItemAuthHandler.getRoleUser(roleId);
            userrole = role.roleName.ToString();

            if (user != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Boolean checkExistUser(string username)
        {
            User user = ItemAuthHandler.checkExistUser(username);

            if (user != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Boolean checkExistUserId(int id, out string userPassword)
        {
            User curr = ItemAuthHandler.checkExistUserId(id);
            userPassword = curr.userPassword.ToString();

            if (curr != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Boolean checkProduct(int id)
        {
            Product product = ItemAuthHandler.checkProduct(id);

            if (product != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Boolean checkProductType(int id)
        {
            ProductType producttype = ItemAuthHandler.checkProductType(id);

            if (producttype != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Boolean checkProductTypeOnProduct(int id)
        {
            Product product = ItemAuthHandler.checkProductTypeOnProduct(id);

            if (product != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Boolean checkExistUserId2(int id, out string userEmail, out string userName, out string userGender)
        {
            User curr = ItemAuthHandler.checkExistUserId(id);
            userEmail = curr.userEmail.ToString();
            userName = curr.userName.ToString();
            userGender = curr.userGender.ToString();

            if (curr != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

 
        //start here -andre-
        public static Boolean checkPaymentType(string typeName)
        {
            PaymentType pt = ItemAuthHandler.checkExistPaymentType(typeName);

            if (pt != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Boolean checkPaymentTypeId(int id)
        {
            PaymentType pt = ItemAuthHandler.checkExistPaymentTypeId(id);

            if (pt != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
            
    }
}