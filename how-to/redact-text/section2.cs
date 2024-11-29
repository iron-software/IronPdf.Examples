using IronSoftware.Drawing;
using IronPdf;
namespace ironpdf.RedactText
{
    public class Section2
    {
        public void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("novel.pdf");
            
            RectangleF rectangle = new RectangleF(5, 700, 50, 50);
            
            // Redact region on coordinates(5,700) with width and height 50 pixels
            pdf.RedactRegionsOnAllPages(rectangle);
            
            pdf.SaveAs("redactedRegion.pdf");
        }
    }
}