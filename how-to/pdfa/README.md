# How to Export PDF/A Format Documents in C&#35;

***Based on <https://ironpdf.com/how-to/pdfa/>***


<div class="alert alert-info iron-variant-1" role="alert">
	Reduce your annual expenses on PDF security and compliance. Opt for <a href="https://ironsoftware.com/enterprise/securedoc/">IronSecureDoc</a>, offering one-time payment solutions for digital signing, redaction, encryption, and protection services. <a href="https://ironsoftware.com/enterprise/securedoc/docs/">Access IronSecureDoc's Documentation</a>
</div>

**IronPDF excels in exporting PDFs to the PDF/A-3b** standard, which is recognized as a rigid subset of the ISO PDF specification aimed at ensuring documents preserve their exact visual format for archiving.

#### Section 508 Compliance

IronPDF aligns with Google’s commitment to enhancing PDF archiving and accessibility, upholding the principles of Section 508 Compliance for PDF documents.

In 2021, we began utilizing the Google Chromium HTML rendering engine for converting HTML to PDFs, thereby adopting [Google's advancements in accessibility](https://blog.chromium.org/2020/07/using-chrome-to-generate-more.html).

***

<h3>Getting Started with IronPDF</h3>

## Supported PDF/A Standards

IronPDF supports two key conformance levels: A and B, representing 'accessible' and 'basic,' respectively. These levels are incorporated within the PDF/A-1, PDF/A-2, and PDF/A-3 standards as discussed in [Adobe's PDF/A documentation](https://www.adobe.com/uk/acrobat/resources/document-files/pdf-types/pdf-a.html):

- **Level A** meets all specified requirements, enhancing the document's accessibility for users with disabilities.
- **Level B** ensures basic compliance that mainly preserves the document's visual integrity over time.

**PDF/A-1**: Based on PDF version 1.4.

**PDF/A-2**: Introduced in July 2011 under the standard ISO 32001-1, encompasses capabilities up to PDF version 1.7 and introduces features suitable for high-quality scans and specific XMP metadata customs.

**PDF/A-3**: Extends the features of level 2 PDF/A, permitting the embedding of non-PDF file formats like XML, CSV, and word processing documents within a compliant PDF/A framework.

## Converting an Existing PDF File

Here's a demonstration using an existing PDF, "`wikipedia.pdf`", originally created with IronPDF.

### Input file: "wikipedia.pdf"

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/pdfa/wikipedia.pdf#view=fit" width="100%" height="500px">
</iframe>

### Example Code

```cs
using IronPdf;

// Instantiate a PdfDocument by loading a file
PdfDocument pdf = PdfDocument.FromFile("wikipedia.pdf");

// Convert and save the PDF as PDF/A compliant version
pdf.SaveAsPdfA("pdf-a3-wikipedia.pdf", PdfAVersions.PdfA3b);
```

### Output

The resultant file is compliant with PDF/A-3b standards:

![license complete](https://ironpdf.com/static-assets/pdf/how-to/pdfa/wikipedia-pdfa-passed.webp)

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/pdfa/pdf-a3-wikipedia.pdf#view=fit" width="100%" height="500px">
</iframe>

## Converting from an HTML Design or URL

Below is an example converting HTML content from both a static file and a live URL to a PDF/A compliant document.

### HTML Design Conversion

```cs
using IronPdf;

// Employ the Chrome Renderer for converting HTML to PDF
var chromeRenderer = new ChromePdfRenderer();

// Convert HTML to a PdfDocument
PdfDocument pdf = chromeRenderer.RenderHtmlAsPdf("design.html");

// Save as PDF/A compliant file
pdf.SaveAsPdfA("design-accessible.pdf", PdfAVersions.PdfA3b);
```

The resulting file meets PDF/A-3B standards:

![license complete](https://ironpdf.com/static-assets/pdf/how-to/pdfa/design-pdfa-passed.webp)

### URL to PDF Conversion

Let's convert content directly from the URL "`https://www.microsoft.com`" to a compliant PDF document.

```cs
using IronPdf;

// Use the Chrome Renderer for URL to PDF conversion
var chromeRenderer = new ChromePdfRenderer();

// Convert URL to a PdfDocument
PdfDocument pdf = chromeRenderer.RenderUrlAsPdf("https://www.microsoft.com");

// Save as PDF/A compliant version
pdf.SaveAsPdfA("website-accessible.pdf", PdfAVersions.PdfA3b);
```

The resultant document is likewise certified PDF/A-3B:

![license complete](https://ironpdf.com/static-assets/pdf/how-to/pdfa/website-pdfa-passed.webp)