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
    public partial class ViewAllCarts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userid"] != null)
            {
                //List<Cart> product = CartHandler.getCart();
                TokoBeDiaContainer db = new TokoBeDiaContainer();
                var qry = (from x in db.Carts
                           join y in db.Products on x.productID equals y.productID
                           select new
                           {
                               productId = x.productID,
                               productName = y.productName,
                               productPrice = y.productPrice,
                               Quantity = x.Quantity,
                               Subtotal = (y.productPrice * x.Quantity),
                           }).ToList();
                cartlist.DataSource = qry;
                cartlist.DataBind();
                grandtotal.Text = calculateSum();
                ptList.DataSource = CartController.getptList();
                ptList.DataBind();
            }
            else
            {
                Response.Redirect("Home.aspx");
            }
        }

        private String calculateSum()
        {
            int grandtotal = 0;
            foreach (GridViewRow row in cartlist.Rows)
            {
                grandtotal = grandtotal + Int32.Parse(row.Cells[4].Text);
            }
            return grandtotal.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateCart.aspx");
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            int productID = Int32.Parse(tbDelete.Text);

            if (CartController.isProductExist(productID) == false)
            {
                errlbl.Text = "Product Id invalid";
            }
            else
            {
                CartController.removeItem(productID);
                cartlist.DataSource = CartController.getAllCartItem();
                cartlist.DataBind();

                errlbl.Text = "";
                errlbl.Style.Add("visibility", "hidden");
            }
        }

        protected void checkout_Click(object sender, EventArgs e)
        {

            string id = tbType.Text;

            if (cartlist.DataSource == null)
            {
                errlbl.Text = "Cart list Kosong";
            }
            else
            {
                int userID = Int32.Parse(Session["userid"].ToString());
                int typeID = Int32.Parse(id);
                DateTime date = DateTime.Now;

                if (CartController.isTypeExist(typeID) == false)
                {
                    errlbl.Text = "Id salah";
                }
                else
                {
                    CartController.doTransaction(userID, date, typeID);
                    goToTH.Visible = true;
                }


            }
        }

        protected void goToTH_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewTransactionHistory.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("addCart.aspx");
        }
    }
}