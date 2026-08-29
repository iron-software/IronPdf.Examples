# Creating PDFs in C#

> Full guide: [Creating PDFs in C#](https://ironpdf.com/tutorials/csharp-create-pdf-complete-tutorial/)

Generating a PDF from code raises a run of small problems, from placing headers and footers to keeping the output readable everywhere. IronPDF puts each of those behind one method, so most of a page's construction is a few lines rather than a project of its own.

IronPDF enables the effortless addition of shapes, text, images, as well as headers and footers. It provides various options for document orientation, size, and metadata management, and supports different compliance standards like PDF/UA and PDF/A. Moreover, integrating IronPDF into your existing applications for tasks such as PDF viewing or programmatic printing is a straightforward process.

This tutorial will detail the capabilities of IronPDF, demonstrating how it can improve your development process by allowing the creation of adaptable and maintainable code that is deployable across all supported environments and platforms.

By the end of this guide, you will have a thorough understanding of how to craft stylish and distinct PDFs suited to your requirements using IronPDF.

To initiate the installation of IronPDF and proceed with the tutorial illustrations mentioned here, visit our [quick installation guide](https://ironpdf.com/docs/) for easy setup instructions.

## Quickstart: Create Your First PDF with IronPDF

Begin creating your first PDF in C# with IronPDF swiftly by employing just a few lines of code. This quick guide will demonstrate how to initiate a PDF document, incorporate content, and save it, providing an easy introduction for those new to the library. Start creating PDFs in moments and boost your C# application's functionality with ease.

```cs
// Title: Instant PDF Creation with IronPDF
var pdf = new IronPdf.PdfDocument(500, 500);  // Create a new PDF document with specified dimensions
pdf.SaveAs("output.pdf");  // Save the document to a file named 'output.pdf'
```

## Table of Contents

- **Design your perfect PDF**
  - [Create Blank PDF](#create-blank-pdf)
  - [Add Headers & Footers](#add-headers--footers)
  - [Add Page Numbers](#add-page-numbers)
  - [Embed Images with DataURIs](#embed-images-with-datauris)
  - [OpenAI for PDF](#openai-for-pdf)
- **Full PDF customization**
  - [Orientation and Rotation](#orientation-and-rotation)
  - [Custom Paper Size](#custom-paper-size)
- **Standards compliance**
  - [Export a PDF/A Document](#export-a-pdfa-document)
  - [Export a PDF/UA Document](#export-a-pdfua-document)

## Design Your Perfect PDF

### Create Blank PDF

Generating a blank PDF is straightforward with IronPDF. Simply start by creating a new instance of `PdfDocument`, specifying its dimensions, and then using the `SaveAs` method to save it.

```cs
using IronPdf;

PdfDocument pdf = new PdfDocument(270, 270);  // Initialize a new PDF document with given dimensions

pdf.SaveAs("blankPage.pdf");  // Save the document as 'blankPage.pdf'
```

For further details and expanded functionality, visit our detailed [how-to guide](https://ironpdf.com/how-to/create-new-pdfs/).

### Add Headers & Footers

IronPDF makes adding headers and footers simple, whether at the top or bottom of your PDF. IronPDF offers two types: `TextHeaderFooter` for text-based headers and `HtmlHeaderFooter` for more customizable HTML content.

For detailed instructions and more options, check our complete [how-to guide](https://ironpdf.com/how-to/headers-and-footers/).

#### HTML Header and Footer

You can customize your headers and footers using HTML. The example below demonstrates how to create distinctive headers and footers by incorporating HTML tags and CSS.

```cs
using IronPdf;

// Define HTML for header
string headerHtml = @"
    <html>
    <head>
        <link rel='stylesheet' href='style.css'>
    </head>
    <body>
        <h1>This is a header!</h1>
    </body>
    </html>";

// Define HTML for footer
string footerHtml = @"
    <html>
    <head>
        <link rel='stylesheet' href='style.css'>
    </head>
    <body>
        <h1>This is a footer!</h1>
    </body>
    </html>";

// Instantiate renderer and create a PDF with simple HTML content
ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello World!</h1>");

// Create header and footer using HTML
HtmlHeaderFooter htmlHeader = new HtmlHeaderFooter
{
    HtmlFragment = headerHtml,
    LoadStylesAndCSSFromMainHtmlDocument = true,
};

HtmlHeaderFooter htmlFooter = new HtmlHeaderFooter
{
    HtmlFragment = footerHtml,
    LoadStylesAndCSSFromMainHtmlDocument = true,
};

// Add header and footer to the PDF
pdf.AddHtmlHeaders(htmlHeader);
pdf.AddHtmlFooters(htmlFooter);
```

For an insightful explanation and additional functionality, see our in-depth [how-to guide](https://ironpdf.com/how-to/headers-and-footers/#add-html-header-footer-example).

#### Text Header and Footer

In the following code, we use `TextHeaderFooter` for adding simple text-based headers and footers to a PDF. This example features placeholders for dynamic content like page numbers and dates.

```cs
using IronPdf;

// Instantiate renderer and create a new PDF with basic HTML content
ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello World!</h1>");

// Create text-based header
TextHeaderFooter textHeader = new TextHeaderFooter
{
    CenterText = "This is the header!",
};

// Create text-based footer
TextHeaderFooter textFooter = new TextHeaderFooter
{
    CenterText = "This is the footer!",
};

// Add the text header and footer to the PDF
pdf.AddTextHeaders(textHeader);
pdf.AddTextFooters(textFooter);

pdf.SaveAs("addTextHeaderFooter.pdf");
```

For an expanded explanation and more features, visit our thorough [how-to guide](https://ironpdf.com/how-to/headers-and-footers/#add-a-text-header-footer-example).

### Add Page Numbers

Adding page numbers is simplified using either `TextHeaderFooter` or `HtmlHeaderFooter` features. Below is a demonstration of how placeholders can be used in headers and footers to display page numbers dynamically.

```cs
using IronPdf;

// Create a text-based	header with placeholders for page numbers
TextHeaderFooter textHeader = new TextHeaderFooter()
{
    CenterText = "{page} of {total-pages}"
};

// Create an HTML-based footer with placeholders
HtmlHeaderFooter htmlFooter = new HtmlHeaderFooter()
{
    HtmlFragment = "<center><i>{page} of {total-pages}<i></center>"
};

// Generate a new PDF with basic HTML content
ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello World!</h1>");

// Include the header and footer
pdf.AddTextHeaders(textHeader);
pdf.AddHtmlFooters(htmlFooter);

pdf.SaveAs("pdfWithPageNumber.pdf");
```

For further details and extension options, refer to our detailed [how-to guide](https://ironpdf.com/how-to/page-numbers/).

### Embed Images with DataURIs

A directory of image assets is slow to reach when the renderer has to fetch each
file. Embedding the image in the HTML as a data URI avoids that:

```cs
using System;
using IronPdf;

// Read byte from image file
var pngBinaryData = System.IO.File.ReadAllBytes("My_image.png");

// Convert bytes to base64
var ImgDataURI = @"data:image/png;base64," + Convert.ToBase64String(pngBinaryData);

// Import base64 to img tag
var ImgHtml = $"<img src='{ImgDataURI}'>";

ChromePdfRenderer Renderer = new ChromePdfRenderer();

// Render the HTML string
var pdf = Renderer.RenderHtmlAsPdf(ImgHtml);

pdf.SaveAs("datauri_example.pdf");
```

### OpenAI for PDF

IronPDF can summarize, query and memorize a document through Microsoft Semantic
Kernel. This snippet summarizes a PDF:

```cs
using IronPdf;
using IronPdf.AI;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using Microsoft.SemanticKernel.Memory;
using System;
using System.Threading.Tasks;

// Setup OpenAI
var azureEndpoint = "<<enter your azure endpoint here>>";
var apiKey = "<<enter your azure API key here>>";
var builder = Kernel.CreateBuilder()
    .AddAzureOpenAITextEmbeddingGeneration("oaiembed", azureEndpoint, apiKey)
    .AddAzureOpenAIChatCompletion("oaichat", azureEndpoint, apiKey);
var kernel = builder.Build();

// Setup Memory
var memory_builder = new MemoryBuilder()
    // optionally use new ChromaMemoryStore("http://127.0.0.1:8000")
    .WithMemoryStore(new VolatileMemoryStore())
    .WithAzureOpenAITextEmbeddingGeneration("oaiembed", azureEndpoint, apiKey);
var memory = memory_builder.Build();

// Initialize IronAI
IronDocumentAI.Initialize(kernel, memory);

License.LicenseKey = "<<enter your IronPdf license key here>>";

// Import PDF document
PdfDocument pdf = PdfDocument.FromFile("wikipedia.pdf");

// Summarize the document
Console.WriteLine("Please wait while I summarize the document...");
string summary = await pdf.Summarize(); // optionally pass an AI instance
Console.WriteLine($"Document summary: {summary}

");
```

> This snippet needs `IronPdf.Extensions.AI` and the Semantic Kernel packages,
> which this example project does not reference, so `section7.cs` keeps it as a
> comment rather than as code that would not build.

## Full PDF Customization

### Orientation and Rotation

#### Orientation

`RenderingOptions.PaperOrientation` decides how the page is laid out. Setting it
to `PdfPaperOrientation.Landscape` renders the document in landscape:

```cs
using IronPdf.Rendering;
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Change paper orientation
renderer.RenderingOptions.PaperOrientation = PdfPaperOrientation.Landscape;

PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");

pdf.SaveAs("landscape.pdf");
```

#### Rotation

`SetAllPageRotations` turns every page; `SetPageRotation` turns one. Both take a
`PdfPageRotation`:

```cs
using IronPdf.Rendering;
using System.Collections.Generic;
using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("landscape.pdf");

// Set all pages
pdf.SetAllPageRotations(PdfPageRotation.Clockwise90);

// Set a single page
pdf.SetPageRotation(1, PdfPageRotation.Clockwise180);

// Set multiple pages
List<int> selectedPages = new List<int>() { 0, 3 };
pdf.SetPageRotations(selectedPages, PdfPageRotation.Clockwise270);

pdf.SaveAs("rotatedLandscape.pdf");
```

### Custom Paper Size

`SetCustomPaperSizeinCentimeters` sets the page dimensions directly. For a
standard size, set `PaperSize` to one of the `PdfPaperSize` values instead.

#### Custom Paper Size in Centimetres

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Set custom paper size in cm
renderer.RenderingOptions.SetCustomPaperSizeinCentimeters(15, 15);

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Custom Paper Size</h1>");

pdf.SaveAs("customPaperSize.pdf");
```

#### Standard Paper Size

```cs
using IronPdf.Rendering;
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Set paper size to A4
renderer.RenderingOptions.PaperSize = PdfPaperSize.A4;

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Standard Paper Size</h1>");

pdf.SaveAs("standardPaperSize.pdf");
```

## Standards Compliance

### Export a PDF/A Document

`SaveAsPdfA` writes the document in one of the PDF/A variants. This example uses
PDF/A-3b, through the `PdfAVersions` enum:

```cs
using IronPdf;

// Create a PdfDocument object or open any PDF File
PdfDocument pdf = PdfDocument.FromFile("wikipedia.pdf");

// Use the SaveAsPdfA method to save to file
pdf.SaveAsPdfA("pdf-a3-wikipedia.pdf", PdfAVersions.PdfA3b);
```

### Export a PDF/UA Document

`SaveAsPdfUA` writes a document that meets the PDF/UA accessibility standard:

```cs
using IronPdf;

// Open PDF File
PdfDocument pdf = PdfDocument.FromFile("wikipedia.pdf");

// Export as PDF/UA compliance PDF
pdf.SaveAsPdfUA("pdf-ua-wikipedia.pdf");
```

## Conclusion

The examples above cover creating a PDF, giving it headers, footers and page
numbers, embedding images without touching the file system, changing
orientation, rotation and paper size, and exporting to the PDF/A and PDF/UA
standards.
