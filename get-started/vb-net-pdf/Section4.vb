Imports IronPdf

Namespace IronPdf.Examples.GettingStarted.VbNetPdf
    Module Section4
        Public Sub Run()
            Dim renderer = New ChromePdfRenderer()
            Dim Html = "Hello {0}"
            Html = String.Format(Html, "World")
            Dim document = renderer.RenderHtmlAsPdf(Html)
            document.SaveAs("HtmlTemplate.pdf")
            Process.Start(New ProcessStartInfo("HtmlTemplate.pdf") With {.UseShellExecute = True})
        End Sub
    End Module
End Namespace
