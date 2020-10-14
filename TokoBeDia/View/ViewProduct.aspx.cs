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
    public partial class ViewProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> product = ItemAuthHandler.getProducts();

            var dataSource = product.Select(x => new
            {
                x.productID,
                x.productName,
                x.productStock,
                x.ProductType.productTypeName,
                x.productPrice
            });
            viewProduct.DataSource = dataSource;
            viewProduct.DataBind();

            if(Session["userrole"].ToString() == "Administrator")
            {
                adminPvl.Style.Add("display", "inline");
            } else
            {
                adminPvl.Style.Add("display", "none");
            }
        }

        protected void delProduct(object sender, EventArgs e)
        {
            int id = Int32.Parse(productId.Value);
            Boolean product = AuthController.checkProduct(id);

            if(product)
            {
                CrudController.removeProduct(id);
                viewProduct.DataSource = CrudController.getProducts();
                viewProduct.DataBind();

                errorMsg.Text = "";
                errorMsg.Style.Add("visibility", "hidden");

            } else
            {
                errorMsg.Text = "Product ID tidak ditemukan";
                errorMsg.Style.Add("visibility", "visible");
            }
            
        }

        protected void updProduct(object sender, EventArgs e)
        {
            int id = Int32.Parse(productId.Value);
            Boolean product = AuthController.checkProduct(id);

            if (product)
            {
                Response.Redirect("UpdateProduct.aspx?ID=" + productId.Value);

                errorMsg.Text = "";
                errorMsg.Style.Add("visibility", "hidden");
            }
            else
            {
                errorMsg.Text = "Product ID tidak ditemukan";
                errorMsg.Style.Add("visibility", "visible");
            }
        }
    }
}