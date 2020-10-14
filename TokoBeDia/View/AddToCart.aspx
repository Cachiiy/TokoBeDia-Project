<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddToCart.aspx.cs" Inherits="TokoBeDia.View.AddToCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="productList" runat="server">
        </asp:GridView>
        <br />
        <br />
        Product ID:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="productid" runat="server"></asp:TextBox>
        <br />
        <br />
        Quantity:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="qty" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="error" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Button ID="addcart" runat="server" OnClick="addcart_Click" Text="Add To Cart" />
        <br />
        <br />
        <asp:Button ID="ViewCart" runat="server" Text="View Cart" OnClick="ViewCart_Click" />
        <br />
    
    </div>
    </form>
</body>
</html>
