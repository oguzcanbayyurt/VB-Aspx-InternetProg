Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Partial Class gridview_siralama
    Inherits System.Web.UI.Page

    Protected Sub GridView1_Sorting(sender As Object, e As System.Web.UI.WebControls.GridViewSortEventArgs) Handles GridView1.Sorting
        Dim yol, sql As String
        yol = Server.MapPath("veri.accdb")
        sql = "select * from uyeler"
        Dim baglanti As New OleDbConnection("provider=microsoft.ACE.OLEDB.12.0;Data Source=" & yol)
        Dim verial As New OleDbDataAdapter(sql, baglanti)
        Dim ds As New DataSet
        verial.Fill(ds)
        Dim dv As New DataView(ds.Tables(0))
        dv.Sort = e.SortExpression
        GridView1.DataSource = dv
        GridView1.DataBind()
    End Sub

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim yol, sql As String
        yol = Server.MapPath("veri.accdb")
        sql = "select * from uyeler"
        Dim baglanti As New OleDbConnection("provider=microsoft.ACE.OLEDB.12.0;Data Source=" & yol)
        Dim verial As New OleDbDataAdapter(sql, baglanti)
        Dim ds As New DataSet
        verial.Fill(ds)
        GridView1.DataSource = ds.Tables(0)
        GridView1.DataBind()
    End Sub
    'Not:Aspx Sayfasında GridView'in Propertisinden->Allow Storting'i True Yap.A'dan Z'ye sıralama yapar.
End Class
