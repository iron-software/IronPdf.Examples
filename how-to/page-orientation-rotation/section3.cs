using IronPdf.Rendering;
using IronPdf;
namespace ironpdf.PageOrientationRotation
{
    public class Section3
    {
        public void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("rotatedLandscape.pdf");
            
            PdfPageRotation rotation = pdf.GetPageRotation(1);
        }
    }
}