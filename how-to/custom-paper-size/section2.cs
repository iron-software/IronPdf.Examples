using IronPdf.Editing;
using IronPdf;
namespace ironpdf.CustomPaperSize
{
    public class Section2
    {
        public void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("customPaperSize.pdf");
            
            pdf.ExtendPage(0, 50, 0, 0, 0, MeasurementUnit.Millimeter);
            
            pdf.SaveAs( "extendedLeftSide.pdf");
        }
    }
}