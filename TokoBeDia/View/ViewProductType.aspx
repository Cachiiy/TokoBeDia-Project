<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="ViewProductType.aspx.cs" Inherits="TokoBeDia.View.ViewProductType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <button type="button" class="btn btn-outline-success"><a href="Home.aspx" class="a-back">Back</a></button><br /><br /><br />
        <asp:GridView ID="viewProductType" runat="server">
        </asp:GridView>

        <div id="adminPvl" runat="server">
            <input id="productTypeId" runat="server" type="text" required/>
            <asp:Button ID="deleteProductType" runat="server" Text="Delete" OnClick="delProductType"/>
            <asp:Button ID="updateProductType" runat="server" Text="Update" OnClick="updProductType"/>
            <a href="InsertProductType.aspx">Insert</a>
            <asp:Label ID="errorMsg" runat="server" CssClass="errorMsg"></asp:Label>
        </div>
    </div>

</asp:Content>
