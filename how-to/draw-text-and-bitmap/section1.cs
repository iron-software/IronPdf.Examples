using IronSoftware.Drawing;
using IronPdf;
namespace ironpdf.DrawTextAndBitmap
{
    public class Section1
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>testing</h1>");
            
            // Draw text on PDF
            pdf.DrawText("Some text", FontTypes.TimesNewRoman.Name, FontSize: 12, PageIndex: 0, X: 100, Y: 100, Color.Black, Rotation: 0);
            
            pdf.SaveAs("drawText.pdf");
        }
    }
}