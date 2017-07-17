
Partial Class Anasayfa
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim kadi, sifre As String
        kadi = TextBox1.Text
        sifre = TextBox2.Text
        If kadi = "admin" And sifre = "1234" Then
            Response.Redirect("Uye.aspx")
        Else
            Label1.Text = "Hatalı Giriş!"
        End If
    End Sub
End Class
