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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userid"] != null)
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void LoginUser(object sender, EventArgs e)
        {
            string userid = "";
            string username = "";
            string useremail = "";
            string userrole = "";
            string email = inputEmail.Value;
            string password = inputPassword.Value;

            Boolean userReady = AuthController.checkUser(email, password, out userid, out username, out useremail, out userrole);

            if (!userReady)
            {
                errorMsg.Text = "Email/Password Salah";
                errorMsg.Style.Add("visibility", "visible");
                errorMsg.Style.Add("color", "red");
            }
            else
            {
                Session["userid"] = userid;
                Session["username"] = username;
                Session["useremail"] = useremail;
                Session["userrole"] = userrole;

                errorMsg.Style.Add("visibility", "hidden");

                if (checkRemember.Checked)
                {
                    createCookie("userid", userid);
                }
                Response.Redirect("Home.aspx");
            }
        }

        protected void createCookie(string cookieName, string cookieValue)
        {
            HttpCookie cookie = new HttpCookie(cookieName, cookieValue);
            cookie.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(cookie);
        }
    }
}