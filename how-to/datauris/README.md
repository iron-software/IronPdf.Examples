# Incorporate Images through DataURIs in C# & VB PDF Creation

When handling HTML strings and documents, it's often advantageous not to rely on a physical directory of assets. A useful workaround is employing the [data URI scheme](https://en.wikipedia.org/wiki/Data_URI_scheme).

The data URI scheme is a technique in web development that integrates data directly within HTML or CSS, bypassing the need for external files. This approach enables the embedding of images, files, and fonts directly into an HTML document as a string.

## Example of Basic Image Embedding

Consider this example where an image is incorporated into an HTML document without using separate asset files:

```cs
using IronPdf;
using System;

// Load image data into a byte array
var imageData = System.IO.File.ReadAllBytes("My_image.png");

// Transform byte array to a base64 string
var base64ImageData = @"data:image/png;base64," + Convert.ToBase64String(imageData);

// Create an HTML string with an embedded image
var htmlContent = $"<img src='{base64ImageData}'>";

ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();

// Convert the HTML string to a PDF document
var resultPdf = pdfRenderer.RenderHtmlAsPdf(htmlContent);

resultPdf.SaveAs("example_datauri.pdf");
```

Additionally, it's feasible to deliver an entire [HTML String or PDF document as a Byte Array to IronPDF](https://www.ironpdf.com/how-to/asp-net-mvc-pdf-binary/).