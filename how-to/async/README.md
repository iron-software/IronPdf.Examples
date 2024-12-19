# Generating PDFs Utilizing Async and Multithreading

***Based on <https://ironpdf.com/how-to/async/>***


Utilizing both asynchronous programming and multithreading can dramatically enhance the performance when generating [high-performance PDFs using C# and VB.NET with IronPDF](https://ironpdf.com/docs/) in batch processes or other high-demand scenarios.

### Initialize IronPDF

------------------------------

## Asynchronous Example

IronPDF offers full support for asynchronous operations through its Async Rendering methods such as the `RenderHtmlAsPdfAsync` method.

```cs
using IronPdf;
using System.Threading.Tasks;

// Create a new instance of ChromePdfRenderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

string[] htmlStrings = {"<h1>HTML Example 1</h1>", "<h1>HTML Example 2</h1>", "<h1>HTML Example 3</h1>"};

// Initialize an array to hold tasks for PDF rendering
var renderingTasks = new Task<PdfDocument>[htmlStrings.Length];

for (int i = 0; i < htmlStrings.Length; i++)
{
    int index = i; // Local copy of the loop variable
    renderingTasks[i] = Task.Run(async () =>
    {
        // Convert HTML string to PDF asynchronously
        return await renderer.RenderHtmlAsPdfAsync(htmlStrings[index]);
    });
}

// Await all tasks to complete rendering
// await Task.WhenAll(renderingTasks);
```

## Multithreading Example

IronPDF ensures thread-safety and supports multithreading with its `IronPdf.ChromePdfRenderer` rendering engine, though it's restricted on macOS.

The `Parallel.ForEach` approach is tremendously effective for processing PDFs in batches.

```cs
using IronPdf;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

var queue = new List<string>() { "<h1>HTML Example 1</h1>", "<h1>HTML Example 2</h1>", "<h1>HTML Example 3</h1>" };

// Instantiate the ChromePdfRenderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// List to hold the PDF results
List<PdfDocument> pdfResults = new List<PdfDocument>();

Parallel.ForEach(queue, html =>
{
    // Render PDF from HTML content
    PdfDocument pdf = renderer.RenderHtmlAsPdf(html);

    // Optionally, PDFs can be saved here
    // For this demonstration, PDFs are added to a list
    lock (pdfResults)
    {
        pdfResults.Add(pdf);
    }
});
```

## Performance Comparison

We have a comparison test with a 5-second delay implemented using [WaitFor class for emulating complex HTML rendering scenarios](https://ironpdf.com/how-to/waitfor/). Here's how the different rendering techniques stack up:

<table class="table" style="text-align: center;">
    <tr style="background-color: rgb(241, 249, 251);">
        <th style="text-align: center;">Standard Rendering</th>
        <th style="text-align: center;">Asynchronous Rendering</th>
        <th style="text-align: center;">Multithreaded Rendering</th>
    </tr>
    <tr>
        <td>15.75 seconds</td>
        <td>05.59 seconds</td>
        <td>05.68 seconds</td>
    </tr>
</table>