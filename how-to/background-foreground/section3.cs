using IronPdf;
namespace IronPdf.Examples.HowTo.BackgroundForeground
{
    public static class Section3
    {
        public static void Run()
        {
            string backgroundHtml = @"
            <div style = 'background-color: cyan; height: 100%;'></div>
            <div style = 'page-break-after: always;'></div>
            <div style = 'background-color: lemonchiffon; height: 100%;'></div>";
            
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Main HTML content</h1>");
            
            // Render background
            PdfDocument background = renderer.RenderHtmlAsPdf(backgroundHtml);
            
            // Use page 2 as background
            pdf.AddBackgroundPdf(background, 1);
            
            pdf.SaveAs("addBackgroundFromPage2.pdf");
        }
    }
}