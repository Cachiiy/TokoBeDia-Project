using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Controller;
using TokoBeDia.Handler;
using TokoBeDia.Model;
using TokoBeDia.Repository;

namespace TokoBeDia.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userid"] != null)
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void RegisterUser(object sender, EventArgs e)
        {
            int roleID = 2;
            string userName = inputName.Value;
            string userEmail = inputEmail.Value;
            string userPassword = inputPassword.Value;
            string confirmPassword = inputCPassword.Value;
            string userGender = selectGender.Value;
            string userStatus = "Active";

            Boolean userReady = AuthController.checkExistUser(userName);
            Boolean boolEmail = (userEmail != null) ? true : false;
            Boolean boolPass = (userPassword == confirmPassword) ? true : false;

            if (userReady == false && boolEmail == true && boolPass == true)
            {
                CrudController.newUser(roleID, userName, userEmail, userPassword, userGender, userStatus);
                Response.Redirect("Login.aspx");
            }
            else if (boolPass == false)
            {
                errorMsg.Text = "Password tidak sama";
                errorMsg.Style.Add("visibility", "visible");
                errorMsg.Style.Add("color", "red");
            }
            else
            {
                errorMsg.Text = "Email sudah dipakai";
                errorMsg.Style.Add("visibility", "visible");
                errorMsg.Style.Add("color", "red");
            }

        }
    }
}