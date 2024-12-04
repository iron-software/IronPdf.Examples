# Embedding Images Using Data URIs in C# and VB for PDF Conversion

***Based on <https://ironpdf.com/how-to/datauris/>***


When handling HTML strings and documents in development, it's often more convenient to avoid relying on a directory of external assets. One effective solution to this is utilizing the [data URI scheme](https://en.wikipedia.org/wiki/Data_URI_scheme).

The data URI scheme is a technique employed in web development that embeds data directly within HTML or CSS, removing the necessity for external resource files. This method allows the inclusion of images, files, and fonts directly into HTML documents as base64-encoded strings.

## Example of Embedding an Image Directly in HTML

Below is an example that demonstrates how to embed an image directly into an HTML document without needing a separate asset file:

```cs
using System;
using IronPdf;
namespace IronPdfExamples.DataUriEmbedding
{
    public class BasicEmbedding
    {
        public void Execute()
        {
            // Load image as byte array
            var imageBytes = System.IO.File.ReadAllBytes("My_image.png");
            
            // Encode image bytes to base64
            var base64Image = @"data:image/png;base64," + Convert.ToBase64String(imageBytes);
            
            // Embed the base64 string into an HTML img tag
            var htmlContent = $"<img src='{base64Image}'>";
            
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Convert HTML string to PDF
            var pdfDocument = renderer.RenderHtmlAsPdf(htmlContent);
            
            pdfDocument.SaveAs("embedded_image_example.pdf");
        }
    }
}
```

Additionally, it's possible to serve an [entire HTML String or PDF document as a Byte Array using IronPDF's ASP.NET MVC integration](https://www.ironpdf.com/how-to/asp-net-mvc-pdf-binary/).