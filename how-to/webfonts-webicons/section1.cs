using IronPdf;
namespace IronPdf.Examples.HowTo.WebfontsWebicons
{
    public static class Section1
    {
        public static void Run()
        {
            // HTML contains webfont
            var html = @"<link href=""https://fonts.googleapis.com/css?family=Lobster"" rel=""stylesheet"">
            <p style=""font-family: 'Lobster', serif; font-size:30px;"" > Hello Google Fonts</p>";
            
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Wait for font to load
            renderer.RenderingOptions.WaitFor.AllFontsLoaded(2000);
            
            // Render HTML to PDF
            PdfDocument pdf = renderer.RenderHtmlAsPdf(html);
            
            // Export the PDF
            pdf.SaveAs("font-test.pdf");
        }
    }
}