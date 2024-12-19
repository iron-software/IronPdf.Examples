using IronPdf.Rendering;
using IronPdf;
namespace IronPdf.Examples.HowTo.PageOrientationRotation
{
    public static class Section3
    {
        public static void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("rotatedLandscape.pdf");
            
            PdfPageRotation rotation = pdf.GetPageRotation(1);
        }
    }
}