
Partial Class Menü_secimi
    Inherits System.Web.UI.Page

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged
        Dim sec As String
        sec = DropDownList1.SelectedValue
        If sec = "corbalar" Then
            Label3.Text = "Mercimek"
            Image1.ImageUrl = "Resimler/mercimek.jpg"
        ElseIf sec = "AraYemekler" Then
            Label3.Text = "İmamBayıldı"
            Image1.ImageUrl = "Resimler/İmamBayıldı.jpg"
        ElseIf sec = "Tatlılar" Then
            Label3.Text = "Sütlaç"
            Image1.ImageUrl = "Resimler/Sütlaç.jpg"
        End If
    End Sub
End Class
