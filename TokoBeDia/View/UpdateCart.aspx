<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateCart.aspx.cs" Inherits="TokoBeDia.View.UpdateCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="cartlist2" runat="server">
        </asp:GridView>
    <div>
    
        <br />
        ID&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tbId" runat="server"></asp:TextBox>
        <br />
    
    </div>
        Quantity&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbQty" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="err" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Button ID="update" runat="server" OnClick="update_Click" Text="Update" Width="145px" />
    </form>
</body>
</html>
