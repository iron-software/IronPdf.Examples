using System.Threading.Tasks;
using IronPdf;
namespace ironpdf.Async
{
    public class Section2
    {
        public void Run()
        {
            var queue = new List<string>() { "<h1>Html 1</h1>", "<h1>Html 2</h1>", "<h1>Html 3</h1>" };
            
            // Instantiate ChromePdfRenderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Create a list to store the rendered PDFs
            List<PdfDocument> pdfResults = new List<PdfDocument>();
            
            Parallel.ForEach(queue, html =>
            {
                // Render HTML to PDF
                PdfDocument pdf = renderer.RenderHtmlAsPdf(html);
            
                // You may choose to save the PDF to disk here if needed
                // For this example, we'll store it in the pdfResults list
                lock (pdfResults)
                {
                    pdfResults.Add(pdf);
                }
            });
        }
    }
}