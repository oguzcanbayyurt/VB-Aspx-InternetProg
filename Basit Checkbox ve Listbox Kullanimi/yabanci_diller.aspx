<%@ Page Language="VB" AutoEventWireup="false" CodeFile="yabanci_diller.aspx.vb" Inherits="yabanci_diller" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Yabancı Dilleriniz :
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="EKLE" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
    
    </div>
    </form>
</body>
</html>
