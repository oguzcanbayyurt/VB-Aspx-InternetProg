<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Menü_secimi.aspx.vb" Inherits="Menü_secimi" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Menü Seçiniz:"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
            <asp:ListItem Value="Seciniz">Seçiniz</asp:ListItem>
            <asp:ListItem Value="corbalar">Çorbalar</asp:ListItem>
            <asp:ListItem Value="AraYemekler">Ara Yemekler</asp:ListItem>
            <asp:ListItem>Tatlılar</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        Çeşitler:&nbsp; 
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
        Fotoğraflar:
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Image ID="Image1" runat="server" Height="71px" Width="110px" />
    
    </div>
    </form>
</body>
</html>
