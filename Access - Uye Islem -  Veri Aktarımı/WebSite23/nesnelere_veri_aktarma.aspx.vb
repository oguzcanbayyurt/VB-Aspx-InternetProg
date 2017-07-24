Imports System.Data.OleDb
Imports System.Data

Partial Class nesnelere_veri_aktarma
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim yol, sql As String
        yol = Server.MapPath("veri.accdb")
        sql = "Select * from uyeler"
        Dim baglanti As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & yol)
        Dim verial As New OleDbDataAdapter(sql, baglanti)
        Dim ds As New DataSet
        verial.Fill(ds)
        DropDownList1.DataSource = ds.Tables(0)
        DropDownList1.DataTextField = "u_adi"
        DropDownList1.DataValueField = "kadi"
        DropDownList1.DataBind()
        ListBox1.DataSource = ds.Tables(0)
        ListBox1.DataTextField = "u_adi"
        ListBox1.DataValueField = "kadi"
        ListBox1.DataBind()
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged
        Label1.Text = DropDownList1.SelectedValue
    End Sub

    Protected Sub ListBox1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Label1.Text = ListBox1.SelectedValue
    End Sub
End Class
