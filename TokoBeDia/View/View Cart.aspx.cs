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
    public partial class View_Cart : System.Web.UI.Page
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
            }
            else
            {
                Response.Redirect("Home.aspx");
            }
        }

        private void calculateSum()
        {
            int grandtotal = 0;
            foreach (GridViewRow row in cartlist.Rows)
            {
                grandtotal = grandtotal + Int32.Parse(row.Cells[4].Text);
            }
            cartlist.FooterRow.Cells[3].Text = "Grand Total";
            cartlist.FooterRow.Cells[4].Text = grandtotal.ToString();
        }

        protected void cartlist_DataBound(object sender, EventArgs e)
        {
            calculateSum();
        }


        protected void updateCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateCart.aspx");
        }

        protected void checkout(object sender, EventArgs e)
        {

            Response.Redirect("InsertPaymentType.aspx");
        }

        protected void deleteCart_Click(object sender, EventArgs e)
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

        
    }
}