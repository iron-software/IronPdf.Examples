using IronPdf.Rendering;
using IronPdf;
namespace IronPdf.Examples.HowTo.PixelPerfectHtmlToPdf
{
    public static class Section3
    {
        public static void Run()
        {
            // Example using PdfCssMediaType.Screen
            IronPdf.ChromePdfRenderer renderer = new IronPdf.ChromePdfRenderer();
            renderer.RenderingOptions.CssMediaType = PdfCssMediaType.Screen; // or Print
            renderer.RenderingOptions.PrintHtmlBackgrounds = true;
        }
    }
}