using IronPdf;
namespace ironpdf.UrlToPdf
{
    public class Section1
    {
        public void Run()
        {
            // Instantiate Renderer
            var renderer = new ChromePdfRenderer();
            
            // Create a PDF from a URL or local file path
            var pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");
            
            // Export to a file or Stream
            pdf.SaveAs("url.pdf");
        }
    }
}