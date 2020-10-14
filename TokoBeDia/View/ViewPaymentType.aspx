<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="ViewPaymentType.aspx.cs" Inherits="TokoBeDia.View.ViewPaymentType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="viewPaymentType" runat="server"></asp:GridView>

    <div id="adminPvl" runat="server">
            <input id="paymentTypeId" runat="server" type="text" required/>
            <asp:Button ID="deletePaymentType" runat="server" Text="Delete" OnClick="deletePaymentType_Click"/>
            <asp:Button ID="updatePaymentType" runat="server" Text="Update" OnClick="updatePaymentType_Click"/>
            <a href="InsertPaymentType.aspx">Insert</a>
            <asp:Label ID="errorMsg" runat="server" CssClass="errorMsg"></asp:Label>
        </div>
</asp:Content>
