Imports IronPdf

Namespace IronPdf.Examples.GettingStarted.VbNetPdf
    Module Section2
        Public Sub Run()
            Dim renderer = New ChromePdfRenderer()
            Dim document = renderer.RenderHtmlAsPdf("<h1> My First PDF in VB.NET</h1>")
            document.SaveAs("MyFirst.pdf")
            Process.Start(New ProcessStartInfo("MyFirst.pdf") With {.UseShellExecute = True})
        End Sub
    End Module
End Namespace
