using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Model;

namespace TokoBeDia.View
{
    public partial class ViewTransactionHistory1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userid"] != null)
            {
                TokoBeDiaContainer db = new TokoBeDiaContainer();
                if (Session["userrole"].ToString() == "Administrator")
                {
                    Button1.Visible = true;
                    var qry = (from x in db.HeaderTransactions
                               join u in db.Users on x.userID equals u.userID
                               join y in db.DetailTransactions on x.ID equals y.transactionID
                               join z in db.Products on y.productID equals z.productID
                               select new
                               {
                                   UserID = x.userID,
                                   UserName = u.userName,
                                   TransactionDate = x.date,
                                   PaymentType = x.PaymentType,
                                   ProductName = z.productName,
                                   ProductQuantity = y.quantity,
                                   Subtotal = (z.productPrice * y.quantity),
                               }).ToList();
                    GridView1.DataSource = qry;
                    GridView1.DataBind();
                }
                else
                {
                    int id = Int32.Parse(Session["userid"].ToString());
                    var qry = (from x in db.HeaderTransactions
                              join y in db.DetailTransactions on x.ID equals y.transactionID
                              join z in db.Products on y.productID equals z.productID
                              where x.userID == id
                              select new
                               {
                                   TransactionDate = x.date,
                                   PaymentType = x.PaymentType,
                                   ProductName = z.productName,
                                   ProductQuantity = y.quantity,
                                   Subtotal = (z.productPrice * y.quantity),
                               }).ToList();
                    GridView1.DataSource = qry;
                    GridView1.DataBind();
                }
            }
            else
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewTransactionReport.aspx");
        }
    }
}