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
    public partial class UpdatePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userid"] == null)
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void updatePassword(object sender, EventArgs e)
        {
            string userPassword = "";
            Boolean curr = AuthController.checkExistUserId(Int32.Parse(Session["userid"].ToString()), out userPassword);

            if(txtNewPassword.Value == txtConfirmPassword.Value && userPassword == txtOldPassword.Value)
            {
                string newPassword = txtNewPassword.Value;
                int id = Int32.Parse(Session["userid"].ToString());

                CrudController.updatePassword(id, newPassword);

                Response.Redirect("ViewProfile.aspx");
            } else
            {
                
            }
            
        }
    }
}