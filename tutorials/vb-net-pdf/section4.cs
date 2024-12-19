using IronPdf;
namespace IronPdf.Examples.Tutorial.VbNetPdf
{
    public static class Section4
    {
        public static void Run()
        {
            Imports IronPdf
            
            Module Module1
                Sub Main()
                    Dim renderer = New ChromePdfRenderer()
                    renderer.RenderingOptions.CssMediaType = Rendering.PdfCssMediaType.Print
                    renderer.RenderingOptions.PrintHtmlBackgrounds = False
                    renderer.RenderingOptions.PaperOrientation = Rendering.PdfPaperOrientation.Landscape
                    renderer.RenderingOptions.WaitFor.RenderDelay(150)
                    Dim document = renderer.RenderHtmlFileAsPdf("C:\Users\jacob\Dropbox\Visual Studio\Tutorials\VB.Net.Pdf.Tutorial\VB.Net.Pdf.Tutorial\slideshow\index.html")
                    document.SaveAs("Html5.pdf")
                    System.Diagnostics.Process.Start("Html5.pdf")
                End Sub
            End Module
        }
    }
}