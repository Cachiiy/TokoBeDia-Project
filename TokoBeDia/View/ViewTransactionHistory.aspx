<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="ViewTransactionHistory.aspx.cs" Inherits="TokoBeDia.View.ViewTransactionHistory1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <button type="button" class="btn btn-outline-success"><a href="Home.aspx" class="a-back">Back</a></button>&nbsp;&nbsp;&nbsp;
       
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="View Transaction Report" Visible="false" />
        <br />
        <br />
        All Transaction History<br />
            

        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
            

    </div>
</asp:Content>
