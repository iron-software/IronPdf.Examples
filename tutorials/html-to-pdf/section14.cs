using IronPdf.Rendering;
using IronPdf;
namespace IronPdf.Examples.Tutorial.HtmlToPdf
{
    public static class Section14
    {
        public static void Run()
        {
            renderer.RenderingOptions.PaperSize = PdfPaperSize.A4;
            renderer.RenderingOptions.PaperOrientation = PdfPaperOrientation.Landscape;
        }
    }
}