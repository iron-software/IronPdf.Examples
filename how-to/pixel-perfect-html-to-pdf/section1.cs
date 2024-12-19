using IronPdf;
namespace IronPdf.Examples.HowTo.PixelPerfectHtmlToPdf
{
    public static class Section1
    {
        public static void Run()
        {
            // Pixel Perfect HTML Formatting Settings
            IronPdf.ChromePdfRenderer renderer = new IronPdf.ChromePdfRenderer();
            renderer.RenderingOptions.CssMediaType = PdfCssMediaType.Print; // or Screen
        }
    }
}