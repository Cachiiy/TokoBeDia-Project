using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Factory;
using TokoBeDia.Model;

namespace TokoBeDia.Repository
{
    public class UserRepository
    {
        static TokoBeDiaContainer db = new TokoBeDiaContainer();

        public static Boolean newUser(
            int roleID,
            string userName,
            string userEmail,
            string userPassword,
            string userGender,
            string userStatus)
        {
            User user = UserFactory.CreateUser(roleID, userName, userEmail, userPassword, userGender, userStatus);
            db.Users.Add(user);
            db.SaveChanges();

            return true;
        }

        public static List<User> getUser()
        {
            return db.Users.ToList();
        }

        public static User checkUser(
            string userEmail,
            string userPassword)
        {
            User userX = (from user in db.Users
                          where user.userEmail == userEmail && user.userPassword == userPassword
                          select user).FirstOrDefault();
            if (userX != null)
            {
                if (userX.userStatus.ToString() == "Active")
                {
                    return userX;
                }
                else
                {
                    return null;
                }
            }
            else return null;
           
        }



        public static User checkExistUser(
            string userEmail)
        {
            User userX = (from user in db.Users
                          where user.userEmail == userEmail
                          select user).FirstOrDefault();

            return userX;
        }

        public static User checkExistUserId(
            int ID)
        {
            User userX = (from user in db.Users
                          where user.userID == ID
                          select user).FirstOrDefault();

            return userX;
        }

        public static Boolean updateUser(int userID, string userEmail, string userName, string userGender)
        {
            User user = db.Users.Where(x => x.userID == userID).FirstOrDefault();

            user.userName = userName;
            user.userEmail = userEmail;
            user.userGender = userGender;

            db.SaveChanges();

            return true;
        }

        public static Boolean updateUserA(int userID, string RoleID, string userStatus)
        {
            User user = db.Users.Where(x => x.userID == userID).FirstOrDefault();

            if(RoleID == "Administrator")
            {
                user.RoleID = 1;
            } else
            {
                user.RoleID = 2;
            }
            user.userStatus = userStatus;

            db.SaveChanges();

            return true;
        }

        public static Boolean updatePassword(int userID, string newPassword)
        {
            User user = db.Users.Where(x => x.userID == userID).FirstOrDefault();

            user.userPassword = newPassword;

            db.SaveChanges();

            return true;
        }
    }
}