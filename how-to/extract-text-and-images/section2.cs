using System.Linq;
using IronPdf;
namespace IronPdf.Examples.HowTo.ExtractTextAndImages
{
    public static class Section2
    {
        public static void Run()
        {
            // Open PDF from file
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");
            
            // Extract text by lines
            var lines = pdf.Pages[0].Lines;
            
            // Extract text by characters
            var characters = pdf.Pages[0].Characters;
            
            File.WriteAllLines("lines.txt", lines.Select(l => $"at Y={l.BoundingBox.Bottom:F2}: {l.Contents}"));
        }
    }
}