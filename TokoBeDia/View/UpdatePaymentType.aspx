<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="UpdatePaymentType.aspx.cs" Inherits="TokoBeDia.View.UpdatePaymentType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <button type="button" class="btn btn-outline-success"><a href="Home.aspx" class="a-back">Back</a></button><br /><br /><br />
        <div class="form-group">
            <asp:label for="inputPaymentType" runat="server">Payment Type</asp:label>
            <input runat="server" type="text" class="form-control" id="inputPaymentType" placeholder="Payment Type" required>
        </div>
        <div class="form-group">
            <asp:Label ID="errorMsg" for="buttonSubmit" runat="server" CssClass="errorMsg"></asp:Label>
            <br />
            <asp:Button ID="buttonSubmit" runat="server" CssClass="btn btn-success" Text="Submit" OnClick="buttonSubmit_Click" />
        </div>
    </div>
</asp:Content>
