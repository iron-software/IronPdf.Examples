using IronPdf;
namespace IronPdf.Examples.HowTo.BackgroundForeground
{
    public static class Section1
    {
        public static void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Main HTML content</h1>");
            
            // Render background
            PdfDocument background = renderer.RenderHtmlAsPdf("<body style='background-color: cyan;'></body>");
            
            // Add background
            pdf.AddBackgroundPdf(background);
            
            pdf.SaveAs("addBackground.pdf");
        }
    }
}