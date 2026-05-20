using IronPdf.Fonts;
using IronPdf;
namespace IronPdf.Examples.HowTo.ManageFonts
{
    public static class Section6
    {
        public static void Run()
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