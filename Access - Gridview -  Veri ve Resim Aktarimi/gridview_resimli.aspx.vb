Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Partial Class gridview_resimli
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim yol, sql As String
        yol = Server.MapPath("veri.accdb")
        sql = "select * from deneme"
        Dim baglanti As New OleDbConnection("provider=microsoft.ACE.OLEDB.12.0;Data Source=" & yol)
        Dim verial As New OleDbDataAdapter(sql, baglanti)
        Dim ds As New DataSet
        verial.Fill(ds)
        GridView1.DataSource = ds.Tables(0)
        GridView1.DataBind()
    End Sub
End Class
