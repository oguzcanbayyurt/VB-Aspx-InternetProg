Imports System.Data
Imports System.Data.OleDb
Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim kadi, sifre, yol, sql As String
        kadi = TextBox1.Text
        sifre = TextBox2.Text
        yol = Server.MapPath("veri.accdb")
        sql = "Select * from uyeler where kadi='" & kadi & "' and sifre='" & sifre & "'"
        Dim baglanti As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & yol)
        Dim verial As New OleDbDataAdapter(sql, baglanti)
        Dim ds As New DataSet
        verial.Fill(ds)
        Dim kisi As Integer
        kisi = ds.Tables(0).Rows.Count
        If kisi = 1 Then
            Response.Redirect("uyeol.aspx")
        Else
            Label1.Text = "Hatalı Giriş"
        End If
    End Sub
End Class
