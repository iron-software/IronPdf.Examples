using System.Linq;
using IronPdf;
namespace IronPdf.Examples.HowTo.AccessPdfDomObject
{
    public static class Section3
    {
        public static void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("invoice.pdf");
            
            var glyph = pdf.Pages.First().ObjectModel.TextObjects.First().GetGlyphInfo();
        }
    }
}