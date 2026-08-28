Imports IronPdf

Namespace IronPdf.Examples.Tutorial.VbNetPdf
    Module Section2
        Public Sub Run()
            Dim renderer = New ChromePdfRenderer()
            Dim document = renderer.RenderHtmlAsPdf("<h1> My First PDF in VB.NET</h1>")
            document.SaveAs("MyFirst.pdf")
        End Sub
    End Module
End Namespace
