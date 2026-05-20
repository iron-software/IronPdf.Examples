using System.Linq;
using IronPdf;
namespace IronPdf.Examples.HowTo.ManageFonts
{
    public static class Section5
    {
        public static void Run()
        {
            // Import PDF
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");
            
            // Add the font
            byte[] fontData = System.IO.File.ReadAllBytes("dir/to/font.ttf");
            
            // Embed the font
            pdf.Fonts.Last().Embed(fontData);
        }
    }
}