Imports System.Data
Imports System.Data.OleDb
Partial Class yonetici
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim x As String
        x = Session("kadi")
        Label1.Text = x
    End Sub

    Protected Sub LinkButton1_Click(sender As Object, e As System.EventArgs) Handles LinkButton1.Click
        Dim yol, sql As String
        yol = Server.MapPath("veri.accdb")
        sql = "select * from uyeler where kadi='" & Session("kadi") & "'"
        Dim baglanti As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & yol)
        Dim verial As New OleDbDataAdapter(sql, baglanti)
        Dim ds As New DataSet
        verial.Fill(ds)
        GridView1.DataSource = ds.Tables(0)
        GridView1.DataBind()
        MultiView1.ActiveViewIndex = 0
    End Sub

    Protected Sub LinkButton2_Click(sender As Object, e As System.EventArgs) Handles LinkButton2.Click
        Dim yol, sql As String
        yol = Server.MapPath("veri.accdb")
        sql = "select * from notlar"
        Dim baglanti As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & yol)
        Dim verial As New OleDbDataAdapter(sql, baglanti)
        Dim ds As New DataSet
        verial.Fill(ds)
        GridView2.DataSource = ds.Tables(0)
        GridView2.DataBind()
        MultiView1.ActiveViewIndex = 1
    End Sub

    Protected Sub LinkButton3_Click(sender As Object, e As System.EventArgs) Handles LinkButton3.Click
        MultiView1.ActiveViewIndex = 2
    End Sub

    Protected Sub LinkButton4_Click(sender As Object, e As System.EventArgs) Handles LinkButton4.Click
        Session.Abandon()
        Response.Redirect("Default.aspx")
    End Sub

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim kullaniciadi, matematik, turkce, yol, sql As String
        kullaniciadi = TextBox1.Text
        matematik = TextBox2.Text
        turkce = TextBox3.Text
        yol = Server.MapPath("veri.accdb")
        sql = "insert into notlar(kadi,matematik,turkce) values('" & kullaniciadi & "','" & matematik & "','" & turkce & "')"
        Dim baglanti As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & yol)
        Dim komut As New OleDbCommand
        komut.Connection = baglanti
        komut.CommandText = sql
        baglanti.Open()
        komut.ExecuteNonQuery()
        baglanti.Close()
        Label2.Text = "Notlar Sisteme Girilmiştir"
    End Sub
End Class
