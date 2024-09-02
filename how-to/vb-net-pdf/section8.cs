Imports IronPdf

Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
    Dim PdfOptions = New IronPdf.ChromePdfRenderOptions()
    IronPdf.AspxToPdf.RenderThisPageAsPDF(AspxToPdf.FileBehavior.Attachment, "MyPdf.pdf", PdfOptions)
End Sub