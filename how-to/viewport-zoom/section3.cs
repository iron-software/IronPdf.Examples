using IronPdf;
namespace IronPdf.Examples.HowTo.ViewportZoom
{
    public static class Section3
    {
        public static void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Scaled rendering
            renderer.RenderingOptions.PaperFit.UseScaledRendering(180);
            
            // Render web URL to PDF
            PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");
            
            pdf.SaveAs("scaled.pdf");
        }
    }
}