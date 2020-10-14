<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="TokoBeDia.View.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <button type="button" class="btn btn-outline-success"><a href="Login.aspx" class="a-back">Back</a></button><br /><br /><br />
        <div class="form-group">
            <asp:label for="inputEmail" runat="server">Email</asp:label>
            <input runat="server" type="email" class="form-control" id="inputEmail" aria-describedby="emailHelp" placeholder="Email" required>
        </div>
        <div class="form-group">
            <asp:Label for="inputName" runat="server">Name</asp:Label>
            <input runat="server" type="text" class="form-control" id="inputName" placeholder="Name" required/>
        </div>
        <div class="form-group">
            <asp:Label for="inputPassword" runat="server">Password</asp:Label>
            <input runat="server" type="password" class="form-control" id="inputPassword" placeholder="Password" required/>
        </div>
        <div class="form-group">
            <asp:Label for="inputCPassword" runat="server">Confirm Password</asp:Label>
            <input runat="server" type="password" class="form-control" id="inputCPassword" placeholder="Confirm Password"/>
        </div>
        <div class="form-group">
            <asp:Label for="selectGender" runat="server">Gender</asp:Label>
            <select runat="server" class="form-control" id="selectGender" name="gender" required>
                <option>Male</option>
                <option>Female</option>
            </select>
        </div>
        <asp:Label ID="errorMsg" for="buttonRegister" runat="server" CssClass="errorMsg"></asp:Label>
        <br />
        <asp:Button ID="buttonRegister" runat="server" CssClass="btn btn-success" OnClick="RegisterUser" Text="Register" />
    </div>
</asp:Content>
