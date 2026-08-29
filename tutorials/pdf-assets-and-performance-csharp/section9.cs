using IronPdf.Fonts;
using System.Collections.Generic;
using IronPdf;
namespace IronPdf.Examples.Tutorial.PdfAssetsAndPerformanceCsharp
{
    public static class Section9
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