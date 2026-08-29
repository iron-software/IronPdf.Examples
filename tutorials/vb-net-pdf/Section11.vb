Imports IronPdf

Namespace IronPdf.Examples.Tutorial.VbNetPdf
    Module Section11
        Public Sub Run()
            ' The page has a pdf open by this point.
            Dim pdf = PdfDocument.FromFile("report.pdf")

            ' Save with a strong encryption password.
            pdf.Password = "my.secure.password"
            pdf.SaveAs("secured.pdf")
        End Sub
    End Module
End Namespace
