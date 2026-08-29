using IronPdf.Rendering;
using IronPdf;
namespace IronPdf.Examples.HowTo.CreateNewPdfs
{
    public static class Section4
    {
        public static void Run()
        {
            // Instantiate Renderer
            var renderer = new ChromePdfRenderer();
            renderer.RenderingOptions.EnableJavaScript = true;
            renderer.RenderingOptions.PrintHtmlBackgrounds = true;
            renderer.RenderingOptions.PaperFit.UseResponsiveCssRendering(1800);
            renderer.RenderingOptions.WaitFor.RenderDelay(5000);
            renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Print;
            
            // Create a PDF from a URL or local file path
            var pdf = renderer.RenderUrlAsPdf("https://ironpdf.com/");
            
            // Export to a file or Stream
            pdf.SaveAs("url.pdf");
        }
    }
}