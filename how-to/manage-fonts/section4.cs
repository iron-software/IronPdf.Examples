using System.Linq;
using IronPdf;
namespace ironpdf.ManageFonts
{
    public class Section4
    {
        public void Run()
        {
            // Import PDF
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");
            
            // Select which font to embed
            PdfFont targetFont = pdf.Fonts["MyCustomFont"];
            
            // Add the font
            byte[] fontData = System.IO.File.ReadAllBytes("dir/to/font.ttf");
            pdf.Fonts.Add(fontData);
            
            // Embed the font
            pdf.Fonts.Last().Embed(fontData);
        }
    }
}