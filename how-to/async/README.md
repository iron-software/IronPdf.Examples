# Generating PDFs Using Async and Multithreading Techniques

Incorporating async and threading techniques enhances the efficiency of [batch PDF generation and high-performance tasks in C# and VB.NET](https://ironpdf.com/docs/).

## Asynchronous Rendering Example

IronPDF provides robust support for asynchronous operations using methods such as `RenderHtmlAsPdfAsync`.

```cs
using IronPdf;
using System.Threading.Tasks;

// Create an instance of ChromePdfRenderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

string[] htmlSources = {"<h1>Html 1</h1>", "<h1>Html 2</h1>", "<h1>Html 3</h1>"};

// An array to hold the tasks
var renderTasks = new Task<PdfDocument>[htmlSources.Length];

for (int i = 0; i < htmlSources.Length; i++)
{
    int index = i; // Ensure the loop variable is correctly captured
    renderTasks[i] = Task.Run(async () =>
    {
        // Asynchronously render HTML to PDF
        return await renderer.RenderHtmlAsPdfAsync(htmlSources[index]);
    });
}

// Wait for all tasks in the array to complete
// await Task.WhenAll(renderTasks);
```

## Multi-Threading Rendering Example

IronPDF ensures thread safety and supports multithreading with the `ChromePdfRenderer`. However, note that multithreading capabilities are diminished on macOS systems.

The `Parallel.ForEach` routine is effective for processing multiple PDFs simultaneously.

```cs
using IronPdf;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

var htmlQueue = new List<string>() { "<h1>Html 1</h1>", "<h1>Html 2</h1>", "<h1>Html 3</h1>" };

// Create an instance of ChromePdfRenderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// List to accumulate the rendered PDFs
List<PdfDocument> renderedPdfs = new List<PdfDocument>();

Parallel.ForEach(htmlQueue, html =>
{
    // Convert HTML to PDF
    PdfDocument pdf = renderer.RenderHtmlAsPdf(html);

    // Optionally, save the PDF or add to a list as shown
    lock (renderedPdfs)
    {
        renderedPdfs.Add(pdf);
    }
});
```

## Comparative Analysis of Rendering Performance

To highlight the effectiveness of utilizing different rendering techniques, consider the inclusion of a 5-second simulation of rendering complex HTML using the [`WaitFor`](https://ironpdf.com/how-to/waitfor/) class. Below is a table illustrating the performance results for various rendering approaches.

<table class="table" style="text-align: center;">
    <tr style="background-color: rgb(241 249 251);">
        <th style="text-align: center;">Normal Render</th>
        <th style="text-align: center;">Asynchronous Render</th>
        <th style="text-align: center;">Multithreaded Render</th>
    </tr>
    <tr>
        <td>15.75 seconds</td>
        <td>5.59 seconds</td>
        <td>5.68 seconds</td>
    </tr>
</table>