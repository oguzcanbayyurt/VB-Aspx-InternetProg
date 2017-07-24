Imports System.Data
Imports System.Data.OleDb
Partial Class _Default
    Inherits System.Web.UI.Page
    Private Function resim_olustur() As String
        Dim sayilar() As String = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
        Dim rasgele As New Random()
        Dim str1 As String = sayilar(rasgele.Next(0, 9))
        Dim str2 As String = sayilar(rasgele.Next(0, 9))
        Dim str3 As String = sayilar(rasgele.Next(0, 9))
        Dim str4 As String = sayilar(rasgele.Next(0, 9))
        Dim str5 As String = sayilar(rasgele.Next(0, 9))
        Dim str6 As String = sayilar(rasgele.Next(0, 9))
        Return str1 + str2 + str3 + str4 + str5 + str6
    End Function

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim kadi, sifre, sistem, yol, sql As String
        kadi = TextBox1.Text
        sifre = TextBox2.Text
        yol = Server.MapPath("veri.accdb")
        sql = "select * from uyeler where kadi='" & kadi & "' and sifre='" & sifre & "'"
        Dim baglanti As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & yol)
        Dim verial As New OleDbDataAdapter(sql, baglanti)
        Dim ds As New DataSet
        verial.Fill(ds)
        Dim kisi As Integer
        kisi = ds.Tables(0).Rows.Count
        Dim x As String
        If kisi = 1 And TextBox3.Text = Label1.Text Then
            sistem = ds.Tables(0).Rows(0).Item(4)
            If sistem = "1" Then
                x = ds.Tables(0).Rows(0).Item(2)
                Session("kadi") = x
                Response.Redirect("yonetici.aspx")

            Else
                x = ds.Tables(0).Rows(0).Item(2)
                Session("kadi") = x
                Response.Redirect("ogrenci.aspx")

            End If
        Else
            Label2.Text = "Hatalı Giriş"
        End If

    End Sub

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Label1.Text = resim_olustur()
        End If
    End Sub
End Class
