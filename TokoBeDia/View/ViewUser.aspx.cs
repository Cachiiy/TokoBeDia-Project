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
    public partial class ViewUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["userrole"].ToString() == "Administrator")
            {
                List<User> user = CrudController.getUser();

                var dataSource = user.Select(x => new
                {
                    x.userID,
                    x.userName,
                    x.userStatus,
                    x.Role.roleName
                });
                viewUser.DataSource = dataSource;
                viewUser.DataBind();
            } else
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void viewUser_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex = Convert.ToInt32(e.CommandArgument);

            GridViewRow viewRow = viewUser.Rows[rowIndex];

            string id = viewRow.Cells[1].Text;
            string status = viewRow.Cells[3].Text;
            string role = viewRow.Cells[4].Text;

            lblUserID.Text = id;
            selectStatus.Value = status;
            selectRole.Value = role;
        }

        protected void updateUser(object sender, EventArgs e)
        {
            int id = Int32.Parse(lblUserID.Text);
            string status = selectStatus.Value;
            string role = selectRole.Value;

            CrudController.updateUserA(id, role, status);
            Response.Redirect("ViewUser.aspx");
        }
    }
}