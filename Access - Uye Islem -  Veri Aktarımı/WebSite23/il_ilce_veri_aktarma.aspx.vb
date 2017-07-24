Imports System.Data.OleDb
Imports System.Data

Partial Class il_ilce_veri_aktarma
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim yol, sql As String
        yol = Server.MapPath("veri.accdb")
        sql = "Select * from il"
        Dim baglanti As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & yol)
        Dim verial As New OleDbDataAdapter(sql, baglanti)
        Dim ds As New DataSet
        verial.Fill(ds)
        DropDownList1.DataSource = ds.Tables(0)
        DropDownList1.DataTextField = "il_adi"
        DropDownList1.DataValueField = "plaka"
        DropDownList1.DataBind()

    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged
        Dim yol, sql As String
        yol = Server.MapPath("veri.accdb")
        sql = "Select * from ilce where plaka=" & DropDownList1.SelectedValue
        Dim baglanti As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & yol)
        Dim verial As New OleDbDataAdapter(sql, baglanti)
        Dim ds As New DataSet
        verial.Fill(ds)
        ListBox1.DataSource = ds.Tables(0)
        ListBox1.DataTextField = "ilce_adi"
        ListBox1.DataValueField = "plaka"
        ListBox1.DataBind()
    End Sub
End Class
