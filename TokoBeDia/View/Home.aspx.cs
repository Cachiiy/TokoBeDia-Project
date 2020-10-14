using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Handler;
using TokoBeDia.Model;

namespace TokoBeDia.View
{
    public partial class Home : System.Web.UI.Page
    {
        public static TokoBeDiaContainer db = new TokoBeDiaContainer();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userid"] != null)
            {
                loginProp1.Style.Add("display", "none");
                userProp1.Style.Add("display", "inline");
                viewProp1.Style.Add("display", "inline");
                viewProp2.Style.Add("display", "none");
                viewmem.Style.Add("display", "inline");

                linkUser.InnerHtml = Session["username"].ToString();

                if(Session["userrole"].ToString() == "Administrator")
                {
                    viewProp2.Style.Add("display", "inline");
                    viewProp1.Style.Add("display", "none");
                    viewmem.Style.Add("display", "none");
                }
            }
            else
            {
                Session["userrole"] = "Guest";
                loginProp1.Style.Add("display", "inline");
                userProp1.Style.Add("display", "none");
                viewProp1.Style.Add("display", "inline");
                viewProp2.Style.Add("display", "none");
                viewmem.Style.Add("display", "none");
            }

            List<Product> prod = ItemAuthHandler.getRandProduct();

            var list = from p in prod
                       where p != null
                       select new
                       {
                           p.productName,
                           p.ProductType.productTypeName,
                           p.productStock,
                           p.productPrice
                       };
            GridView1.DataSource = list;
            GridView1.DataBind();
        }

        protected void destroySession(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Cookies["userid"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect("Home.aspx");
        }
    }
}