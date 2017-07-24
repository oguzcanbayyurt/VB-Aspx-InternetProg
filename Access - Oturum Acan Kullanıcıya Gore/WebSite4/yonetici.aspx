<%@ Page Language="VB" AutoEventWireup="false" CodeFile="yonetici.aspx.vb" Inherits="yonetici" %>

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
        <asp:LinkButton ID="LinkButton3" runat="server">Not Girişi</asp:LinkButton>
        <br />
        <asp:LinkButton ID="LinkButton4" runat="server">Çıkış Yap</asp:LinkButton>
        <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="View1" runat="server">
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
            </asp:View>
            <asp:View ID="View2" runat="server">
                <asp:GridView ID="GridView2" runat="server">
                </asp:GridView>
            </asp:View>
            <asp:View ID="View3" runat="server">

                <br />
                Not Girilecek Öğrencinin Kullanıcı Adı ve Notunu Giriniz<br />
                <br />
                Kullanıcı Adı :
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                Matematik :&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
                Türkçe :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="Button1" runat="server" Text="Gönder" />
                <br />
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                <br />

            </asp:View>
        </asp:MultiView>
    
    </div>
    </form>
</body>
</html>
