using IronSoftware.Drawing;
using System.IO;
using IronPdf;
namespace IronPdf.Examples.HowTo.DrawTextAndBitmap
{
    public static class Section4
    {
        public static void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>testing</h1>");
            
            // Add custom font to the PDF
            byte[] fontByte = File.ReadAllBytes(@".\PixelifySans-VariableFont_wght.ttf");
            var addedFont = pdf.Fonts.Add(fontByte);
            
            // Draw text on PDF
            pdf.DrawText("Iron Software", addedFont.Name, FontSize: 12, PageIndex: 0, X: 100, Y: 600, Color.Black, Rotation: 0);
            
            pdf.SaveAs("drawCustomFont.pdf");
        }
    }
}