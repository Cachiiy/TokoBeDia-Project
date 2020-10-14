<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="ViewProduct.aspx.cs" Inherits="TokoBeDia.View.ViewProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <button type="button" class="btn btn-outline-success"><a href="Home.aspx" class="a-back">Back</a></button><br /><br /><br />

        <asp:GridView ID="viewProduct" runat="server">
        </asp:GridView>

        <div id="adminPvl" runat="server">
            <input id="productId" runat="server" type="text" required/>
            <asp:Button ID="deleteProduct" runat="server" Text="Delete" OnClick="delProduct"/>
            <asp:Button ID="updateProduct" runat="server" Text="Update" OnClick="updProduct"/>
            <a href="InsertProduct.aspx">Insert</a>
            <asp:Label ID="errorMsg" runat="server" CssClass="errorMsg"></asp:Label>
        </div>
    </div>
</asp:Content>
