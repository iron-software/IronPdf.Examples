using IronPdf.Rendering;
using IronPdf;
namespace IronPdf.Examples.HowTo.CustomPaperSize
{
    public static class Section2
    {
        public static void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Set paper size to A4
            renderer.RenderingOptions.PaperSize = PdfPaperSize.A4;
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Standard Paper Size</h1>");
            
            pdf.SaveAs("standardPaperSize.pdf");
        }
    }
}