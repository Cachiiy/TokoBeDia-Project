<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="UpdatePassword.aspx.cs" Inherits="TokoBeDia.View.UpdatePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="form-group">
            <asp:label for="txtOldPassword" runat="server">OldPassword</asp:label>
            <input runat="server" type="password" class="form-control" id="txtOldPassword" placeholder="Old Password" required/>
        </div>    
        <div class="form-group">
            <asp:label for="txtNewPassword" runat="server">NewPassword</asp:label>
            <input runat="server" type="password" class="form-control" id="txtNewPassword" placeholder="New Password" required/>
        </div>   
        <div class="form-group">
            <asp:label for="txtConfirmPassword" runat="server">Confirm Password</asp:label>
            <input runat="server" type="password" class="form-control" id="txtConfirmPassword" placeholder="Confirm Password" required/>
        </div> 
        <div class="form-group">
            <asp:Button ID="buttonUpdate" runat="server" CssClass="btn btn-success" OnClick="updatePassword" Text="Submit" />
        </div>
    </div>
</asp:Content>
