Imports System.Data
Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.IO

Partial Class oturum_acan_kullanici
    Inherits System.Web.UI.Page
    Dim x As String

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        x = Session("kadi")
        Label1.Text = x
    End Sub

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click

        Dim yol, sql As String
        yol = Server.MapPath("veri.accdb")
        sql = "select * from uyeler where kadi='" & x & "'"
        Dim baglanti As New OleDbConnection("provider=microsoft.ACE.OLEDB.12.0;Data Source=" & yol)
        Dim verial As New OleDbDataAdapter(sql, baglanti)
        Dim ds As New DataSet
        verial.Fill(ds)
        GridView1.DataSource = ds.Tables(0)
        GridView1.DataBind()
    End Sub

    Protected Sub LinkButton1_Click(sender As Object, e As System.EventArgs) Handles LinkButton1.Click
        Dim ek As String
        ek = "attachment;filename=uye.xls"
        Response.ClearContent()
        Response.AddHeader("content-disposition", ek)
        Response.ContentType = "application/ms-excel"
        Dim sw As New StringWriter
        Dim htw As New HtmlTextWriter(sw)
        GridView1.GridLines = GridLines.Both
        GridView1.RenderControl(htw)
        Response.Write(sw.ToString)
        Response.End()
    End Sub
    Public Overrides Sub VerifyRenderingInServerForm(control As System.Web.UI.Control)

    End Sub

End Class
