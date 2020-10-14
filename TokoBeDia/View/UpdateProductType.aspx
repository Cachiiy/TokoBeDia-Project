<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="UpdateProductType.aspx.cs" Inherits="TokoBeDia.View.UpdateProductType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="form-group">
            <button type="button" class="btn btn-outline-success"><a href="ViewProductType.aspx" class="a-back">Back</a></button><br /><br /><br />
            <asp:label for="inputName" runat="server">Name</asp:label>
            <input runat="server" type="text" class="form-control" id="inputName" placeholder="Name" required>
        </div>
        <div class="form-group">
            <asp:label for="inputDescription" runat="server">Description</asp:label>
            <input runat="server" type="text" class="form-control" id="inputDescription" placeholder="Description" required>
        </div>
        <div class="form-group">
        <asp:Label ID="errorMsg" for="buttonSubmit" runat="server" CssClass="errorMsg"></asp:Label>
        <br />
        <asp:Button ID="buttonSubmit" runat="server" CssClass="btn btn-success" OnClick="submitProduct" Text="Submit" />
        </div>
    </div>
</asp:Content>
