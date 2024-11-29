using IronSoftware.Drawing;
using IronPdf;
namespace ironpdf.DrawTextAndBitmap
{
    public class Section2
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>testing</h1>");
            
            // Open the image from file
            AnyBitmap bitmap = AnyBitmap.FromFile("ironSoftware.png");
            
            // Draw the bitmp on PDF
            pdf.DrawBitmap(bitmap, 0, 50, 250, 500, 300);
            
            pdf.SaveAs("drawImage.pdf");
        }
    }
}