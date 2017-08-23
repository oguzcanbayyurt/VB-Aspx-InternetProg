<%@ Page Language="VB" AutoEventWireup="false" CodeFile="verileri_excel_kaydetme.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" Text="Göster" />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:LinkButton ID="LinkButton1" runat="server">Excel olarak kaydet...</asp:LinkButton>
        <br />
    
    </div>
    </form>
</body>
</html>
