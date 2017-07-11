
Partial Class yabanci_diller
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim yeni_diller As New ListItem(TextBox1.Text)
        Dim sehirler As ListItem = ListBox1.Items.FindByText(TextBox1.Text)
        If sehirler IsNot Nothing Then
            Label1.Text = "Bu dil daha önce eklenmiştir."
        Else
            ListBox1.Items.Add(yeni_diller)
            Label1.Text = " "
        End If
    End Sub
End Class
