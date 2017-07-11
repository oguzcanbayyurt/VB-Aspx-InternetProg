<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Kredi Türü:<br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True">
            <asp:ListItem Value="1">İhtiyaç Kredisi</asp:ListItem>
            <asp:ListItem Value="2">Taşıt Kredisi</asp:ListItem>
            <asp:ListItem Value="3">Konut Kredisi</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        Kredi Tutarı:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Taksit Sayısı:
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>12</asp:ListItem>
            <asp:ListItem>24</asp:ListItem>
            <asp:ListItem>36</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button ID="Button1" runat="server" Text="HESAPLA" />
        <br />
        Ödenecek Tutar:<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        Taksit Tutarı:<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
