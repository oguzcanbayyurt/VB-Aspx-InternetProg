<%@ Page Language="VB" AutoEventWireup="false" CodeFile="nesnelere_veri_aktarma.aspx.vb" Inherits="nesnelere_veri_aktarma" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" Text="AKTAR" />
        <br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True">
            <asp:ListItem></asp:ListItem>
        </asp:ListBox>
    
    </div>
    </form>
</body>
</html>
