﻿Imports System.Data
Imports System.Data.OleDb
Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim ad, soyad, kadi, sifre, yol, sql As String
        ad = TextBox1.Text
        soyad = TextBox2.Text
        kadi = TextBox3.Text
        sifre = TextBox4.Text
        yol = Server.MapPath("veri.accdb")
        sql = "Insert into uyeler (u_adi,u_soyadi,kadi,sifre) values ('" & ad & "','" & soyad & "','" & kadi & "','" & sifre & "')"
        Dim baglanti As New OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & yol)
        Dim komut As New OleDbCommand
        komut.Connection = baglanti
        komut.CommandText = Sql
        baglanti.Open()
        komut.ExecuteNonQuery()
        baglanti.Close()
        Label1.Text = "Başarıyla üye oldunuz"
        Response.Redirect("giris.aspx")
    End Sub
End Class
