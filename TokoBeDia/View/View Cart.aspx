<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View Cart.aspx.cs" Inherits="TokoBeDia.View.View_Cart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
       
    
        <asp:GridView ID="cartlist" runat="server" OnDataBoundRows="cartlist_DataBound" ShowFooter="True">
 
        </asp:GridView>
    
       
    
    </div>
         
      
        <br />
        <asp:Button ID="updateCart" runat="server" OnClick="updateCart_Click" Text="Update Product on Cart" Width="159px" />
        <br />
        <br />
        Delete Product ID :
        <asp:TextBox ID="tbDelete" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="deleteCart" runat="server" OnClick="deleteCart_Click" Text="Delete Product on Cart" Width="159px" />
        <br />
        <asp:Label ID="errlbl" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Button ID="co" runat="server" OnClick="checkout" Text="Checkout" Width="159px" />
        <br />
    </form>
</body>
</html>
