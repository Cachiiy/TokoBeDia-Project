using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Controller;
using TokoBeDia.Handler;
using TokoBeDia.Repository;

namespace TokoBeDia.View
{
    public partial class UpdateProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userrole"].ToString() != "Administrator")
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void submitProduct(object sender, EventArgs e)
        {
            int id = Int32.Parse(Request.QueryString["ID"]);
            string productName = inputName.Value;
            int productStock = Int32.Parse(inputStock.Value);
            int productPrice = Int32.Parse(inputPrice.Value);

            CrudController.submitProduct(id, productName, productStock, productPrice);

            Response.Redirect("ViewProduct.aspx");
        }
    }
}