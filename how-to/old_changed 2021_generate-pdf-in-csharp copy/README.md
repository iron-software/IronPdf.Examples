# Converting HTML Code into a PDF Document: A NuGet Package Overview

***Based on <https://ironpdf.com/how-to/old_changed 2021_generate-pdf-in-csharp copy/>***


## Enhance Your .NET Project with `IronPdf` Library

### Introduction

Integrating Iron Software's `IronPdf` library into your projects allows for robust and versatile PDF generation. By harnessing the power of this library, developers can convert HTML directly into PDFs efficiently in their .NET applications. It's a powerful tool, especially valuable for applications requiring report generation, invoice creation, or document storage in a standard format, achievable with only a few lines of code.

### Installation and Setup

To begin using `IronPdf`, initiate by installing the NuGet package:

```bash
PM> Install-Package IronPdf
```

To convert HTML content to a PDF:

```csharp
using IronPdf;

var chromePdf = new ChromePdfRenderer();
var pdfDocument = chromePdf.RenderHtmlAsPdf("<h1>Your HTML contents here</h1>");
pdfDocument.SaveAs("resulting-pdf.pdf");
```

With this simple method, developers can render intricate HTML with CSS and JavaScript directly to a PDF that maintains the layout and structure of the web design.

### Advanced Settings: Adding Assets

For a more refined control, sometimes you might want to include external resources such as images, CSS, or JavaScript. Here’s how to set a base path and incorporate assets into your PDFs:

```csharp
var pdfRenderer = new ChromePdfRenderer();
pdfRenderer.RenderingOptions.CssMediaType = PdfCssMediaType.Screen;
pdfRenderer.RenderingOptions.EnableJavaScript = true;
pdfRenderer.RenderingOptions.RenderDelay = TimeSpan.FromSeconds(2); // Wait for JS execution
var htmlWithAssets = "<img src='icons/your-image.png'><h1>Styled with External CSS</h1>";
var pdf = pdfRenderer.RenderHtmlAsPdf(htmlWithAssets, @"C:\site\assets\");
pdf.SaveAs("html-with-assets.pdf");
```

### Conclusion

`IronPdf` offers a straightforward, yet powerful way to generate and work with PDF files within .NET environments, including web, mobile, and desktop applications. Striking the perfect balance between ease of use and depth of functionality, it ensures high-quality PDF outputs essential for modern software solutions.

Visit [IronPdf's official documentation](https://ironpdf.com) for more detailed code examples and additional features like digital signatures, PDF editing, and much more.

For any support inquiries, contact [support@ironsoftware.com](mailto:support@ironsoftware.com) or view the extended product services at [Iron Software](https://www.ironsoftware.com).