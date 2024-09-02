# How to Convert a URL to PDF

Converting URLs to PDFs in C# is both straightforward and efficient using IronPDF. It effortlessly handles the conversion of HTML content from URLs into PDF documents, offering robust support for elements such as JavaScript, CSS, images, and forms.

## Example: Converting a URL to PDF

Below is an example that demonstrates how IronPDF can convert the [Wikipedia homepage](https://en.wikipedia.org/wiki/Main_Page) into a PDF using the `RenderUrlAsPdf()` method. The method accepts a fully qualified URI that identifies the HTML document to be converted.

```cs
using IronPdf;

// Initialize the PDF renderer
var pdfRenderer = new ChromePdfRenderer();

// Convert a URL to a PDF document
var pdfDocument = pdfRenderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");

// Save the PDF to a file
pdfDocument.SaveAs("converted-url.pdf");
```

### Output

Displayed below is the PDF created through the given example code:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/url-to-pdf/url.pdf" width="100%" height="500px"></iframe>