<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="TokoBeDia.View.UpdateProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="form-group">
            <asp:label for="txtEmail" runat="server">Email</asp:label>
            <input runat="server" type="email" class="form-control" id="txtEmail" placeholder="Email" required/>
        </div>    
        <div class="form-group">
            <asp:Label for="txtName" runat="server">Name</asp:Label>
            <input runat="server" type="text" class="form-control" id="txtName" placeholder="Name" required/>
        </div>
         <div class="form-group">
            <asp:Label for="selectGender" runat="server">Gender</asp:Label>
            <select runat="server" class="form-control" id="selectGender" name="gender" required>
                <option>Male</option>
                <option>Female</option>
            </select>
        </div>
        <div class="form-group">
            <asp:Button ID="buttonUpdate" runat="server" CssClass="btn btn-success" OnClick="updateUser" Text="Submit" />
        </div>
    </div>
</asp:Content>
