using IronPdf;
namespace IronPdf.Examples.HowTo.BaseUrls
{
    public static class Section3
    {
        public static void Run()
        {
            // Instantiate ChromePdfRenderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Render HTML to PDF
            PdfDocument pdf = renderer.RenderHtmlAsPdf("html.Result", @"wwwroot/image");
        }
    }
}