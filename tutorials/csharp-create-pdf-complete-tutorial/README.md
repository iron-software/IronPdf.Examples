# Creating PDFs in C#

***Based on <https://ironpdf.com/tutorials/csharp-create-pdf-complete-tutorial/>***


Developing PDFs programmatically can raise several challenges, from inserting headers and footers to resolving compatibility issues. IronSoftware streamlines this task, encapsulating various PDF creation features into user-friendly methods. This allows developers to efficiently engage with their projects.

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

- **Design Perfect PDFs**
  - [Create Blank PDF](#anchor-create-blank-pdf)
  - [Add Headers & Footers](#anchor-add-headers-footers)
  - [Add Page Numbers](#anchor-add-page-numbers)
  - [Embed Images with DataURIs](#anchor-embed-images-with-datauris)
  - [Embed Images from Azure Blob Storage](#anchor-embed-images-with-azure-blob-storage)
  - [OpenAI for PDF](#anchor-openai-for-pdf)
- **Full PDF Customization Easy**
  - [Orientation & Rotation](#anchor-orientation-rotation)
  - [Custom Paper Size](#anchor-custom-paper-size)
- **Standards Compliance**
  - [Export PDF/A Format Docs in C#](#anchor-export-pdf-a-format-docs-in-c-num)
  - [Export PDF/UA Format Docs in C#](#anchor-export-pdf-ua-format-docs-in-c-num)

!!!--LIBRARY_NUGET_INSTALL_BLOCK--!!!

## Design Your Perfect PDF

### Create Blank PDF

Generating a blank PDF is straightforward with IronPDF. Simply start by creating a new instance of `PdfDocument`, specifying its dimensions, and then using the `SaveAs` method to save it.

```cs
using IronPdf;

PdfDocument pdf = new PdfDocument(270, 270);  // Initialize a new PDF document with given dimensions

pdf.SaveAs("blankPage.pdf");  // Save the document as 'blankPage.pdf'
```

For further details and expanded functionality, visit our detailed [how-to guide](https://ironpdf.com/how-to/create-new-pdfs/).

!!!--LIBRARY_START_TRIAL_BLOCK--!!!

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

### OpenAI for PDF

IronPDF enhances your ability to quickly summarize, query, and solve problems using the OpenAI model, implemented atop Microsoft Semantic Kernel. Here’s a snippet to show how this functionality can be used to summarize a PDF document swiftly.

```cs
using IronPdf;
using IronPdf.AI;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using Microsoft.SemanticKernel.Memory;
using System;
using System.Threading.Tasks;

// Setup for OpenAI
var azureEndpoint = "<<enter your azure endpoint here>>";
var apiKey = "<<enter your azure API key here>>";
var builder = Kernel.CreateBuilder()
    .AddAzureOpenAITextEmbeddingGeneration("oaiembed", azureEndpoint, apiKey)
    .AddAzureOpenAIChatCompletion("oaichat", azureEndpoint, apiKey);
var kernel = builder.Build();