using IronPdf;
using System.Collections.Concurrent;
using System.Threading.Tasks;
public class ConcurrentPDFGenerator
{
    public static void GeneratePDFsConcurrently()
    {
        // Thread-safe collection for HTML content
        var htmlContents = new ConcurrentBag<string>
        {
            "<html><body><h1>Document 1</h1><p>Content for the first document.</p></body></html>",
            "<html><body><h1>Document 2</h1><p>Content for the second document.</p></body></html>",
            "<html><body><h1>Document 3</h1><p>Content for the third document.</p></body></html>"
        };
        // Initialize the ChromePdfRenderer
        var renderer = new ChromePdfRenderer();
        // Process each HTML string in parallel
        Parallel.ForEach(htmlContents, htmlContent =>
        {
            var pdf = renderer.RenderHtmlAsPdf(htmlContent);
            var fileName = $"Document_{Task.CurrentId}.pdf";
            pdf.SaveAs(fileName);
        });
    }
}
