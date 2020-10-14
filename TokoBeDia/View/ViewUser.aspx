<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="ViewUser.aspx.cs" Inherits="TokoBeDia.View.ViewUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <button type="button" class="btn btn-outline-success"><a href="Login.aspx" class="a-back">Back</a></button><br /><br /><br />
        <asp:GridView ID="viewUser" runat="server" OnRowCommand="viewUser_RowCommand">
            <Columns>
                <asp:ButtonField CommandName="Select" Text="Select" ButtonType="Button" />
            </Columns>
        </asp:GridView>

        <asp:Label ID="lblUserID" runat="server"></asp:Label>
        <div class="form-group">
            <asp:Label for="selectRole" runat="server">Role</asp:Label>
            <select runat="server" class="form-control" id="selectRole" name="role" required>
                <option>Administrator</option>
                <option>Member</option>
            </select>
        </div>
        <div class="form-group">
            <asp:Label for="selectStatus" runat="server">Status</asp:Label>
            <select runat="server" class="form-control" id="selectStatus" name="Status" required>
                <option>Active</option>
                <option>Blocked</option>
            </select>
        </div>
        <div class="form-group">
            <asp:Button ID="buttonUpdate" runat="server" CssClass="btn btn-success" OnClick="updateUser" Text="Submit" />
        </div>
    </div>
</asp:Content>
