using IronPdf;
namespace IronPdf.Examples.HowTo.ViewportZoom
{
    public static class Section1
    {
        public static void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Chrome default rendering
            renderer.RenderingOptions.PaperFit.UseChromeDefaultRendering();
            
            // Render web URL to PDF
            PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");
            
            pdf.SaveAs("chromeDefault.pdf");
        }
    }
}