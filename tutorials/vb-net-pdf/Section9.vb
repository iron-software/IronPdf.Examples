Imports IronPdf

Namespace IronPdf.Examples.Tutorial.VbNetPdf
    Module Section9
        Public Sub Run()
            ' The page has a renderer and a pdf open by this point.
            Dim renderer = New ChromePdfRenderer()
            Dim pdf = renderer.RenderHtmlAsPdf("<p>Body</p>")

            pdf.PrependPdf(renderer.RenderHtmlAsPdf("<h1>Cover Page</h1><hr>"))
        End Sub
    End Module
End Namespace
