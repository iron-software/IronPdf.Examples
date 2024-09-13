Imports IronPdf

Module Module1
    Sub Main()
        Dim renderer = New ChromePdfRenderer()
        Dim Html = "Hello {0}"
        String.Format(Html, "World")
        Dim document = renderer.RenderHtmlAsPdf(Html)
        document.SaveAs("HtmlTemplate.pdf")
        System.Diagnostics.Process.Start("HtmlTemplate.pdf")
    End Sub
End Module