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
    public partial class UpdateCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userid"] != null)
            {
                refresh();
            }
            else
            {
                Response.Redirect("Home.aspx");
            }

        }
        void refresh()
        {
            List<Cart> cart = CartHandler.getCart();

            var dataSource = cart.Select(x => new
            {
                x.productID,
                x.Quantity
            });
            cartlist2.DataSource = dataSource;
            cartlist2.DataBind();
        }

        protected void update_Click(object sender, EventArgs e)
        {
            string productId = tbId.Text;
            string quantity = tbQty.Text;

            if (productId.Length == 0 || quantity.Length == 0)
            {
                err.Text = "Product Id atau Quantity salah";
            }
            else
            {
                int productID = Int32.Parse(productId);
                int qty = Int32.Parse(quantity);

                if (CartController.isProductExist(productID) == false)
                {
                    err.Text = "Product Id salah";
                }
                else if (qty < 0)
                {
                    err.Text = "Quantity harus lebih dari 0";
                }
                else if (qty == 0)
                {
                    CartController.removeCart(productID);
                }
                else
                {
                    CartController.updateQuantity(productID, qty);
                    cartlist2.DataSource = CartController.getAllCartItem();
                    cartlist2.DataBind();
                    err.Text = "Success update the cart";

                }
            }
        }
    }
}