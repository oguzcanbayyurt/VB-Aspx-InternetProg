<%@ Page Language="VB" AutoEventWireup="false" CodeFile="gridview_resimli.aspx.vb" Inherits="gridview_resimli" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server">
            <Columns>
                <asp:ImageField DataImageUrlField="id" 
                    DataImageUrlFormatString="fotograflar/{0}.jpg" HeaderText="Fotograf">
                    <ControlStyle Height="50px" Width="50px" />
                </asp:ImageField>
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
