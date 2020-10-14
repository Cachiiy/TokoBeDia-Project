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
    public partial class UpdateProductType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void submitProduct(object sender, EventArgs e)
        {
            int id = Int32.Parse(Request.QueryString["ID"]);
            string productTypeName = inputName.Value;
            string productTypeDescription = inputDescription.Value;

            CrudController.updateProductType(id, productTypeName, productTypeDescription);

            Response.Redirect("ViewProductType.aspx");
        }
    }
}