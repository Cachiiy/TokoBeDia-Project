<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="ViewTransactionReport.aspx.cs" Inherits="TokoBeDia.View.ViewTransactionReport" %>
<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Back" />
        <br />
        <br />
&nbsp;&nbsp;
        <CR:CrystalReportViewer ID="TransactionReportViewer" runat="server" AutoDataBind="true" OnInit="TransactionReportViewer_Init" />

    &nbsp;<br />

    </div>
</asp:Content>