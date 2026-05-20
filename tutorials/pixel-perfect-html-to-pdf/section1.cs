using IronPdf;
namespace IronPdf.Examples.Tutorial.PixelPerfectHtmlToPdf
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Generate Pixel-Perfect PDFs Instantly
            var Renderer = new IronPdf.ChromePdfRenderer();
            Renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Print;
            Renderer.RenderHtmlAsPdf("<html>Your HTML content here</html>").SaveAs("output.pdf");
        }
    }
}