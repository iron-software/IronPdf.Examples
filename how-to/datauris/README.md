# Embedding Images with Data URIs in C# & VB PDF Generation

***Based on <https://ironpdf.com/how-to/datauris/>***


In instances where managing HTML strings and documents, it's often preferable to avoid relying on an asset directory. To address this, the [data URI scheme](https://en.wikipedia.org/wiki/Data_URI_scheme) can be utilized.

The data URI scheme is a technique in web development that embeds data directly into HTML or CSS, removing the need for external files. This approach enables embedding images, files, and typefaces straight into an HTML document as textual data.

<h3>Introduction to IronPDF</h3>

---

## Example of Basic Image Embedding

This example demonstrates how to embed an image into an HTML document using a data URI, hence avoiding the use of external asset files:

```cs
using IronPdf;
using System;

// Loading the image file into byte array
var imageBytes = System.IO.File.ReadAllBytes("My_image.png");

// Encoding bytes into base64
var imageDataURI = @"data:image/png;base64," + Convert.ToBase64String(imageBytes);

// Creating HTML content with embedded image
var htmlContent = $"<img src='{imageDataURI}'>";

ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();

// Generating PDF from HTML string
var pdfDocument = pdfRenderer.RenderHtmlAsPdf(htmlContent);

pdfDocument.SaveAs("embedded_image_example.pdf");
```

Furthermore, IronPDF allows serving a complete [HTML String or PDF document as a Byte Array through its ASP.NET MVC framework integration](https://ironpdf.com/how-to/asp-net-mvc-pdf-binary/).