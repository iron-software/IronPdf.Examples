Imports IronPdf

Namespace IronPdf.Examples.GettingStarted.VbNetPdf
    Module Section9
        Public Sub Run()
            Dim renderer = New ChromePdfRenderer()
            Dim pdf = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf")
            Dim stamp = New Editing.HtmlStamper()
            stamp.Html = "<h2>Completed</h2>"
            stamp.Opacity = 50
            stamp.Rotation = -45
            stamp.VerticalAlignment = Editing.VerticalAlignment.Top
            stamp.VerticalOffset = New Editing.Length(10)
            pdf.ApplyStamp(stamp)
            pdf.SaveAs("Stamped.pdf")
        End Sub
    End Module
End Namespace
