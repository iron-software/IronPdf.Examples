using System.Linq;
using IronPdf;
namespace IronPdf.Examples.HowTo.ManageFonts
{
    public static class Section2
    {
        public static void Run()
        {
            // Import PDF
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");
            
            // Find font
            PdfFont font = pdf.Fonts["SpecialFontName"];
        }
    }
}