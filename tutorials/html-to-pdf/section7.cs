using IronPdf;
namespace ironpdf.HtmlToPdf
{
    public class Section7
    {
        public void Run()
        {
            renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Print;
        }
    }
}