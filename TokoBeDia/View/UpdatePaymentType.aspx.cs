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
    public partial class UpdatePaymentType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userrole"].ToString() != "Administrator")
            {
                Response.Redirect("Home.aspx");
            }
   
            if (Request.QueryString["ID"] == null)
            {
                inputPaymentType.Attributes["value"] = null;

                errorMsg.Text = "Belum memilih payment type, silahkan kembali";
                errorMsg.Style.Add("visibility", "visible");
            }
            else if(Request.QueryString["ID"] != null)
            {
                int id = Int32.Parse(Request.QueryString["ID"]);
                PaymentType pt = ItemAuthHandler.checkExistPaymentTypeId(id);

                if (pt == null)
                {
                    inputPaymentType.Attributes["value"] = null;
                    errorMsg.Text = "payment type tidak ditemukan";
                    errorMsg.Style.Add("visibility", "visible");
                }
                else
                {
                    inputPaymentType.Attributes["value"] = pt.type.ToString();
                }
            }   
        }

        protected void buttonSubmit_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(Request.QueryString["ID"]);
            string type = inputPaymentType.Value.ToString();
            Boolean paymentAlreadyExist = AuthController.checkPaymentType(type);
            Boolean boolPaymentType = (type != null) ? true : false;

            if (paymentAlreadyExist == true && boolPaymentType == true)
            {
                CrudController.updatePaymentType(id, type);
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