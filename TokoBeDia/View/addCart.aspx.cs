using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Controller;
using TokoBeDia.Model;

namespace TokoBeDia.View
{
    public partial class addCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userid"] != null)
            {
                productlist.DataSource = CartController.getProduct();
                productlist.DataBind();
            }
            else
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void AddToCart_Click(object sender, EventArgs e)
        {
            string productId = productid.Text;
            string quantity = qty.Text;


            if (productId.Length == 0 || quantity.Length == 0)
            {
                error.Text = "Product Id atau Quantity invalid";
            }
            else
            {
                int productID = Int32.Parse(productId);
                int qtty = Int32.Parse(quantity);
                int userId = Int32.Parse(Session["userid"].ToString());
                bool check = checkQty(productID, qtty);

                if (CartController.isProductExist(productID) == false)
                {
                    error.Text = "Product Id salah";
                }
                else if (CartController.isProductExist(productID) == true && CartController.checkstock(productID) == true)
                {
                    error.Text = "";
                }

                if (!check)
                {
                    error.Text = "mohon cek kembali quantity";
                }
                else
                {
                    CartController.addToCart(userId, productID, qtty);
                    error.Text = "Success add to cart";
                }
            }
        }

        private bool checkQty(int productId, int quantity)
        {
            Product dbQty = CartController.getProdStocks(productId);
            if (quantity > dbQty.productStock)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        protected void ViewCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewAllCarts.aspx");
        }
    }
}