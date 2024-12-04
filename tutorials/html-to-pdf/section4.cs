using IronPdf.Rendering;
using IronPdf;
namespace ironpdf.HtmlToPdf
{
    public class Section4
    {
        public void Run()
        {
            renderer.RenderingOptions.CssMediaType = PdfCssMediaType.Screen;
            // or
            renderer.RenderingOptions.CssMediaType = PdfCssMediaType.Print;
        }
    }
}