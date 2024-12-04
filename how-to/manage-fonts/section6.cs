using System.Linq;
using IronPdf;
namespace ironpdf.ManageFonts
{
    public class Section6
    {
        public void Run()
        {
            // Import PDF
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");
            
            byte[] fontData = System.IO.File.ReadAllBytes("dir/to/font.ttf");
            // Get and replace Font
            pdf.Fonts["Courier"].ReplaceWith(fontData);
        }
    }
}