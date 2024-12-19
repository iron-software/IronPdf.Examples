using IronPdf;
namespace IronPdf.Examples.HowTo.BaseUrls
{
    public static class Section1
    {
        public static void Run()
        {
            // Instantiate ChromePdfRenderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            string baseUrl = @"C:\site\assets\";
            string html = "<img src='icons/iron.png'>";
            
            // Render HTML to PDF
            PdfDocument pdf = renderer.RenderHtmlAsPdf(html, baseUrl);
            
            // Export PDF
            pdf.SaveAs("html-with-assets.pdf");
        }
    }
}