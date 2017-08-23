<%@ Page Language="VB" AutoEventWireup="false" CodeFile="dosya.aspx.vb" Inherits="dosya" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Dosya Seçiniz:
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <asp:Button ID="Button1" runat="server" Text="YÜKLE" />
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        <br />
        Dosya Adı&nbsp;&nbsp; :<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        Dosya Türü:&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        Dosya Büyüklüğü:&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        Fotoğraf&nbsp;&nbsp;
        <asp:Image ID="Image1" runat="server" />
        <br />
    
    </div>
    </form>
</body>
</html>
