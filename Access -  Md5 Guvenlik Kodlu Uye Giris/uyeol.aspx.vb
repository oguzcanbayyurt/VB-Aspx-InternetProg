Imports System.Data
Imports System.Data.OleDb
Imports System.Security.Cryptography

Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim ad, soyad, kadi, sifre, yol, sql As String
        ad = TextBox1.Text
        soyad = TextBox2.Text
        kadi = TextBox3.Text
        sifre = TextBox4.Text
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
        sql = "Insert into uyeler (u_adi,u_soyadi,kadi,sifre) values ('" & ad & "','" & soyad & "','" & kadi & "','" & guvenlisifre & "')"
        Dim baglanti As New OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & yol)
        Dim komut As New OleDbCommand
        komut.Connection = baglanti
        komut.CommandText = sql
        baglanti.Open()
        komut.ExecuteNonQuery()
        baglanti.Close()
        Label1.Text = "Başarıyla üye oldunuz"
        Response.Redirect("giris.aspx")
    End Sub
End Class
