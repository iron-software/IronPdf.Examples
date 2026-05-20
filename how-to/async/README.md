# Asynchronous and Multithreaded PDF Creation

***Based on <https://ironpdf.com/how-to/async/>***


Discover the importance of asynchronous programming and multithreading when creating [high-performance PDFs using IronPDF in C# and VB.NET](https://ironpdf.com/docs/) for batch processes or enhanced efficiency.

### Kickstart: Asynchronously Convert HTML to PDF Using IronPDF

Jumpstart your journey with IronPDF to asynchronously generate PDFs from HTML content, increasing the efficiency of your applications. Use the `RenderHtmlAsPdfAsync` method to seamlessly transfer HTML into PDF format and experience the strides in performance when handling batch operations or working in multithreaded scenarios. The robust features of IronPDF simplify the process, enabling rapid PDF creation.

```cs
:title=Quick HTML to PDF Conversion
var pdf = await IronPdf.ChromePdfRenderer.RenderHtmlAsPdfAsync("<h1>Hello World!</h1>");
```

## Example of Asynchronous Operation

IronPDF fully integrates asynchronous capabilities within its methods, including `RenderHtmlAsPdfAsync`.

```csharp
using IronPdf;
using System.Threading.Tasks;

// Initialize ChromePdfRenderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

string[] htmlStrings = {"<h1>Html 1</h1>", "<h1>Html 2</h1>", "<h1>Html 3</h1>"};

// Prepare an array to collect tasks for PDF rendering
var renderingTasks = new Task<PdfDocument>[htmlStrings.Length];

for (int i = 0; i < htmlStrings.Length; i++)
{
    int index = i; // Secure the loop variable
    renderingTasks[i] = Task.Run(async () =>
    {
        // Convert HTML content to PDF
        return await renderer.RenderHtmlAsPdfAsync(htmlStrings[index]);
    });
}

// Wait for completion of all rendering tasks
// await Task.WhenAll(renderingTasks);
```

## Multi-Threading Approach

IronPDF provides thread-safe operations including the usage of `IronPdf.ChromePdfRenderer`. Note that multithreading is generally restricted on macOS devices.

Utilize the `Parallel.ForEach` approach for effectively processing multiple PDFs simultaneously.

```csharp
using IronPdf;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

var queue = new List<string>() { "<h1>Html 1</h1>", "<h1>Html 2</h1>", "<h1>Html 3</h1>" };

// Configure ChromePdfRenderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// List to keep the rendered PDF documents
List<PdfDocument> pdfResults = new List<PdfDocument>();

Parallel.ForEach(queue, html =>
{
    // Transform HTML into a PDF document
    PdfDocument pdf = renderer.RenderHtmlAsPdf(html);

    // Optionally, save the PDF locally or just add to the list for runtime usage
    lock (pdfResults)
    {
        pdfResults.Add(pdf);
    }
});
```

## Efficiency Verification

Consider this performance comparison, incorporating a 5-second intentional delay when rendering using the [WaitFor class to emulate complex HTML rendering processes](https://ironpdf.com/how-to/waitfor/). Here’s a table comparing the results across different rendering techniques.

<table class="table" style="text-align: center;">
    <tr style="background-color: rgb(241 249 251);">
        <th style="text-align: center;">Regular Rendering</th>
        <th style="text-align: center;">Asynchronous Rendering</th>
        <th style="text-align: center;">Multi-threaded Rendering</th>
    </tr>
    <tr>
        <td>15.75 seconds</td>
        <td>05.59 seconds</td>
        <td>05.68 seconds</td>
    </tr>
</table>