
Partial Class uye_paneli
    Inherits System.Web.UI.Page

    Protected Sub LinkButton1_Click(sender As Object, e As System.EventArgs) Handles LinkButton1.Click
        Panel1.Visible = True
        Panel2.Visible = False
    End Sub

    Protected Sub LinkButton2_Click(sender As Object, e As System.EventArgs) Handles LinkButton2.Click
        Panel1.Visible = False
        Panel2.Visible = True
    End Sub

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim kadi, sifre As String
        kadi = TextBox1.Text
        sifre = TextBox2.Text
        If kadi = "admin" And sifre = "12345" Then
            Response.Redirect("anasayfa.aspx")
        Else
            Label1.Text = "Giriş Başarısız"
        End If
    End Sub

    Protected Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click
        Dim ad, soyad, kadi, sifre As String
        ad = TextBox3.Text
        soyad = TextBox4.Text
        kadi = TextBox5.Text
        sifre = TextBox6.Text
        Label2.Text = "Sayın " + ad + " " + soyad + " Başarıyla Üye Olunmuştur " + " Kullanıcı Adınız : " + kadi + " Şifreniz : " + sifre

    End Sub
End Class
