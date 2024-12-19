using IronPdf.Fonts;
using IronPdf;
namespace IronPdf.Examples.HowTo.ManageFonts
{
    public static class Section3
    {
        public static void Run()
        {
            // Import PDF
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");
            
            // Add font
            pdf.Fonts.Add("Helvetica");
        }
    }
}