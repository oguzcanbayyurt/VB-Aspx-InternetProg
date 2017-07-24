<%@ Page Language="VB" AutoEventWireup="false" CodeFile="il_ilce_veri_aktarma.aspx.vb" Inherits="il_ilce_veri_aktarma" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"><html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" Text="AKTAR" />
        <br />
        <br />
        İl:&nbsp; 
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
            style="height: 22px">
        </asp:DropDownList>
        <br />
       İlçe:
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True"></asp:ListBox>
        <br />
    
    </div>
    </form>
</body>
</html>
