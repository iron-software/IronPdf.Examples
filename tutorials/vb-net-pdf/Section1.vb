Imports IronPdf

Namespace IronPdf.Examples.Tutorial.VbNetPdf
    Module Section1
        Public Sub Run()
            ' PdfDocument has no parameterless constructor; a blank page is
            ' sized in millimetres.
            Dim PDF As New IronPdf.PdfDocument(210, 297)
            PDF.SaveAs("output.pdf")
        End Sub
    End Module
End Namespace
