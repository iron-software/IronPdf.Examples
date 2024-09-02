Imports IronPdf
Imports IronPdf.Editing

Module Module1
    Sub Main()
        Dim renderer = New ChromePdfRenderer
        Dim pdf = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf")
        Dim stamp = New HtmlStamper()
        stamp.Html = "<h2>Completed</h2>"
        stamp.Opacity = 50
        stamp.Rotation = -45
        stamp.VerticalAlignment = VerticalAlignment.Top
        stamp.VerticalOffset = New Length(10)
        pdf.ApplyStamp(stamp)
        pdf.SaveAs("C:\Path\To\Stamped.pdf")
    End Sub
End Module