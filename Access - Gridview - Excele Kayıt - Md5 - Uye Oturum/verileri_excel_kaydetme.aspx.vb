Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Partial Class _Default
    Inherits System.Web.UI.Page


    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim yol, sql, a As String
        yol = Server.MapPath("veri.accdb")
        sql = "select * from uyeler"
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
