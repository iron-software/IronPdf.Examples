using IronPdf.Rendering;
using IronPdf;
namespace ironpdf.PageOrientationRotation
{
    public class Section1
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Change paper orientation
            renderer.RenderingOptions.PaperOrientation = PdfPaperOrientation.Landscape;
            
            PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");
            
            pdf.SaveAs("landscape.pdf");
        }
    }
}