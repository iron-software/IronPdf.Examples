using IronPdf.Rendering;
using IronPdf;
namespace ironpdf.HtmlToPdf
{
    public class Section14
    {
        public void Run()
        {
            renderer.RenderingOptions.PaperSize = PdfPaperSize.A4;
            renderer.RenderingOptions.PaperOrientation = PdfPaperOrientation.Landscape;
        }
    }
}