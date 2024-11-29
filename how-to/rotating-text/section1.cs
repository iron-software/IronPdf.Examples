using System.Linq;
using IronPdf;
namespace ironpdf.RotatingText
{
    public class Section1
    {
        public void Run()
        {
            // Import PDF
            PdfDocument pdf = PdfDocument.FromFile("multi-page.pdf");
            
            // Set rotation for a single page
            pdf.SetPageRotation(0, PdfPageRotation.Clockwise90);
            
            // Set rotation for multiple pages
            pdf.SetPageRotations(Enumerable.Range(1,3), PdfPageRotation.Clockwise270);
            
            // Set rotation for the entire document
            pdf.SetAllPageRotations(PdfPageRotation.Clockwise180);
            
            pdf.SaveAs("rotated.pdf");
        }
    }
}