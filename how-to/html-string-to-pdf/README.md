# Convert HTML String to PDF in C&num;

***Based on <https://ironpdf.com/how-to/html-string-to-pdf/>***


IronPDF provides developers with a streamlined approach to generate PDF documents using C#, F#, and VB.NET across both .NET Core and .NET Framework. The library boasts the ability to convert HTML strings into PDFs, powered by the full version of the Google Chromium rendering engine.

## Quick Start: From HTML String to PDF in Moments

Use IronPDF for rapid transformation of HTML strings into PDF documents. This short tutorial showcases the simplicity of converting an HTML string to a PDF using C#. This is especially advantageous for developers aiming to incorporate robust PDF generation features into their applications.

```cs
:title=Instant PDF Conversion from HTML
IronPdf.ChromePdfRender.StaticRenderHtmlAsPdf("<p>Hello World</p>").SaveAs("string-to-pdf.pdf");
```

## Example of HTML String Conversion to PDF

Below is an example demonstrating how IronPDF can render a PDF from an HTML string utilizing the `RenderHtmlAsPdf` method. This method accepts an HTML string which it then converts into a PDF.

```csharp
using IronPdf;

// Initialize the Renderer
var renderer = new ChromePdfRenderer();

// Convert HTML string to PDF in C#
var pdf = renderer.RenderHtmlAsPdf("<h1>Hello World</h1>");

// Saving the PDF to a file or Stream
pdf.SaveAs("output.pdf");
```

The `RenderHtmlAsPdf` method produces a `PdfDocument` object which encapsulates the PDF's details.

For scenarios where the HTML content originates externally, security can be heightened by enabling the `ChromePdfRenderer.EnableWebSecurity` property, restricting local disk access and cross-origin requests.

### Output Example

Here's the resultant file from the above example:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/html-string-to-pdf/output.pdf" width="100%" height="500px">
</iframe>

## Advanced HTML to PDF Conversion

This advanced example illustrates the use of IronPDF to include external visual assets like images within a PDF, managed via a specified BasePath. Setting the `BaseUrlOrPath` parameter allows accurate referencing of file paths or URLs essential for images, CSS, or JavaScript assets.

```csharp
using IronPdf;

// Initialize the Renderer
var renderer = new ChromePdfRenderer();

// Advanced Example: Include HTML Assets
// Load external HTML resources such as Images, CSS, and JavaScript.
// Setting an optional BasePath 'C:\site\assets\' to designate asset loading location
var myAdvancedPdf = renderer.RenderHtmlAsPdf("<img src='icons/iron.png'>", @"C:\site\assets\");
myAdvancedPdf.SaveAs("html-with-assets.pdf");
```

This is the PDF generated in the advanced scenario:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/html-string-to-pdf/html-with-assets.pdf" width="100%" height="500px">
</iframe>