using IronPdf;
namespace ironpdf.PixelPerfectHtmlToPdf
{
    public class Section1
    {
        public void Run()
        {
            // Pixel Perfect HTML Formatting Settings
            IronPdf.ChromePdfRenderer renderer = new IronPdf.ChromePdfRenderer();
            renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Print; // or Screen
        }
    }
}