using IronPdf;
namespace IronPdf.Examples.Tutorial.HtmlToPdf
{
    public static class Section8
    {
        public static void Run()
        {
            // Configure for optimal responsive design handling in HTML to PDF
            
            renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Print;
        }
    }
}