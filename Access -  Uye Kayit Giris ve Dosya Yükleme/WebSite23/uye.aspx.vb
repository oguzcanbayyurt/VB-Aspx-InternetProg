
Partial Class Default3
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim x As String
        x = Session("kadi")
        Label1.Text = x
    End Sub
End Class
