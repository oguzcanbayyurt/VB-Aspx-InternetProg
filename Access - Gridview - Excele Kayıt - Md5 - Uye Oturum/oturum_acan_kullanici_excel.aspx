<%@ Page Language="VB" AutoEventWireup="false" CodeFile="oturum_acan_kullanici_excel.aspx.vb" Inherits="oturum_acan_kullanici" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Bilgilerimi Göster" />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:LinkButton ID="LinkButton1" runat="server">Excel&#39;e Kaydet</asp:LinkButton>
        <br />
    
    </div>
    </form>
</body>
</html>
