
Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim vize, final, ortalama As Double
        vize = TextBox1.Text
        final = TextBox2.Text
        ortalama = vize * 4 / 10 + final * 6 / 10
        If final < 50 Then
            Label1.Text = "Final Notunuz Düşük,Kaldınız.Ortalamanız = " & ortalama
            Image1.ImageUrl = "resimler/aglayanyuz.png"
            Image1.Width = 100
        ElseIf ortalama >= 60 And final >= 50 Then
            Label1.Text = "Geçtiniz,Ortalamanız = " & ortalama
            Image1.ImageUrl = "resimler/gulenyuz.png"
            Image1.Width = 100
        Else
            Label1.Text = "Kaldınız, Ortalamanız = " & ortalama
            Image1.ImageUrl = "resimler/aglayanyuz.png"
            Image1.Width = 100
        End If

    End Sub
End Class
