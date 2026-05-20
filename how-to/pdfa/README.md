# Exporting PDF/A or PDF/A-3 Format Documents in C#

***Based on <https://ironpdf.com/how-to/pdfa/>***


<div class="alert alert-info iron-variant-1" role="alert">
    Is your organization over-spending on annual subscriptions for PDF compliance and security? Look into <a href="https://ironsoftware.com/enterprise/securedoc/">IronSecureDoc</a>, a single-purchase solution covering services such as digital signing, redaction, encryption, and protection. <a href="https://ironsoftware.com/enterprise/securedoc/docs/">View IronSecureDoc Documentation</a>
</div>

As a proud [member of the PDF Association](https://pdfa.org/member/ironsoftware/), Iron Software is committed to supporting the PDF/A standard, ensuring that IronPDF complies with all archival compliance regulations.

**IronPDF is fully capable of exporting PDFs to the PDF/A-3b** standard. This format is a specialized subset of the ISO PDF specification dedicated to creating archival versions of documents that are rendered consistently over time.

## Quickstart: Convert PDFs to PDF/A-3b in C#

Easily transform your standard PDFs into the archival PDF/A-3b format with IronPDF, providing assured long-term preservation and adherence to compliance standards. Utilize IronPDF’s robust features to quickly and reliably convert your documents to PDF/A formats, ensuring they remain accessible and consistently rendered.

```cs
:title=Transform PDFs to PDF/A-3 Smoothly
IronPdf.PdfDocument pdf = IronPdf.PdfDocument.FromFile("example.pdf");
pdf.SaveAsPdfA("output.pdf");
```

## Compliance with Section 508

IronPDF is aligned with Google’s initiative to enhance PDF archiving and accessibility, maintaining full compliance with Section 508 standards.

In 2021, our approach shifted to use the Google Chromium HTML rendering engine for generating PDFs from HTML. This adoption allows us to leverage the [accessibility improvements made by Google](https://blog.chromium.org/2020/07/using-chrome-to-generate-more.html).

### Get Started with IronPDF

!!!--LIBRARY_START_TRIAL_BLOCK--!!!

## Supported PDF/A Versions

IronPDF supports conformance levels A (accessible) and B (basic). These are available across the PDF/A-1, PDF/A-2, and PDF/A-3 standards, sourced from [Adobe’s PDF/A documentation](https://www.adobe.com/uk/acrobat/resources/document-files/pdf-types/pdf-a.html). IronPDF defaults its output to PDF/A-3B (ISO 19005-3).

- **Level A** conformance ensures full accessibility, supporting assistive technologies for users with impairments.
- **Level B** conformance focuses primarily on preserving the document's visual integrity over time.

**PDF/A-1**: Established based on PDF 1.4.

**PDF/A-2**: Enhanced in 2011 under the ISO 32001-1, encompassing features from PDF up to 1.7 and supporting high-quality imaging for scanned documents as well as advanced metadata customization.

**PDF/A-3**: This version extends the features of PDF/A-2 by allowing various file types to be embedded into PDF/A-compliant documents, enhancing their utility and information retention.

Currently, IronPdf does not support converting PDFs with attachments to PDF/A-3B.

## Demonstration with Existing PDFs

Here's how to convert an already existing PDF file into a PDF/A-3B compliant version using IronPDF:

### Example PDF: "wikipedia.pdf"

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/pdfa/wikipedia.pdf#view=fit" width="100%" height="500px">
</iframe>

### Sample Conversion Code

```csharp
using IronPdf;

// Open an existing PDF file
PdfDocument pdf = PdfDocument.FromFile("wikipedia.pdf");

// Convert and save it as a PDF/A-3B file
pdf.SaveAsPdfA("pdf-a3-wikipedia.pdf", PdfAVersions.PdfA3b);
```

### Conversion Result

The resulting file meets the PDF/A-3b compliance standards:

![PDF/A-3b Compliance](https://ironpdf.com/static-assets/pdf/how-to/pdfa/wikipedia-pdfa-passed.webp)

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/pdfa/pdf-a3-wikipedia.pdf#view=fit" width="100%" height="500px">
</iframe>

## Conversion from HTML or Web URLs

Let’s convert a specific HTML layout and a webpage into PDF/A-3B compliant files, showcasing the versatility of IronPDF from multiple sources.

### HTML to PDF/A Conversion

```csharp
using IronPdf;

// Initialize the Chrome Renderer to handle HTML content
var chromeRenderer = new ChromePdfRenderer();

// Convert HTML layout to a PDF document
PdfDocument pdf = chromeRenderer.RenderHtmlAsPdf("design.html");

// Save the PDF in PDF/A format
pdf.SaveAsPdfA("design-accessible.pdf", PdfAVersions.PdfA3b);
```

The resulting PDF/A-3B document:

![PDF/A-3B Validation](https://ironpdf.com/static-assets/pdf/how-to/pdfa/design-pdfa-passed.webp)

### Web URL to PDF/A Conversion

```csharp
using IronPdf;

// Employ the Chrome Renderer to handle web content
var chromeRenderer = new ChromePdfRenderer();

// Convert a live URL into a PDF document using IronPDF
PdfDocument pdf = chromeRenderer.RenderUrlAsPdf("https://www.microsoft.com");

// Save the output as a PDF/A formatted file
pdf.SaveAsPdfA("website-accessible.pdf", PdfAVersions.PdfA3b);
```

The final PDF/A-3B compliant file:

![Web PDF/A-3B Confirmation](https://ironpdf.com/static-assets/pdf/how-to/pdfa/website-pdfa-passed.webp)

<hr>

## Advanced Options: Embedding Files into PDF/A

IronPdf offers advanced capabilities like embedding different file types, such as XML, CSV, or images, directly into PDF documents converting them into PDF/A format. This can be done using file paths, byte arrays, or streams, allowing for flexible file management.

### Embedding Using File Paths

```csharp
using IronPdf;
using System.Collections.Generic;

PdfDocument pdf = new PdfDocument("source.pdf");

// Define a list of file paths for embedding
IEnumerable<string> filePaths = new[] { "document.xml", "image.png" };

// Convert and embed files into PDF/A-3B
pdf.ConvertToPdfA(filePaths);
```

### Embedding Using Byte Arrays

This involves loading files into memory and embedding them as byte arrays for scenarios where direct file access isn't feasible.

```csharp
using IronPdf;
using System.Collections.Generic;
using System.IO;

PdfDocument pdf = new PdfDocument("source.pdf");

// Initialize byte arrays for files
byte[] imageData = File.ReadAllBytes("image.png");
byte[] documentData = File.ReadAllBytes("document.xml");

// Configuration settings for embedding
EmbedFileConfiguration config = new EmbedFileConfiguration
{
    EmbedFileName = "included.png",
    AFDesc = "Embedded Image",
    ConformanceLevel = ConformanceLevel.EN16931,
    SchemaNamespace = SchemaNamespace.facturX,
    SchemaPrefix = SchemaPrefix.fx,
    PropertyVersion = PropertyVersion.v1,
    AFRelationship = AFRelationship.Supplement
};

// Embed files and save as PDF/A
pdf.EmbedFiles(new[] { imageData, documentData }, config).SaveAs("enhanced-PdfA3.pdf");
```

### Embedding Using Streams

Streams offer a dynamic method to manage file content, especially useful in networked or streaming applications.

```csharp
using IronPdf;
using System.Collections.Generic;
using System.IO;

PdfDocument pdf = new PdfDocument("source.pdf");

// Prepare streams for files
Stream imageStream = new MemoryStream(File.ReadAllBytes("image.png"));
Stream documentStream = new MemoryStream(File.ReadAllBytes("document.xml"));

// Use streams to embed files into PDF/A
pdf.EmbedFiles(new[] { imageStream, documentStream }, config).SaveAs("stream-enhanced-PdfA3.pdf");
```

## Handling Character Display Issues

Ensuring all characters are correctly represented in a PDF/A document is crucial. Here's a visual comparison of a correct character display versus an issue with font compatibility:

![Character Display Problem](https://ironpdf.com/static-assets/pdf/how-to/pdfa/display-issue.webp)

Explore more about creating compliant PDFs by visiting our comprehensive guide at [Creating PDFs Tutorial](https://ironpdf.com/tutorials/csharp-create-pdf-complete-tutorial/).