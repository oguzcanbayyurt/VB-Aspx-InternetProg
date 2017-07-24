
Partial Class dosya
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        If FileUpload1.HasFile Then
            FileUpload1.SaveAs(Server.MapPath("resimler/" & FileUpload1.FileName))
            Image1.ImageUrl = "resimler/" & FileUpload1.FileName
        Else
            Label4.Text = "Lütfen Dosya Seçiniz"
        End If
        If FileUpload1.HasFile Then
            Dim yol As String = FileUpload1.FileName
            Dim dosya As String = System.IO.Path.GetFileName(yol)
            Dim postdosya As HttpPostedFile
            postdosya = FileUpload1.PostedFile
            postdosya.SaveAs(Server.MapPath("resimler/" & dosya))
            Label1.Text = dosya
            Label2.Text = postdosya.ContentType
            Label3.Text = postdosya.ContentLength.ToString()
            Image1.ImageUrl = "resimler/" & dosya
        End If
    End Sub
End Class
