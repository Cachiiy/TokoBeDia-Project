using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Controller;

namespace TokoBeDia.View
{
    public partial class InsertPaymentType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userrole"].ToString() != "Administrator")
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void buttonSubmit_Click(object sender, EventArgs e)
        {
            string type = inputPaymentType.Value;
            Boolean paymentAlreadyExist = AuthController.checkPaymentType(type);
            Boolean boolPaymentType = (type != null) ? true : false;

            if (paymentAlreadyExist == false && boolPaymentType == true)
            {
                CrudController.newPaymentType(type);
                Response.Redirect("ViewPaymentType.aspx");
            }
            else if (boolPaymentType == false)
            {
                errorMsg.Text = "Mohon isi payment type";
                errorMsg.Style.Add("visibility", "visible");
                errorMsg.Style.Add("color", "red");
            }
            else if (type.Length < 3)
            {
                errorMsg.Text = "Payment type harus 3 karakter atau lebih";
                errorMsg.Style.Add("visibility", "visible");
                errorMsg.Style.Add("color", "red");
            }
            else
            {
                errorMsg.Text = "Payment type sudah ada";
                errorMsg.Style.Add("visibility", "visible");
                errorMsg.Style.Add("color", "red");
            }
        }
    }
}