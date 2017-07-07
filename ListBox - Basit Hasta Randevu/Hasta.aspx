<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Hasta.aspx.vb" Inherits="Hasta" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Adı_Soyadı:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Tc Kimlik No:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        Radevu Tarihi:<asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <br />
        Randevu Saati:<asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Seçiniz</asp:ListItem>
            <asp:ListItem>9:00</asp:ListItem>
            <asp:ListItem>09:30</asp:ListItem>
            <asp:ListItem>10:00</asp:ListItem>
        </asp:DropDownList>
        <br />
        Bölüm:<br />
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True">
            <asp:ListItem>Dahiliye</asp:ListItem>
            <asp:ListItem>KBB</asp:ListItem>
            <asp:ListItem>Radyoloji</asp:ListItem>
        </asp:ListBox>
        <br />
        Doktor:<br />
        <asp:ListBox ID="ListBox2" runat="server">
            <asp:ListItem>Caner Kara</asp:ListItem>
            <asp:ListItem>Elif İnan</asp:ListItem>
        </asp:ListBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Randevu AL" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
