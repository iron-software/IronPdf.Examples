Module Module1
    Sub Main()
        Dim renderer = New ChromePdfRenderer()
        Dim document = renderer.RenderHtmlAsPdf("<h1> My First PDF in VB.NET</h1>")
        document.SaveAs("MyFirst.pdf")
    End Sub
End Module