
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim odenecektutar As Integer
        odenecektutar = Val(TextBox1.Text) + (Val(TextBox1.Text) * RadioButtonList1.SelectedValue / 100)
        Label1.Text = odenecektutar
        Label2.Text = odenecektutar / DropDownList1.SelectedValue
    End Sub
End Class
