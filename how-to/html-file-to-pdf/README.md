# Rendering an HTML File to PDF Using IronPDF

IronPDF provides a straightforward method to convert HTML files into PDF documents directly from your local storage.

---

---

## Example: Converting HTML to PDF

In this example, we illustrate how IronPDF can convert an HTML file into a PDF by utilizing the `RenderHtmlFileAsPdf()` method. This method takes a file path to the local HTML document you wish to convert.

This capability is particularly useful as it allows developers to check and modify HTML content directly in a web browser, such as Chrome—on which IronPDF's rendering engine is based—ensuring that the output is visually consistent with the browser's display.

If the rendering looks accurate in Chrome, it will look identical in the resulting PDF by IronPDF.

### Sample HTML File

Below is the HTML content of `example.html` that will be converted:

```html
<!DOCTYPE html>
<html>
	<head>
		<title>Page Title</title>
	</head>
	<body>
		<h1>My First Heading</h1>
		<p>My first paragraph.</p>
	</body>
</html>
```

You can preview the HTML file that will be converted in the frame below:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/html-file-to-pdf/example.html" width="100%" height="150px">
</iframe>

### Code Demonstration

Here’s how you can turn the HTML into a PDF using IronPDF:

```cs
using IronPdf;
using IronPdf.Engines.Chrome;
using IronPdf.Rendering;

var renderer = new ChromePdfRenderer
{
    RenderingOptions = new ChromePdfRenderOptions
    {
        UseMarginsOnHeaderAndFooter = UseMargins.None,
        CreatePdfFormsFromHtml = false,
        CssMediaType = PdfCssMediaType.Print,
        CustomCssUrl = null,
        EnableJavaScript = false,
        Javascript = null,
        JavascriptMessageListener = null,
        FirstPageNumber = 0,
        GrayScale = false,
        HtmlHeader = null,
        HtmlFooter = null,
        InputEncoding = null,
        MarginBottom = 0,
        MarginLeft = 0,
        MarginRight = 0,
        MarginTop = 0,
        PaperOrientation = PdfPaperOrientation.Portrait,
        PaperSize = PdfPaperSize.Letter,
        PrintHtmlBackgrounds = false,
        TextFooter = null,
        TextHeader = null,
        Timeout = 0,
        Title = null,
        ForcePaperSize = false,
        ViewPortHeight = 0,
        ViewPortWidth = 0,
        Zoom = 0,
        FitToPaperMode = FitToPaperModes.Zoom
    },
    LoginCredentials = null
};
renderer.RenderingOptions.WaitFor.RenderDelay(50);

// Generate a PDF from an existing HTML file in C#
var pdf = renderer.RenderHtmlFileAsPdf("example.html");

// Save the PDF to a file
pdf.SaveAs("output.pdf");
```

### PDF Output

Here is the PDF produced by the above code:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/html-file-to-pdf/output.pdf" width="100%" height="500px">
</iframe>

## Default Chrome Print Options

For those requiring the default Chrome print settings in their PDF conversion, IronPDF allows easy configuration through property access on the `ChromePdfRenderOptions` object:

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Set rendering options to mimic default Chrome print preview settings
renderer.RenderingOptions = ChromePdfRenderOptions.DefaultChrome;
```

This configuration ensures that your PDF's appearance closely matches what you see in Chrome's print preview.