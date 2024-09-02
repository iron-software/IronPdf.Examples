# How to Export PDF/A Format Documents in C#

<div class="alert alert-info iron-variant-1" role="alert">
	Is your business spending excessively on annual subscriptions for PDF security and compliance? Explore <a href="https://ironsoftware.com/enterprise/securedoc/">IronSecureDoc</a>, which offers a range of SaaS management solutions such as digital signatures, redaction, encryption, and protection — all available through a single payment. <a href="https://ironsoftware.com/enterprise/securedoc/docs/">Give it a try today</a>.
</div>

**IronPDF** can export PDF documents to the **PDF/A-3b** standard, a rigorous subset of the ISO PDF specification designed for long-term archiving. This specification ensures documents maintain their integrity over time.

#### Section 508 Compliance

IronPDF aligns with Google's efforts to enhance PDF accessibility and archiving. Following the Section 508 Compliance standard, IronPDF uses the Google Chromium HTML rendering engine to produce PDFs from HTML since 2021, leveraging [Google's advancements in accessibility](https://blog.chromium.org/2020/07/using-chrome-to-generate-more.html).


## PDF/A Variants Supported by IronPDF

IronPDF provides support for two levels of conformity, A (accessible) and B (basic), available in PDF/A-1, PDF/A-2, and PDF/A-3 formats as explained on [Adobe's documentation site](https://www.adobe.com/uk/acrobat/resources/document-files/pdf-types/pdf-a.html):

- **Level A** meets full compliance, enhancing accessibility for users with disabilities.
- **Level B** ensures basic compliance, primarily preserving the document's visual characteristics for reliable long-term access.

**PDF/A-1**: Based on PDF 1.4 specifications.

**PDF/A-2**: Introduced in July 2011 under standard ISO 32001-1, it includes features from PDF versions up to 1.7 and adds capabilities like supporting JPEG2000 for scanned documents, along with specifications for custom XMP metadata.

**PDF/A-3**: Expands on the features of PDF/A-2 by allowing the embedding of various file types such as XML, CSV, and word processing documents into PDF/A-compliant files.

## Working with an Existing PDF File

Here we start with a sample PDF file named "`wikipedia.pdf`," created with IronPDF.

### Source File: "wikipedia.pdf"

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/pdfa/wikipedia.pdf#view=fit" width="100%" height="500px"></iframe>

### Example Code

```cs
using IronPdf;

// Instantiate a PdfDocument from an existing file
PdfDocument pdf = PdfDocument.FromFile("wikipedia.pdf");

// Convert and save the document as PDF/A-3B
pdf.SaveAsPdfA("pdf-a3-wikipedia.pdf", PdfAVersions.PdfA3b);
```

### Resultant PDF

The resultant document meets the PDF/A-3b standard:

![Compliance confirmed](https://ironpdf.com/static-assets/pdf/how-to/pdfa/wikipedia-pdfa-passed.webp)

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/pdfa/pdf-a3-wikipedia.pdf#view=fit" width="100%" height="500px"></iframe>

## Converting HTML Content or URLs to PDF/A

Example: Converting an HTML file named "`design.html`" into a PDF and then ensuring it complies with PDF/A-3B standards.

### Sample HTML Conversion

```cs
using IronPdf;

// Utilize Chrome renderer for converting HTML to visually appealing PDFs
var chromeRenderer = new ChromePdfRenderer();

// Render the HTML as a PDF
PdfDocument pdf = chromeRenderer.RenderHtmlAsPdf("design.html");

// Save the rendered PDF as PDF/A-3B
pdf.SaveAsPdfA("design-accessible.pdf", PdfAVersions.PdfA3b);
```

The PDF/A-3B compliant version:

![Compliance confirmed](https://ironpdf.com/static-assets/pdf/how-to/pdfa/design-pdfa-passed.webp)

### Example of URL Rendering

Example URL: "`https://www.microsoft.com`"

```cs
using IronPdf;

// Convert HTML from URLs to PDFs using Chrome Renderer
var chromeRenderer = new ChromePdfRenderer();

// Create a PDF document from the website
PdfDocument pdf = chromeRenderer.RenderUrlAsPdf("https://www.microsoft.com");

// Save as a PDF/A-3B compliant document
pdf.SaveAsPdfA("website-accessible.pdf", PdfAVersions.PdfA3b);
```

Resultant PDF/A-3B compliant document:

![Compliance confirmed](https://ironpdf.com/static-assets/pdf/how-to/pdfa/website-pdfa-passed.webp)