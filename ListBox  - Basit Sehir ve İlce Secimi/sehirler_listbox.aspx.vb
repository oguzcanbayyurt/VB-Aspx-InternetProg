
Partial Class sehirler_listbox
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
       
    End Sub

    Protected Sub ListBox1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Label1.Text = ListBox1.SelectedItem.Text
        Label2.Text = ListBox1.SelectedItem.Value
    End Sub
End Class
