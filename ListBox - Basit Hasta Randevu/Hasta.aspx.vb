
Partial Class Hasta
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim adsoyad, tckimkilik, tarih, saat, bolum, doktor As String
        adsoyad = TextBox1.Text
        tckimkilik = TextBox2.Text
        tarih = Calendar1.SelectedDate
        saat = DropDownList1.SelectedValue
        bolum = ListBox1.SelectedValue
        doktor = ListBox2.SelectedValue
        Label1.Text = tckimkilik + "Tc Nolu" + "Sayın" + adsoyad + "" + tarih + "tarihinde" + saat + "Satrinde" + bolum + "Bölümünden" + doktor + "Doktorundan randevunuz alınmışır"


    End Sub

    Protected Sub ListBox1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim sec As String
        sec = ListBox1.SelectedItem.Text
        If sec = "Dahiliye" Then
            ListBox2.Items.Clear()
            ListBox2.Items.Add("Ufuk Gündoğdu")
            ListBox2.Items.Add("Oğuzcan Gülbayır")
            ListBox2.Items.Add("Ömürcan Topaloğlu")
        ElseIf sec = "KBB" Then
            ListBox2.Items.Clear()
            ListBox2.Items.Add("Aydın Mutlu")
            ListBox2.Items.Add("Hüseyin Gül")
            ListBox2.Items.Add("Furkan Bulut")
        ElseIf sec = "Radyoloji" Then
            ListBox2.Items.Clear()
            ListBox2.Items.Add("Meltem Pamuk")
            ListBox2.Items.Add("Hüsniye Gülü")
            ListBox2.Items.Add("Sevilay Aksakal")

        End If
    End Sub
End Class
