using IronPdf;
namespace IronPdf.Examples.HowTo.ViewportZoom
{
    public static class Section5
    {
        public static void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            int width = 90;
            int margin = 0;
            
            // Continuous feed rendering
            renderer.RenderingOptions.PaperFit.UseContinuousFeedRendering(width, margin);
            
            // Render web URL to PDF
            PdfDocument pdf = renderer.RenderHtmlFileAsPdf("receipt.html");
            
            pdf.SaveAs("continuousFeed.pdf");
        }
    }
}