Imports System.Data
Imports System.Data.OleDb
Partial Class ogrenci
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
        sql = "select * from notlar where kadi='" & Session("kadi") & "'"
        Dim baglanti As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & yol)
        Dim verial As New OleDbDataAdapter(sql, baglanti)
        Dim ds As New DataSet
        verial.Fill(ds)
        GridView2.DataSource = ds.Tables(0)
        GridView2.DataBind()
        MultiView1.ActiveViewIndex = 1
    End Sub

    Protected Sub LinkButton3_Click(sender As Object, e As System.EventArgs) Handles LinkButton3.Click
        Session.Abandon()
        Response.Redirect("Default.aspx")
    End Sub
End Class
