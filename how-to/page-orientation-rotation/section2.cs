using IronPdf.Rendering;
using IronPdf;
namespace IronPdf.Examples.HowTo.PageOrientationRotation
{
    public static class Section2
    {
        public static void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Change paper orientation
            renderer.RenderingOptions.PaperOrientation = PdfPaperOrientation.Landscape;
            
            PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");
            
            pdf.SaveAs("landscape.pdf");
        }
    }
}