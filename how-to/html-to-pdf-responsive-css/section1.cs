using IronPdf.Rendering;
using IronPdf;
namespace IronPdf.Examples.HowTo.HtmlToPdfResponsiveCss
{
    public static class Section1
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