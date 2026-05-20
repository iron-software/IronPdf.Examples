using IronSoftware.Drawing;
using IronPdf;
namespace IronPdf.Examples.Tutorial.CsharpEditPdfCompleteTutorial
{
    public static class Section13
    {
        public static void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>testing</h1>");
            
            // Draw text on PDF
            pdf.DrawText("Some text", FontTypes.TimesNewRoman.Name, FontSize: 12, PageIndex: 0, X: 100, Y: 100, Color.Black, Rotation: 0);
            
            pdf.SaveAs("drawText.pdf");
        }
    }
}