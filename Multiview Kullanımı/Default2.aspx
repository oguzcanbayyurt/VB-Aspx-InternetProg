<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default2.aspx.vb" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:LinkButton ID="LinkButton1" runat="server">Anasayfa</asp:LinkButton>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton2" runat="server">Hakkımızda</asp:LinkButton>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton3" runat="server">İletişim</asp:LinkButton>
        <br />
        <br />
        <asp:MultiView ID="MultiView1" runat="server">
            <br />
            <br />
            <br />
            <asp:View ID="View1" runat="server">
                Anasayfa
            </asp:View>
            <br />
            <asp:View ID="View2" runat="server">
                Hakkımızda
            </asp:View>
            <br />
            <asp:View ID="View3" runat="server">
                letişim
            </asp:View>
            <br />
            <br />
            <br />
            <br />
        </asp:MultiView>
    
    </div>
    </form>
</body>
</html>
