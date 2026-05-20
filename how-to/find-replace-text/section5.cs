using System.IO;
using IronPdf;
namespace IronPdf.Examples.HowTo.FindReplaceText
{
    public static class Section5
    {
        public static void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Use custom font .NET6</h1>");
            
            string oldText = ".NET6";
            string newText = ".NET7";
            
            // Add custom font
            byte[] fontByte = File.ReadAllBytes(@".\PixelifySans-VariableFont_wght.ttf");
            var pdfFont = pdf.Fonts.Add(fontByte);
            
            // Use custom font
            pdf.ReplaceTextOnPage(0, oldText, newText, pdfFont, 24);
            
            pdf.SaveAs("replaceCustomText.pdf");
        }
    }
}