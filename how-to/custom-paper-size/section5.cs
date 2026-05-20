using IronPdf.Editing;
using IronPdf;
namespace IronPdf.Examples.HowTo.CustomPaperSize
{
    public static class Section5
    {
        public static void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("customPaperSize.pdf");
            
            pdf.ExtendPage(0, 50, 0, 0, 0, MeasurementUnit.Millimeter);
            
            pdf.SaveAs( "extendedLeftSide.pdf");
        }
    }
}