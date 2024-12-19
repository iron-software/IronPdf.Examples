# Converting HTML Strings to PDFs Using IronPDF

***Based on <https://ironpdf.com/how-to/html-string-to-pdf/>***


IronPDF provides a seamless solution for developers using C#, F#, and VB.NET in both .NET Core and .NET Framework environments to generate PDF documents with ease. Leveraging the Google Chromium engine, IronPdf is capable of transforming any HTML string into a PDF document.

### Getting Started with IronPDF

---

## Example: Converting HTML String to PDF

Below is an example demonstrating how to convert an HTML string into a PDF document using IronPDF's `RenderHtmlAsPdf()` method. Just pass the HTML string you wish to convert as the parameter.

```cs
using IronPdf;

// Create a new PDF renderer instance
var pdfRenderer = new ChromePdfRenderer();

// Convert HTML string to PDF
var document = pdfRenderer.RenderHtmlAsPdf("<h1>Hello World</h1>");

// Save the rendered PDF to a file
document.SaveAs("output.pdf");
```

When fetching an HTML string from a remote source, it is often necessary to restrict local disk access and block cross-origin requests for security purposes. This can be achieved by setting the `Installation.EnableWebSecurity` property to `true`.

### Output Example

Here is the resulting PDF from the example code:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/html-string-to-pdf/output.pdf" width="100%" height="500px">
</iframe>

## Advanced HTML to PDF Conversion Example

In this advanced scenario, IronPDF incorporates external assets such as images, CSS, and JavaScript with a specified Base Path. This is beneficial when you need to provide context for relative pathways for various resources.

```cs
using IronPdf;

// Create a PDF renderer
var advancedRenderer = new ChromePdfRenderer();

// Example loading HTML with external resources
// The BasePath 'C:\site\assets\' is provided for loading assets
var detailedPdf = advancedRenderer.RenderHtmlAsPdf("<img src='icons/iron.png'>", @"C:\site\assets\");
detailedPdf.SaveAs("html-with-assets.pdf");
```

Here's the output PDF demonstrating HTML with imported assets:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/html-string-to-pdf/html-with-assets.pdf" width="100%" height="500px">
</iframe>