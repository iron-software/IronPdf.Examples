using IronPdf;
namespace IronPdf.Examples.HowTo.ViewportZoom
{
    public static class Section4
    {
        public static void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Fit to page rendering
            renderer.RenderingOptions.PaperFit.UseFitToPageRendering();
            
            // Render web URL to PDF
            PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");
            
            pdf.SaveAs("fitToPage.pdf");
        }
    }
}