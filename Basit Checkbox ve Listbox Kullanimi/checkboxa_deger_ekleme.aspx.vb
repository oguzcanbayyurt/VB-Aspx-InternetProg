
Partial Class checkboxa_deger_ekleme
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        CheckBoxList1.Items.Clear()
        CheckBoxList1.Items.Add("İngilizce")
        CheckBoxList1.Items.Add("Almanca")
        CheckBoxList1.Items.Add("İtalyanca")
        CheckBoxList1.Items.Add("Fransızca")
    End Sub
End Class
