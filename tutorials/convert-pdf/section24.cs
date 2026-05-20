using IronPdf;
namespace IronPdf.Examples.Tutorial.ConvertPdf
{
    public static class Section24
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