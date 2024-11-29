using IronPdf.Fonts;
using IronPdf;
namespace ironpdf.ManageFonts
{
    public class Section3
    {
        public void Run()
        {
            // Import PDF
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");
            
            // Add font
            pdf.Fonts.Add("Helvetica");
        }
    }
}