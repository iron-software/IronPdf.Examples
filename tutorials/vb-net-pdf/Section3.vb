Imports IronPdf

Namespace IronPdf.Examples.Tutorial.VbNetPdf
    Module Section3
        Public Sub Run()
            Dim renderer = New ChromePdfRenderer()
            Dim document = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf/")
            document.SaveAs("UrlToPdf.pdf")
            Process.Start(New ProcessStartInfo("UrlToPdf.pdf") With {.UseShellExecute = True})
        End Sub
    End Module
End Namespace
