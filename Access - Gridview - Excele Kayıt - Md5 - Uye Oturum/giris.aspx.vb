Imports System.Data
Imports System.Data.OleDb
Imports System.Security.Cryptography

Partial Class Default3
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim kadi, sifre, yol, sql As String
        kadi = TextBox1.Text
        sifre = TextBox2.Text
        Dim enc As Encoding = Encoding.GetEncoding("iso-8859-9")
        Dim kaynakbyte() As Byte = enc.GetBytes(sifre)
        Dim md5 As New MD5CryptoServiceProvider
        Dim byteHash() As Byte
        byteHash = md5.ComputeHash(kaynakbyte)
        Dim sifremd5 As New StringBuilder
        Dim sonucByte As Byte
        For Each sonucByte In byteHash
            sifremd5.Append(sonucByte.ToString("x2").ToUpper)
        Next
        Dim guvenlisifre As String
        guvenlisifre = sifremd5.ToString
        yol = Server.MapPath("veri.accdb")
        sql = "select * from uyeler where kadi='" & kadi & "' and sifre='" & guvenlisifre & "'"
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
            Response.Redirect("uyeol.aspx")
        Else
            Label1.Text = "Hatalı Giriş!"
        End If
    End Sub
End Class
