<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="TokoBeDia.View.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    <ul class="nav nav-pills nav-fill">
        <li class="nav-item">
            <a id="active" class="nav-link" href="Home.aspx">Home</a>
        </li>
        <li id="viewProp1" class="nav-item" runat="server">
            <a class="nav-link" href="ViewProduct.aspx">View Product</a>
            
        </li>
        <li id="viewmem" class="nav-item dropdown" runat="server">
            <a class="nav-link dropdown-toggle" runat="server" href="#" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Member Pvl</a>
            <div class="dropdown-menu">
                <a class="dropdown-item" href="addCart.aspx">Add Cart</a>
              <a class="dropdown-item" href="ViewProduct.aspx">View Product</a>
              <a class="dropdown-item" href="ViewTransactionHistory.aspx">View Transaction History</a>
                
            </div>
        </li>

        <li id="viewProp2" class="nav-item dropdown" runat="server">
            <a class="nav-link dropdown-toggle" runat="server" href="#" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Admin Pvl</a>
            <div class="dropdown-menu">
                <a class="dropdown-item" href="ViewUser.aspx">View User</a>
              <a class="dropdown-item" href="ViewProduct.aspx">View Product</a>
                <a class="dropdown-item" href="InsertProduct.aspx">Insert Product</a>
                <a class="dropdown-item" href="UpdateProduct.aspx">Update Product</a>
                <a class="dropdown-item" href="ViewPaymentType.aspx">View Payment Type</a>
                <a class="dropdown-item" href="InsertPaymentType.aspx">Insert Payment Type</a>
                <a class="dropdown-item" href="UpdatePaymentType.aspx">Update Payment Type</a>
              <a class="dropdown-item" href="ViewProductType.aspx">View Product Type</a>
                <a class="dropdown-item" href="InsertProductType.aspx">Insert Product Type</a>
                <a class="dropdown-item" href="UpdateProductType.aspx">Update Product Type</a>
              <a class="dropdown-item" href="ViewTransactionHistory.aspx">View Transaction History</a>
                <a class="dropdown-item" href="ViewTransactionReport.aspx">View Transaction Report</a>
            </div>
        </li>
        <li id="loginProp1" class="nav-item" runat="server">        
            <asp:HyperLink ID="linkLogin" runat="server" CssClass="nav-link " NavigateUrl="~/View/Login.aspx" Text="Login" />
        </li>
        <li id="userProp1" class="nav-item dropdown" runat="server">
            <a id="linkUser" class="nav-link dropdown-toggle" runat="server" href="#" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false"></a>
            <div class="dropdown-menu">
              <a class="dropdown-item" href="ViewProfile.aspx">Profile</a>
              <div class="dropdown-divider"></div>
              <asp:Button ID="logout" runat="server" CssClass="btn btn-danger" OnClick="destroySession" Text="Logout"/>
            </div>
        </li>
    </ul>
</asp:Content>
