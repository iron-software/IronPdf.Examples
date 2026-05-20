using IronPdf.Rendering;
using IronPdf;
namespace IronPdf.Examples.Tutorial.HtmlToPdf
{
    public static class Section5
    {
        public static void Run()
        {
            // Initialize HTML to PDF converter
            var renderer = new ChromePdfRenderer();
            
            // Configure CSS media type for rendering specified URLs
            renderer.RenderingOptions.CssMediaType = PdfCssMediaType.Print;
            
            // Screen media type shows the entire web page as displayed on screen
        }
    }
}