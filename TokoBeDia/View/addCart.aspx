<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="addCart.aspx.cs" Inherits="TokoBeDia.View.addCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="productlist" runat="server">
    </asp:GridView>
    <br />
    Product ID :
    <asp:TextBox ID="productid" runat="server"></asp:TextBox>
    <br />
    Quantity&nbsp;&nbsp;&nbsp; :
    <asp:TextBox ID="qty" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="error" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Button ID="AddToCart" runat="server" OnClick="AddToCart_Click" Text="Add To Cart" />
    <br />
    <br />
    <asp:Button ID="ViewCart" runat="server" OnClick="ViewCart_Click" Text="View Cart" />
    <br />
</asp:Content>
