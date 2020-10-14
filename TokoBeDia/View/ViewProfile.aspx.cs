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
    public partial class ViewProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["userid"] == null)
            {
                Response.Redirect("Home.aspx");
            } else
            {
                string userEmail = "";
                string userName = "";
                string userGender = "";
                Boolean user = AuthController.checkExistUserId2(Int32.Parse(Session["userid"].ToString()), out userEmail, out userName, out userGender);

                txtEmail.Value = userEmail;
                txtName.Value = userName;
                txtGender.Value = userGender;
            }
        }
    }
}