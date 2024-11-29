using IronPdf;
namespace ironpdf.HtmlStringToPdf
{
    public class Section1
    {
        public void Run()
        {
            // Instantiate Renderer
            var renderer = new ChromePdfRenderer();
            
            // Create a PDF from a HTML string using C#
            var pdf = renderer.RenderHtmlAsPdf("<h1>Hello World</h1>");
            
            // Export to a file or Stream
            pdf.SaveAs("output.pdf");
        }
    }
}