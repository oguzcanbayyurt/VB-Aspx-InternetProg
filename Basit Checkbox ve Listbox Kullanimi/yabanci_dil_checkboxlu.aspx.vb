
Partial Class yabanci_dil_checkboxlu
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        Dim adet As Integer
        adet = CheckBoxList1.Items.Count
        For i As Integer = 0 To adet - 1
            If CheckBoxList1.Items(i).Selected = True Then
                ListBox1.Items.Add(CheckBoxList1.Items(i).Text)
            End If
        Next
    End Sub
End Class
