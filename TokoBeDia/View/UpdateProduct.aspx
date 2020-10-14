<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="UpdateProduct.aspx.cs" Inherits="TokoBeDia.View.UpdateProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <button type="button" class="btn btn-outline-success"><a href="ViewProduct.aspx" class="a-back">Back</a></button><br /><br /><br />
        <div class="form-group">
            <asp:label for="inputName" runat="server">Name</asp:label>
            <input runat="server" type="text" class="form-control" id="inputName" placeholder="Name" required>
        </div>
        <div class="form-group">
            <asp:label for="inputStock" runat="server">Stock</asp:label>
            <input runat="server" type="text" class="form-control" id="inputStock" placeholder="Stock" required>
        </div>
        <div class="form-group">
            <asp:label for="inputPrice" runat="server">Price</asp:label>
            <input runat="server" type="text" class="form-control" id="inputPrice" placeholder="Price" required>
        </div>
        <div class="form-group">
        <asp:Label ID="errorMsg" for="buttonSubmit" runat="server" CssClass="errorMsg"></asp:Label>
        <br />
        <asp:Button ID="buttonSubmit" runat="server" CssClass="btn btn-success" OnClick="submitProduct" Text="Submit" />
        </div>
    </div>
</asp:Content>
