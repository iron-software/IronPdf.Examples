using IronPdf;
namespace ironpdf.BaseUrls
{
    public class Section2
    {
        public void Run()
        {
            // Instantiate ChromePdfRenderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Render HTML to PDF
            PdfDocument pdf = renderer.RenderHtmlAsPdf("html.Result", @"wwwroot/image");
        }
    }
}