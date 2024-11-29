using IronPdf;
namespace ironpdf.ViewportZoom
{
    public class Section5
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Continuous feed rendering
            renderer.RenderingOptions.PaperFit.UseContinuousFeedRendering();
            
            // Render web URL to PDF
            PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");
            
            pdf.SaveAs("continuousFeed.pdf");
        }
    }
}