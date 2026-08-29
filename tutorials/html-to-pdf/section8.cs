using IronPdf.Rendering;
using IronPdf;
namespace IronPdf.Examples.Tutorial.HtmlToPdf
{
    public static class Section8
    {
        public static void Run()
        {
            // The docs page has the renderer open before this snippet.
            var renderer = new ChromePdfRenderer();

            // Configure for optimal responsive design handling in HTML to PDF
            
            renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Print;
        }
    }
}