using IronPdf.Fonts;
using IronPdf;
namespace ironpdf.ManageFonts
{
    public class Section5
    {
        public void Run()
        {
            // Import PDF
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");
            
            // Get fonts
            PdfFontCollection fonts = pdf.Fonts;
            
            // Unembed a font
            pdf.Fonts[0].Unembed();
        }
    }
}