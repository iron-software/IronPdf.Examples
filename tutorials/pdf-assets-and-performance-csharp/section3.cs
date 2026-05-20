using IronPdf.Rendering;
using IronPdf;
namespace IronPdf.Examples.Tutorial.PdfAssetsAndPerformanceCsharp
{
    public static class Section3
    {
        public static void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Change the paper size to small
            renderer.RenderingOptions.SetCustomPaperSizeinPixelsOrPoints(600, 400);
            
            // Choose screen or print CSS media
            renderer.RenderingOptions.CssMediaType = PdfCssMediaType.Print;
            
            // Render HTML to PDF
            PdfDocument pdf = renderer.RenderHtmlFileAsPdf("tableHeader.html");
            
            pdf.SaveAs("tableHeader.pdf");
        }
    }
}