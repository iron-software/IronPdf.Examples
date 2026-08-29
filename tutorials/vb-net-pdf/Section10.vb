Imports IronPdf

Namespace IronPdf.Examples.Tutorial.VbNetPdf
    Module Section10
        Public Sub Run()
            ' The page has a pdf open by this point.
            Dim pdf = PdfDocument.FromFile("report.pdf")

            pdf.RemovePage(pdf.PageCount - 1)
        End Sub
    End Module
End Namespace
