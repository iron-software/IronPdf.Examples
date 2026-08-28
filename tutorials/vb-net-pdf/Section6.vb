Imports IronPdf

Namespace IronPdf.Examples.Tutorial.VbNetPdf
    Module Section6
        Public Sub Run()
            Form1_Load(Nothing, EventArgs.Empty)
        End Sub

        ' RenderThisPageAsPdf writes the ASP.NET page it is called from, so this
        ' only does anything inside a Web Forms request.
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim PdfOptions = New IronPdf.ChromePdfRenderOptions()
            IronPdf.AspxToPdf.RenderThisPageAsPdf(AspxToPdf.FileBehavior.Attachment, "MyPdf.pdf", PdfOptions)
        End Sub
    End Module
End Namespace
