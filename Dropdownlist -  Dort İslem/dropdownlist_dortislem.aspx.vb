
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged
        Dim a, b, islem, sonuc As Double
        a = TextBox1.Text
        b = TextBox2.Text
        islem = DropDownList1.SelectedValue
        If islem = 1 Then
            sonuc = a + b
            Label1.Text = sonuc
        ElseIf islem = 2 Then
            sonuc = a - b
            Label1.Text = sonuc
        ElseIf islem = 3 Then
            sonuc = a * b
            Label1.Text = sonuc
        ElseIf islem = 4 Then
            sonuc = a / b
            Label1.Text = sonuc
        End If
    End Sub
End Class
