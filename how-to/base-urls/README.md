# Using Base URLs and Asset Encoding in IronPDF

IronPDF is a powerful library for generating PDFs within .NET applications, particularly effective for converting HTML content into PDF documents.

One common question is: *how can we incorporate CSS stylesheets and images into our HTML-to-PDF conversions?*

## Converting HTML Strings to PDFs with Image and CSS Assets

When converting HTML strings to PDF, it's crucial to define a **BaseUrlOrPath**. This parameter sets the base URL or file path for resolving assets such as CSS, JavaScript, and images. The BaseUrlOrPath could be a remote URL (starting with 'http') for online assets or a local file path for assets stored on your local drive. Properly setting this parameter ensures that all your assets are correctly loaded during the PDF conversion.

```cs
using IronPdf;

// Create an instance of ChromePdfRenderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

string baseUrl = @"C:\site\assets\";
string htmlContent = "<img src='icons/iron.png'>";

// Convert HTML to PDF
PdfDocument document = renderer.RenderHtmlAsPdf(htmlContent, baseUrl);

// Save the generated PDF
document.SaveAs("html-with-assets.pdf");
```

### Implementing in an MVC Application

In MVC applications, defining image paths can be tricky. To resolve images correctly, both IronPDF's **baseUrl** and the HTML string's **src=""** need accurate settings.

Consider the following directory structure and settings:
- Set baseUrlOrPath as @"wwwroot/image"
- Set image **src** attributes as displayed in the HTML snippet below.

```plaintext
wwwroot
└── image
    ├── Sample.jpg
    └── Sample.png
```

**For instance:**

```cs
// Create an instance of ChromePdfRenderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Convert the HTML result to PDF
PdfDocument pdf = renderer.RenderHtmlAsPdf("html.Result", @"wwwroot/image");
```

```html
<img src="../image/Sample.jpg"/>
<img src="../image/Sample.png"/>
```

#### What Doesn't Work

These formats might look correct in a web browser but won't function correctly in an MVC setting when used in IronPDF:

```html
<img src="image/footer.png"/>  
<img src="./image/footer.png"/>  
```

Yet, these paths won't resolve properly in IronPDF:

```html
<img src="/image/footer.png"/>  
<img src="~/image/footer.png"/>
```

## Using HTML Headers and Footers with Images

When adding HTML headers and footers in PDF documents, these are treated as independent HTML documents without inheriting the BaseURL.

```cs
using IronPdf;
using System;

// Create an instance of ChromePdfRenderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Configure the HTML header
renderer.RenderingOptions.HtmlHeader = new HtmlHeaderFooter()
{
    MaxHeight = 20,
    HtmlFragment = "<img src='logo.png'>",
    BaseUrl = new Uri(@"C:\assets\images\").AbsoluteUri
};
```

## Converting HTML Files to PDF with CSS, JS, and Image Assets

When dealing with entire HTML files, assets are assumed to be in the same directory as the HTML file.

```cs
using IronPdf;

// Create an instance of ChromePdfRenderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Convert the HTML file to PDF
PdfDocument invoicePdf = renderer.RenderHtmlFileAsPdf("C:\\Assets\\TestInvoice1.html");

// Export the PDF
invoicePdf.SaveAs("Invoice.pdf");
```

Additionally, with [ChromePdfRenderOptions.CustomCssUrl](https://ironpdf.com/object-reference/api/IronPdf.ChromePdfRenderOptions.html#IronPdf_ChromePdfRenderOptions_CustomCssUrl), you can specify an extra stylesheet used exclusively for PDF rendering:

```cs
using IronPdf;

// Create an instance of ChromePdfRenderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Additional CSS for rendering
renderer.RenderingOptions.CustomCssUrl = "./style.css";

// Convert HTML to PDF
PdfDocument styledPdf = renderer.RenderHtmlAsPdf("<h1>Hello World</h1>");

// Save the PDF
styledPdf.SaveAs("tryCss.pdf");
```

The `CustomCssUrl` property is specifically effective when converting from HTML strings to PDF.

## Encoding Image Assets

To ensure images are found and displayed correctly, they can be base64 encoded inside the HTML:

1. Retrieve the image's binary data.
2. Convert the binary to base64 using `.NET`'s `Convert.ToBase64String` method.
3. Include the base64 representation directly in the HTML `img` tag. For specifics on image formats, see the [MDN Web Docs](https://developer.mozilla.org/en-US/docs/Web/Media/Formats/Image_types).

```cs
using IronPdf;
using System;
using System.IO;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Read binary data from image file
byte[] imageData = File.ReadAllBytes("ironpdf-logo-text-dotnet.svg");

// Convert binary data to base64
string base64String = Convert.ToBase64String(imageData);

// Construct HTML with embedded image
string htmlString = $"<img src='data:image/svg+xml;base64,{base64String}'>";

// Generate PDF from HTML
PdfDocument pdfResult = renderer.RenderHtmlAsPdf(htmlString);

// Save the PDF
pdfResult.SaveAs("embedImageBase64.pdf");
```