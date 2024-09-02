Imports IronPdf
Imports IronSoftware.Drawing

Module Module1
    Sub Main()
        Dim renderer = New ChromePdfRenderer()
        renderer.RenderingOptions.CssMediaType = Rendering.PdfCssMediaType.Print
        renderer.RenderingOptions.PrintHtmlBackgrounds = False
        renderer.RenderingOptions.PaperOrientation = Rendering.PdfPaperOrientation.Landscape
        renderer.RenderingOptions.WaitFor.RenderDelay(150)
        renderer.RenderingOptions.TextHeader.CenterText = "VB.NET PDF Slideshow"
        renderer.RenderingOptions.TextHeader.DrawDividerLine = True
        renderer.RenderingOptions.TextHeader.FontSize = "13"
        renderer.RenderingOptions.TextFooter.RightText = "page {page} of {total-pages}"
        renderer.RenderingOptions.TextFooter.Font = FontTypes.Arial
        renderer.RenderingOptions.TextFooter.FontSize = "9"
        Dim document = renderer.RenderHtmlFileAsPdf("..\..\slideshow\index.html")
        document.SaveAs("Html5WithHeader.pdf")
        System.Diagnostics.Process.Start("Html5WithHeader.pdf")
    End Sub
End Module