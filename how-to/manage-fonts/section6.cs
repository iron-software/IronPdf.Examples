using System.Linq;
using IronPdf;
namespace IronPdf.Examples.HowTo.ManageFonts
{
    public static class Section6
    {
        public static void Run()
        {
            // Import PDF
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");
            
            byte[] fontData = System.IO.File.ReadAllBytes("dir/to/font.ttf");
            // Get and replace Font
            pdf.Fonts["Courier"].ReplaceWith(fontData);
        }
    }
}