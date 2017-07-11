
Partial Class uclu_uye_ekleme
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim uyeler(2) As ListItem
        uyeler(0) = New ListItem(TextBox1.Text, TextBox2.Text)
        uyeler(1) = New ListItem(TextBox3.Text, TextBox4.Text)
        uyeler(2) = New ListItem(TextBox5.Text, TextBox6.Text)
        ListBox1.Items.AddRange(uyeler)
    End Sub
End Class
