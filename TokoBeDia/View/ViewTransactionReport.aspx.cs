using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Controller;
using TokoBeDia.Model;
using TokoBeDia.Report;

namespace TokoBeDia.View
{
    public partial class ViewTransactionReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["userid"] != null)
                {
                    if (Session["userRole"].ToString() != "Administrator")
                    {
                        Response.Redirect("Home.aspx");
                    }
                    else
                    {
                        ReportDocument rpdoc = new ReportDocument();
                        rpdoc.Load(Server.MapPath("~/Report/CrystalReport1.rpt"));
                        DataSet1 ds = TransactionController.getDataSetForReport();
                        rpdoc.SetDataSource(ds);
                        TransactionReportViewer.ReportSource = rpdoc;
                    }
                }
                else
                {
                    Response.Redirect("Home.aspx");
                }
            }
        }

        protected void Page_Init()
        {
            if (!IsPostBack)
            {
                DataSet1 ds = TransactionController.getDataSetForReport();
                ReportDocument rpDoc = new ReportDocument();
                rpDoc.Load(Server.MapPath("~/Report/CrystalReport1.rpt"));
                rpDoc.SetDataSource(ds);
                Session["myReport"] = rpDoc;
                TransactionReportViewer.ReportSource = rpDoc;
                TransactionReportViewer.DataBind();
                TransactionReportViewer.RefreshReport();
            }
            else
            {
                ReportDocument doc = (ReportDocument)Session["myReport"];
                TransactionReportViewer.ReportSource = doc;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void TransactionReportViewer_Init(object sender, EventArgs e)
        {

            var connectionInfo = new ConnectionInfo();
            connectionInfo.ServerName = "192.168.x.xxx";
            connectionInfo.DatabaseName = "xxxx";
            connectionInfo.Password = "xxxx";
            connectionInfo.UserID = "xxxx";
            connectionInfo.Type = ConnectionInfoType.SQL;
            connectionInfo.IntegratedSecurity = false;

            for (int i = 0; i < TransactionReportViewer.LogOnInfo.Count; i++)
            {
                TransactionReportViewer.LogOnInfo[i].ConnectionInfo = connectionInfo;
            }
        }
    }
}
    
