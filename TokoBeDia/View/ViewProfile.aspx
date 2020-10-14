<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="ViewProfile.aspx.cs" Inherits="TokoBeDia.View.ViewProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="form-group">
            <asp:label for="txtEmail" runat="server">Email</asp:label>
            <input runat="server" type="email" class="form-control" id="txtEmail" placeholder="Email" disabled>
        </div>    
        <div class="form-group">
            <asp:Label for="txtName" runat="server">Name</asp:Label>
            <input runat="server" type="text" class="form-control" id="txtName" placeholder="Name" disabled/>
        </div>
        <div class="form-group">
            <asp:Label for="txtGender" runat="server">Gender</asp:Label>
            <input runat="server" type="text" class="form-control" id="txtGender" placeholder="Gender" disabled/>
        </div>
        <div class="form-group">
            <button type="button" class="btn btn-outline-primary"><a href="UpdateProfile.aspx">Update</a></button>
            <button type="button" class="btn btn-outline-secondary"><a href="UpdatePassword.aspx">Change Password</a></button>
        </div>
    </div>
</asp:Content>
