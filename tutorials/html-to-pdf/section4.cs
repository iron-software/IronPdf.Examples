using IronPdf.Rendering;
using IronPdf;
namespace IronPdf.Examples.Tutorial.HtmlToPdf
{
    public static class Section4
    {
        public static void Run()
        {
            renderer.RenderingOptions.CssMediaType = PdfCssMediaType.Screen;
            // or
            renderer.RenderingOptions.CssMediaType = PdfCssMediaType.Print;
        }
    }
}