# Generating PDFs using Async and Multithreading Techniques

***Based on <https://ironpdf.com/how-to/async/>***


Asynchronous programming and multithreading can dramatically improve the efficiency of generating [high-performance PDFs using C# and VB.NET with IronPDF](https://ironpdf.com/docs/) whether processing in batches or optimizing performance.

## Example of Asynchronous Rendering

IronPDF offers robust support for asynchronous operations with methods like `RenderHtmlAsPdfAsync`.

```cs
using System.Threading.Tasks;
using IronPdf;
namespace ironpdf.Async
{
    public class AsyncPDFGenerator
    {
        public async Task GeneratePDFs()
        {
            // Initialize ChromePdfRenderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            string[] htmlSamples = {"<h1>Html 1</h1>", "<h1>Html 2</h1>", "<h1>Html 3</h1>"};
            
            // Array to hold tasks for each HTML string
            Task<PdfDocument>[] tasks = new Task<PdfDocument>[htmlSamples.Length];
            
            for (int i = 0; i < htmlSamples.Length; i++)
            {
                int currentIndex = i; // To avoid closure issue in loop
                tasks[currentIndex] = Task.Run(async () =>
                {
                    // Asynchronously render HTML to PDF
                    return await renderer.RenderHtmlAsPdfAsync(htmlSamples[currentIndex]);
                });
            }
            
            // Optionally, wait for all tasks to complete
            // await Task.WhenAll(tasks);
        }
    }
}
```

## Example of Multithreading

IronPDF's `ChromePdfRenderer` engine supports multithreading, making it ideal for thread-safe environments. This feature, however, has limited support on macOS.

The `Parallel.ForEach` methodology proves effective for batch rendering:

```cs
using System.Threading.Tasks;
using IronPdf;
namespace ironpdf.Async
{
    public class MultiThreadPDFGenerator
    {
        public void GeneratePDFs()
        {
            var htmlList = new List<string>() { "<h1>Html 1</h1>", "<h1>Html 2</h1>", "<h1>Html 3</h1>" };
            
            // Initialize ChromePdfRenderer
            ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();
            
            // List to hold the generated PDFs
            List<PdfDocument> pdfDocuments = new List<PdfDocument>();
            
            Parallel.ForEach(htmlList, htmlString =>
            {
                // Render HTML to PDF in a thread-safe manner
                PdfDocument document = pdfRenderer.RenderHtmlAsPdf(htmlString);
                
                // Synchronize access to the list of PDF documents
                lock (pdfDocuments)
                {
                    pdfDocuments.Add(document);
                }
            });
        }
    }
}
```

## Performance Comparison

A delay of 5 seconds simulating complex HTML rendering using the [WaitFor class](https://ironpdf.com/how-to/waitfor/) reveals the performance advantages of these techniques:

<table class="table" style="text-align: center;">
    <tr style="background-color: rgb(241 249 251);">
        <th style="text-align: center;">Normal Render</th>
        <th style="text-align: center;">Asynchronous Render</th>
        <th style="text-align: center;">Multithreaded Render</th>
    </tr>
    <tr>
        <td>15.75 seconds</td>
        <td>05.59 seconds</td>
        <td>05.68 seconds</td>
    </tr>
</table>