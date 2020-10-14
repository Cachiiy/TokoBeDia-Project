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
    public partial class AddToCart : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userid"] != null)
            {
                productList.DataSource = CartController.getProduct();
                productList.DataBind();
            }
            else
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void addcart_Click(object sender, EventArgs e)
        {
            string productId = productid.Text;
            string quantity = qty.Text;
                   

            if(productId.Length == 0 || quantity.Length == 0)
            {
                error.Text = "Product Id atau Quantity invalid";
            }
            else
            {
                int productID = Int32.Parse(productId);
                int qtty = Int32.Parse(quantity);
                
                
                if (CartController.isProductExist(productID) == false)
                {
                    error.Text = "Product Id salah";
                }
                else if (CartController.isProductExist(productID) == true && qtty > CartController.IsStock(product.productStock) == true)
                {
                    error.Text = "Stock tidak cukup";
                }
                else if (qtty < 0 || qtty == 0)
                {
                    error.Text = "Quantity harus lebih dari 0";
                }
                else
                {
                    CartController.addToCart(productID, qtty);
                    error.Text = "Success add to cart";
                }
            }

        }

        protected void ViewCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("View Cart.aspx");
        }
    }
}