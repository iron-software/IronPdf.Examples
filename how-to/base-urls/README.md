# Utilizing Base URLs & Asset Encoding with IronPDF

***Based on <https://ironpdf.com/how-to/base-urls/>***


IronPDF is a premier tool for generating PDF documents within .NET environments.

One common application of this library is the "HTML to PDF" functionality, which leverages HTML as the layout language for creating PDF files. This raises an important question: *how can we effectively utilize CSS stylesheets and image files in our HTML to PDF transformations*?

## Generating a PDF from HTML String with Image and CSS Assets

When converting HTML strings to PDF, it's critical to establish a **BaseUrlOrPath**. This setting defines the base URL or path from which assets like CSS, JavaScript, and images are loaded.

This value can be an external web URL prefixed by 'http' for remote assets or a local file path for accessing disk-based resources. Correctly configuring the BaseUrlOrPath ensures the successful loading of these assets during the conversion.

```cs
using IronPdf;

// Create a ChromePdfRenderer instance
ChromePdfRenderer renderer = new ChromePdfRenderer();

string baseUrl = @"C:\site\assets\";
string html = "<img src='icons/iron.png'>";

// Convert HTML to PDF
PdfDocument pdf = renderer.RenderHtmlAsPdf(html, baseUrl);

// Save the PDF
pdf.SaveAs("html-with-assets.pdf");
```

### MVC Application Context

Specifying paths in an MVC app can sometimes be complex. To ensure the image is detected by IronPDF and rendered correctly in the PDF:

- Set `baseUrlOrPath` to @"wwwroot/image"
- Configure the `src` attribute in the HTML to point to "../image/Sample.jpg"

```txt
wwwroot
└── image
    ├── Sample.jpg
    └── Sample.png
```

**Example:**

```cs
// Create a ChromePdfRenderer instance
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Generate PDF from HTML
PdfDocument pdf = renderer.RenderHtmlAsPdf("html.Result", @"wwwroot/image");
```

```html
<img src="../image/Sample.jpg"/>
<img src="../image/Sample.png"/>
```

#### Clarifying File Path Formats

While certain formats appear correct in a browser like Chrome, they may not translate accurately in an MVC environment. The following are adaptable for IronPDF if a `baseUrlOrPath` is specified in `RenderHtmlAsPdf`:

```html
<img src="image/footer.png"/>  
<img src="./image/footer.png"/>  
```

Conversely, these formats are suitable for MVC apps but may not function optimally in IronPDF contexts:

```html
<img src="/image/footer.png"/>  
<img src="~/image/footer.png"/>
```

## Implementing HTML Headers and Footers with Assets

When incorporating HTML headers and footers in a new or existing PDF, these sections are processed as separate HTML documents and do not share the BaseURL of the PDF.

We need to specify a BaseURL where assets can be sourced:

```cs
using IronPdf;
using System;

// Create a ChromePdfRenderer instance
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Configure header
renderer.RenderingOptions.HtmlHeader = new HtmlHeaderFooter()
{
    MaxHeight = 20,
    HtmlFragment = "<img src='logo.png'>",
    BaseUrl = new Uri(@"C:\assets\images\").AbsoluteUri
};
```

## Rendering HTML Files to PDF with Associated Assets

When converting an HTML document to PDF, all related assets are assumed to be in the same directory as the HTML file.

```cs
using IronPdf;

// Create a ChromePdfRenderer instance
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Convert HTML file to PDF
PdfDocument pdf = renderer.RenderHtmlFileAsPdf("C:\\Assets\\TestInvoice1.html");

// Save PDF
pdf.SaveAs("Invoice.pdf");
```

Here, all JavaScript, CSS, and image files are sourced from the directory `C:\Assets`.

You might consider utilizing the [CustomCssUrl](https://ironpdf.com/api/IronPdf.ChromePdfRenderOptions.html#IronPdf_ChromePdfRenderOptions_CustomCssUrl) in `ChromePdfRenderOptions` for additional stylesheets specific to PDF rendering in .NET:

```cs
using IronPdf;

// Create a ChromePdfRenderer instance
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Define additional CSS URL
renderer.RenderingOptions.CustomCssUrl = "./style.css";

// Convert HTML to PDF
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello World</h1>");

// Save the PDF
pdf.SaveAs("tryCss.pdf");
```

The `ChromePdfRenderOptions.CustomCssUrl` is effective when converting from an HTML string to a PDF.

## Base64 Image Asset Embedding

To avoid issues with missing images, consider encoding them directly into the HTML using base64:

1. Acquire the image binary data either by reading the file or from a network request.
2. Use the `Convert.ToBase64String` method from Microsoft .NET to convert this data into a base64 string.
3. Formulate the image tag in HTML using "data:image/svg+xml;base64," followed by the base64 data. Refer to the [MDN Web Docs on Image Types and Formats](https://developer.mozilla.org/en-US/docs/Web/Media/Formats/Image_types) to understand more about specifying image types.

```cs
using IronPdf;
using System;
using System.IO;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Load binary data of the image
byte[] binaryData = File.ReadAllBytes("ironpdf-logo-text-dotnet.svg");

// Convert binary data to base 64 string
string imgDataUri = Convert.ToBase64String(binaryData);

// Embed image in HTML
string html = $"<img src='data:image/svg+xml;base64,{imgDataUri}'>";

// Convert HTML to PDF
PdfDocument pdf = renderer.RenderHtmlAsPdf(html);

// Save the PDF
pdf.SaveAs("embedImageBase64.pdf");
```