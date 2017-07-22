Imports System.Data
Imports System.Data.OleDb
Partial Class Default3
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim kadi, sifre, yol, sql As String
        kadi = TextBox1.Text
        sifre = TextBox2.Text
        yol = Server.MapPath("veri.accdb")
        sql = "select * from uyeler where kadi='" & kadi & "' and sifre='" & sifre & "'"
        Dim baglanti As New OleDbConnection("provider=microsoft.ACE.OLEDB.12.0;Data Source=" & yol)
        Dim verial As New OleDbDataAdapter(sql, baglanti)
        Dim ds As New DataSet
        verial.Fill(ds)
        Dim kisi_sayisi As Integer
        kisi_sayisi = ds.Tables(0).Rows.Count
        Dim x As String
        If kisi_sayisi = 1 Then
            x = ds.Tables(0).Rows(0).Item(2)
            Session("kadi") = x
            Response.Redirect("uye.aspx")
        Else
            Label1.Text = "Hatalı Giriş!"
        End If
    End Sub
End Class
