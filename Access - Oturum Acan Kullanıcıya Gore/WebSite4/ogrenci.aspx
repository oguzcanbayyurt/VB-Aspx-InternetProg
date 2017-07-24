<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ogrenci.aspx.vb" Inherits="ogrenci" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Hoşgeldiniz
        <asp:Label ID="Label1" runat="server"></asp:Label>
    
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server">Bilgileri Görüntüle</asp:LinkButton>
        <br />
        <asp:LinkButton ID="LinkButton2" runat="server">Notları Görüntüle</asp:LinkButton>
        <br />
        <asp:LinkButton ID="LinkButton3" runat="server">Çıkış Yap</asp:LinkButton>
        <br />
        <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="View1" runat="server">
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
            </asp:View>
            <asp:View ID="View2" runat="server">
                <asp:GridView ID="GridView2" runat="server">
                </asp:GridView>
            </asp:View>
        </asp:MultiView>
    
    </div>
    </form>
</body>
</html>
