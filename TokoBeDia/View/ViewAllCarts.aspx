<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="ViewAllCarts.aspx.cs" Inherits="TokoBeDia.View.ViewAllCarts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Back" />
    <br />
    <asp:GridView ID="cartlist" runat="server">
    </asp:GridView>
    <br />
    Grand Total :
    
    <asp:label runat="server" ID="grandtotal"></asp:label>
    <br />
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Update Product On Cart" />
    <br />
    <br />
    Delete Product ID :
    <asp:TextBox ID="tbDelete" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Delete" runat="server" OnClick="Delete_Click" Text="Delete" />
    <br />
    <br />
    <asp:Label ID="errlbl" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:GridView ID="ptList" runat="server">
    </asp:GridView>
    <br />
    
&nbsp;<br />
    <br />
    Choose Payment Type ID : <br />
    <asp:TextBox ID="tbType" runat="server"></asp:TextBox>
    <br />
    <br />
    <br />
    <asp:Button ID="checkout" runat="server" OnClick="checkout_Click" Text="Checkout" />
    <br />
    <br />
    <asp:Button ID="goToTH" runat="server" OnClick="goToTH_Click" Text="View Transaction History" Visible="False" />
</asp:Content>
