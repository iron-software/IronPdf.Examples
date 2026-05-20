using IronPdf.Rendering;
using IronPdf;
namespace IronPdf.Examples.HowTo.CustomPaperSize
{
    public static class Section3
    {
        public static void Run()
        {
            double A4WidthInPixel = PdfPaperSize.A4.ToMillimeters().width.ToPixel();
            double A4HeightInCentimeter = PdfPaperSize.A4.ToMillimeters().height.ToCentimeter();
        }
    }
}