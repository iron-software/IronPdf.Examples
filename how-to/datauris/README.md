# Embedding Images Using DataURIs in C# & VB PDF Conversion

***Based on <https://ironpdf.com/how-to/datauris/>***


When incorporating HTML content with associated assets into your projects, a practical approach can be to utilize the [data URI scheme](https://en.wikipedia.org/wiki/Data_URI_scheme).

The data URI scheme provides a technique in web design to embed raw data, such as images and fonts, straight into HTML or CSS, this bypasses the need for referencing external files. This method ensures all resources are contained within the HTML itself.

*as-heading:2(Get Started: Embed Images in PDFs with DataURIs)*

Easily transform HTML elements into PDF documents by embedding images using DataURIs through IronPDF. This quick reference will show developers how to effectively generate PDFs enriched with embedded images, executing minimal, reader-friendly code. With IronPDF, you can transition from HTML to PDF while preserving the fidelity of your images. Here is a concise example illustrating how to integrate an image into a PDF document through DataURI with minimal effort.

```cs
:title=Effortlessly Embed Images with IronPDF
new IronPdf.ChromePdfRenderer.StaticRenderHtmlAsPdf("<img src='data:image/png;base64,...' />").SaveAs("output.pdf");
```

## Basic Image Embedding Example

This example demonstrates how to inject an image into an HTML document directly without relying on external asset files:

```csharp
using IronPdf;
using System;

// Read bytes from the image file
var pngBinaryData = System.IO.File.ReadAllBytes("My_image.png");

// Convert the bytes to a base64 string
var ImgDataURI = @"data:image/png;base64," + Convert.ToBase64String(pngBinaryData);

// Embed the base64 string into an img HTML tag
var ImgHtml = $"<img src='{ImgDataURI}'>";

ChromePdfRenderer Renderer = new ChromePdfRenderer();

// Convert the HTML string to PDF
var pdf = Renderer.RenderHtmlAsPdf(ImgHtml);

pdf.SaveAs("datauri_example.pdf");
```

We can further explore serving either an [HTML String or PDF document as a Byte Array utilizing IronPDF's capabilities in ASP.NET MVC](https://ironpdf.com/how-to/cshtml-to-pdf-mvc-core/).