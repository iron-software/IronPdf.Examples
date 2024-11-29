using System.Collections.Generic;
using IronPdf;
namespace ironpdf.ManageFonts
{
    public class Section1
    {
        public void Run()
        {
            // Import PDF
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");
            
            // Retreive font
            PdfFontCollection fonts = pdf.Fonts;
        }
    }
}