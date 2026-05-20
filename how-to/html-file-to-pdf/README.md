# Transforming HTML to PDF with IronPDF

***Based on <https://ironpdf.com/how-to/html-file-to-pdf/>***


IronPDF simplifies the process of converting HTML files into PDFs. It has the capability to handle any HTML file accessible on your system.

## Quickstart: HTML to PDF Conversion Using IronPDF

Transform HTML files to PDF effortlessly using IronPDF with just a few lines of C# code. Utilize the `ChromePdfRenderer` class to quickly change HTML content into polished PDF documents. Just provide the path of your HTML file, and IronPDF does the rest, making this process ideal for developers who need to integrate PDF generation into their projects seamlessly.

```cs
:title=HTML to PDF Quick Conversion
new IronPdf.ChromePdfRenderer()
  .RenderHtmlFileAsPdf("path/to/your/file.html")
  .SaveAs("converted-output.pdf");
```

---

## Detailed Example: HTML to PDF Conversion

In this detailed example, we will look at how you can use IronPDF to convert an HTML file to a PDF document. The example makes use of the `RenderHtmlFileAsPdf` method with a local HTML file path as its argument.

This method benefits developers by allowing them to preview the HTML in a browser like Chrome, which is the same browser base that IronPDF's rendering engine uses. If the output looks good in Chrome, it will be precisely replicated in the resulting PDF.

### Sample HTML

Below is the `example.html` file used in our demonstration:

```html
<!DOCTYPE html>
<html>
	<head>
		<title>Sample Page</title>
	</head>

	<body>
		<h1>Welcome to My Page</h1>
		<p>This is a sample paragraph.</p>
	</body>
</html>
```

The HTML content is displayed in the following frame on the website:

<iframe loading="lazy" src="https://ironsoftware.com/static-assets/pdf/how-to/html-file-to-pdf/example.html" width="100%" height="150px">
</iframe>

### Conversion Code

```csharp
using IronPdf;
using IronPdf.Engines.Chrome;
using IronPdf.Rendering;

var pdfRenderer = new ChromePdfRenderer
{
    RenderingOptions = new ChromePdfRenderOptions
    {
        CssMediaType = PdfCssMediaType.Print,
        MarginBottom = 0,
        MarginLeft = 0,
        MarginRight = 0,
        MarginTop = 0,
        Timeout = 120,  // Set timeout for PDF rendering
    },
};
pdfRenderer.RenderingOptions.WaitFor.RenderDelay(50); // Wait for all assets to load

// Generate a PDF from the specified HTML file
var pdfDocument = pdfRenderer.RenderHtmlFileAsPdf("example.html");

// Save the generated PDF to a file
pdfDocument.SaveAs("final-output.pdf");
```

The `RenderHtmlFileAsPdf` method outputs a `PdfDocument`, which encapsulates details about the PDF.

### Generated PDF Result

See how the PDF looks in the following frame:

<iframe loading="lazy" src="https://ironsoftware.com/static-assets/pdf/how-to/html-file-to-pdf/output.pdf" width="100%" height="500px">
</iframe>

## Setting Default Chrome Print Options

For those who prefer the standard Chrome print options, configure the `ChromePdfRenderOptions` to the `DefaultChrome` settings to ensure your PDF output matches the Chrome Print Preview.

```csharp
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Set rendering options to mimic default Chrome print behavior
renderer.RenderingOptions = ChromePdfRenderOptions.DefaultChrome;
```

Discover more capabilities and advanced features by visiting our tutorial page: [Learn to Convert PDFs](https://ironpdf.com/tutorials/convert-pdf/).