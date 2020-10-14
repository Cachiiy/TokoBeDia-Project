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
    public partial class UpdateProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userid"] == null)
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void updateUser(object sender, EventArgs e)
        {
            int id = Int32.Parse(Session["userid"].ToString());
            string userEmail = txtEmail.Value;
            string userName = txtName.Value;
            string userGender = selectGender.Value;

            CrudController.updateUser(id, userEmail, userName, userGender);
            Response.Redirect("ViewProfile.aspx");
        }
    }
}