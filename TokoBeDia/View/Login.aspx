<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TokoBeDia.View.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <button type="button" class="btn btn-outline-success"><a href="Home.aspx" class="a-back">Back</a></button><br /><br /><br />
        <div class="form-group">
            <asp:label for="input-email" runat="server">Email</asp:label>
            <input runat="server" type="email" class="form-control" id="inputEmail" aria-describedby="emailHelp" placeholder="Email" required>
        </div>
        <div class="form-group">
            <asp:Label for="input-password" runat="server">Password</asp:Label>
            <input runat="server" type="password" class="form-control" id="inputPassword" placeholder="Password" required/>
        </div>
        <div class="form-check">
            <asp:CheckBox ID="checkRemember" runat="server" Text="Remember Me" />
        </div>
        <asp:Label ID="errorMsg" for="buttonLogin" runat="server" CssClass="errorMsg"></asp:Label>
        <br />
        <asp:Button ID="buttonLogin" runat="server" CssClass="btn btn-success" OnClick="LoginUser" Text="Login" />
        <button type="button" class="btn btn-outline-primary"><a href="Register.aspx">Create Account</a></button>
    </div>
</asp:Content>
