using System.Threading.Tasks;
using IronPdf;
namespace IronPdf.Examples.Tutorial.HtmlToPdf
{
    public static class Section14
    {
        public static void Run()
        {
            // This snippet is a member of a larger component from the accompanying README, not a standalone program.
            // Kept verbatim; see README.md for the full context.
            // // Async method for non-blocking PDF generation from HTML content
            // public async Task<byte[]> GeneratePdfAsync(string html)
            // {
            // var renderer = new ChromePdfRenderer();
            //
            // // Async HTML to PDF conversion preserves thread pool
            // var pdf = await renderer.RenderHtmlAsPdfAsync(html);
            //
            // // Return PDF files as byte array for web responses
            // return pdf.BinaryData;
            // }
            //
            // // Concurrent batch PDF generation for multiple HTML strings
            // public async Task GenerateMultiplePdfsAsync(List<string> htmlTemplates)
            // {
            // var renderer = new ChromePdfRenderer();
            //
            // // Create parallel conversion tasks to generate PDF documents
            // var tasks = htmlTemplates.Select(html =>
            // renderer.RenderHtmlAsPdfAsync(html)
            // );
            //
            // // Await all PDF conversions simultaneously
            // var pdfs = await Task.WhenAll(tasks);
            //
            // // Save generated PDF files from HTML content
            // for (int i = 0; i < pdfs.Length; i++)
            // {
            // pdfs[i].SaveAs($"document-{i}.pdf");
            // }
            // }
        }
    }
}