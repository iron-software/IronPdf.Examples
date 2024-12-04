using System.Linq;
using IronPdf;
namespace ironpdf.ManageFonts
{
    public class Section2
    {
        public void Run()
        {
            // Import PDF
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");
            
            // Find font
            PdfFont font = pdf.Fonts["SpecialFontName"];
        }
    }
}