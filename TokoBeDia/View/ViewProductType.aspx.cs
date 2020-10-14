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
    public partial class ViewProductType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<ProductType> productType = CrudController.getProductType();

            var dataSource = productType.Select(x => new
            {
                x.productTypeID,
                x.productTypeName,
                x.productTypeDescription
            });
            viewProductType.DataSource = dataSource;
            viewProductType.DataBind();

            if (Session["userrole"].ToString() == "Administrator")
            {
                adminPvl.Style.Add("display", "inline");
            }
            else
            {
                adminPvl.Style.Add("display", "none");
            }
        }

        protected void delProductType(object sender, EventArgs e)
        {
            int id = Int32.Parse(productTypeId.Value);
            Boolean productType = AuthController.checkProductType(id);

            Boolean product = AuthController.checkProductTypeOnProduct(id);

            if(productType && !product)
            {
                CrudController.removeProductType(id);
                viewProductType.DataSource = CrudController.getProductType();
                viewProductType.DataBind(); 
                
                errorMsg.Text = "";
                errorMsg.Style.Add("visibility", "hidden");
            } else
            {
                errorMsg.Text = "Gagal delete";
                errorMsg.Style.Add("visibility", "visible");
            }
            
        }

        protected void updProductType(object sender, EventArgs e)
        {
            int id = Int32.Parse(productTypeId.Value);
            Boolean productType = AuthController.checkProductType(id);

            if (productType != null)
            {
                Response.Redirect("UpdateProductType.aspx?ID=" + productTypeId.Value);

                errorMsg.Text = "";
                errorMsg.Style.Add("visibility", "hidden");
            } else
            {
                errorMsg.Text = "Product ID tidak ditemukan";
                errorMsg.Style.Add("visibility", "visible");
            }
        }
    }
}