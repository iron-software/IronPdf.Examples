# Implementing Base URLs and Asset Management with IronPDF

***Based on <https://ironpdf.com/how-to/base-urls/>***


IronPDF stands out in the .NET landscape for its ability to easily convert HTML into PDF documents. 

One frequent application of this toolkit involves converting HTML designed layouts into PDFs. This might prompt the question: *How can we include CSS stylesheets and images in these conversions?*

## Quick Guide: Setting Up Base URLs in IronPDF

To start using IronPDF for converting HTML to PDFs in .NET C#, you can establish base URLs to ensure all assets like CSS, JavaScript, and images are correctly linked. This simplifies the PDF creation process significantly and is ideal for developers looking to improve their PDF outputs effortlessly.

```cs
:title=Setting Base URL in Single-Line Code
new IronPdf.ChromePdfRenderer().RenderHtmlAsPdf("<img src='https://ironpdf.com/icons/logo.png'>", @"C:\site\assets\").SaveAs("with‑assets.pdf");
```

## Transforming an HTML String into a PDF Including CSS and Image Assets

In the conversion from an HTML string to a PDF document, it’s vital to utilize the **BaseUrlOrPath**. This attribute helps in pointing to the right location of CSS files, JavaScript files, and images, ensuring all assets are loaded correctly during the conversion.

This base URL can be an HTTP URL for remote asset loading, or a local path for disks asset access:

```csharp
using IronPdf;

// Create ChromePdfRenderer instance
ChromePdfRenderer renderer = new ChromePdfRenderer();

string baseUrl = @"C:\site\assets\";
string htmlContent = "<img src='https://ironpdf.com/icons/iron.png'>";

// Convert HTML to PDF using the base URL
PdfDocument pdf = renderer.RenderHtmlAsPdf(htmlContent, baseUrl);

// Save the generated PDF
pdf.SaveAs("html-with-assets.pdf");
```

### MVC Application Integration

Configuring image paths in MVC applications can be intricate. Ensuring IronPDF correctly identifies and displays images requires proper setting of the **baseUrl** and the **src=""** HTML attribute.

Setting these can help maintain the correct file hierarchy:

- `baseUrlOrPath`: @"wwwroot/image"
- `src` attribute: "../image/Sample.jpg"

File Hierarchy Example:

```plaintext
wwwroot
└── image
    ├── Sample.jpg
    └── Sample.png
```

**Integration Code Example:**

```csharp
// Initialize ChromePdfRenderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Convert HTML results to PDF using baseUrl
PdfDocument pdf = renderer.RenderHtmlAsPdf("html.Result", @"wwwroot/image");
```

```html
<img src="https://ironpdf.com/image/Sample.jpg"/>
<img src="https://ironpdf.com/image/Sample.png"/>
```

#### Unsuccessful File Path Formats

The following path styles are appropriate for the Chrome browser but misdirect in an MVC context, though they work with IronPDF when a base URL is specified:

```html
<img src="image/footer.png"/>  
<img src="./image/footer.png"/>  
```

Conversely, these paths align with MVC app standards but fail in IronPDF without specific baseURL settings:

```html
<img src="/image/footer.png"/>  
<img src="~/image/footer.png"/>
```

## Adding Headers and Footers with HTML Content

Incorporating HTML headers and footers in PDFs requires them to stand alone without inheriting the original PDF’s BaseURL. Specifying a BaseURL is crucial for assets in headers and footers:

```csharp
using IronPdf;
using System;

// Setup ChromePdfRenderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Define HTML header options
renderer.RenderingOptions.HtmlHeader = new HtmlHeaderFooter()
{
    MaxHeight = 20,
    HtmlFragment = "<img src='https://ironpdf.com/logo.png'>",
    BaseUrl = new Uri(@"C:\assets\images\").AbsoluteUri
};
```

## Conversion of HTML File to PDF Including Assets

When converting an HTML file to PDF, it’s assumed all linked assets like JS, CSS, and images are local to the HTML file:

```csharp
using IronPdf;

// Create ChromePdfRenderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Convert a local HTML file to PDF
PdfDocument pdf = renderer.RenderHtmlFileAsPdf("C:\\Assets\\TestInvoice1.html");

// Save the PDF
pdf.SaveAs("Invoice.pdf");
```

For added styling, you can explicitly specify an external CSS file:

```csharp
using IronPdf;

// Setup ChromePdfRenderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Apply external CSS for PDF rendering
renderer.RenderingOptions.CustomCssUrl = "https://ironpdf.com/style.css";

// Render and save PDF
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello World</h1>");
pdf.SaveAs("tryCss.pdf");
```

## Direct Encoding of Image Assets

To bypass common issues with image pathfinding, embedding images directly using base64 encoding proves useful:

1. Acquire the image’s binary data.
2. Convert the data to base64 using `.NET`'s `Convert.ToBase64String` method.
3. Embed this data within an HTML `img` tag specifying the image type.

```csharp
using IronPdf;
using System;
using System.IO;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Load image data
byte[] binaryData = File.ReadAllBytes("ironpdf-logo-text-dotnet.svg");

// Convert to base64
string imgDataUri = Convert.ToBase64String(binaryData);

// Embed and convert to PDF
string html = $"<img src='data:image/svg+xml;base64,{imgDataUri}'>";
PdfDocument pdf = renderer.RenderHtmlAsPdf(html);

// Output the PDF
pdf.SaveAs("embedImageBase64.pdf");
```