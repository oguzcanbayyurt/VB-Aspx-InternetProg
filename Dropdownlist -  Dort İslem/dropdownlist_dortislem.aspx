<%@ Page Language="VB" AutoEventWireup="false" CodeFile="dropdownlist_dortislem.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Sayı 1 :
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Sayı 2 :
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        İşlem Seçiniz :
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
            <asp:ListItem Value="1">Toplama</asp:ListItem>
            <asp:ListItem Value="2">Çıkarma</asp:ListItem>
            <asp:ListItem Value="3">Çarpma</asp:ListItem>
            <asp:ListItem Value="4">Bölme</asp:ListItem>
        </asp:DropDownList>
        <br />
        Sonuç : 
        <asp:Label ID="Label1" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
