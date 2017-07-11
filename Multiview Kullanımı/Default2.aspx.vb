
Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub LinkButton1_Click(sender As Object, e As System.EventArgs) Handles LinkButton1.Click
        MultiView1.ActiveViewIndex = 0
    End Sub

    Protected Sub LinkButton2_Click(sender As Object, e As System.EventArgs) Handles LinkButton2.Click
        MultiView1.ActiveViewIndex = 1
    End Sub

    Protected Sub LinkButton3_Click(sender As Object, e As System.EventArgs) Handles LinkButton3.Click
        MultiView1.ActiveViewIndex = 2
    End Sub
End Class
