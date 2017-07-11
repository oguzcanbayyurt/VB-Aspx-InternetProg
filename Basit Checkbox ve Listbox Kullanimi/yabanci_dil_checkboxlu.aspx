<%@ Page Language="VB" AutoEventWireup="false" CodeFile="yabanci_dil_checkboxlu.aspx.vb" Inherits="yabanci_dil_checkboxlu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Yabancı Diller<asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem>İngilizce</asp:ListItem>
            <asp:ListItem>Almanca</asp:ListItem>
            <asp:ListItem>İtalyanca</asp:ListItem>
            <asp:ListItem>Fransızca</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <asp:Button ID="Button1" runat="server" Text="AKTAR" />
        <br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
    
    </div>
    </form>
</body>
</html>
