using System.Collections.Generic;
using IronPdf;
namespace IronPdf.Examples.HowTo.ManageFonts
{
    public static class Section1
    {
        public static void Run()
        {
            // Import PDF
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");
            
            // Retreive font
            PdfFontCollection fonts = pdf.Fonts;
        }
    }
}