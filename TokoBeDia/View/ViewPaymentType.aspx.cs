using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Controller;
using TokoBeDia.Handler;
using TokoBeDia.Model;

namespace TokoBeDia.View
{
    public partial class ViewPaymentType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            viewPaymentType.DataSource = ItemAuthHandler.getPaymentType();
            viewPaymentType.DataBind();

            if (Session["userrole"].ToString() == "Administrator")
            {
                adminPvl.Style.Add("display", "inline");
            }
            else
            {
                adminPvl.Style.Add("display", "none");
            }
        }

        protected void InsertPaymentType_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertPaymentType.aspx");
        }

        protected void deletePaymentType_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(paymentTypeId.Value);
            Boolean exist = AuthController.checkPaymentTypeId(id);

            if (exist)
            {
                CrudController.removePaymentType(id);
                viewPaymentType.DataSource = CrudController.getPaymentType();
                viewPaymentType.DataBind();

                errorMsg.Text = "";
                errorMsg.Style.Add("visibility", "hidden");
            }
            else
            {
                errorMsg.Text = "Payment Type ID tidak ditemukan";
                errorMsg.Style.Add("visibility", "visible");
            }
        }

        protected void updatePaymentType_Click(object sender, EventArgs e)
        {
            int ID = Int32.Parse(paymentTypeId.Value);
            Boolean exist = AuthController.checkPaymentTypeId(ID);

            if (exist == true)
            {
                Response.Redirect("UpdatePaymentType.aspx?id=" + ID);

                errorMsg.Text = "";
                errorMsg.Style.Add("visibility", "hidden");
            }
            else
            {
                errorMsg.Text = "Payment Type ID tidak ditemukan";
                errorMsg.Style.Add("visibility", "visible");
            }
        }
    }
}