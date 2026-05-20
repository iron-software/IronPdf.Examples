# Understanding Different PDF Versions with IronPDF

***Based on <https://ironpdf.com/how-to/pdf-versions/>***


PDFs can host a multitude of content types – from plain text and graphics to interactive forms and even 3D objects. Each feature within a PDF relates to a specific version; for instance, documents with transparency measures require at least version 1.4, and those incorporating layered structures necessitate version 1.5 and above. This guide will explore how IronPDF adeptly handles these complexities by automatically selecting the appropriate PDF version during the conversion process, ensuring a smooth and efficient operation for developers.

## Creating PDF 1.4 with IronPDF

IronPDF caters to a broad spectrum of PDF versions, from 1.2 through 1.7. In scenarios where HTML is converted to PDF, IronPDF leverages the capabilities of the Chromium engine, typically assigning the lowest viable version between PDF 1.4 and PDF 1.6 to enhance viewer compatibility.

### Example: PDF Version 1.4

In this segment, we demonstrate converting a plain HTML string into a PDF, targeting version 1.4, renowned for supporting transparency, thus accommodating contemporary graphical designs without compromising viewer compatibility.

#### Code Snippet

```cs
using IronPdf;

var pdfRenderer = new ChromePdfRenderer();

var pdfDocument = pdfRenderer.RenderHtmlAsPdf("<p> Hello World!</p>");

pdfDocument.SaveAs("output.pdf");
```

#### Document Preview

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/pdf-versions/pdf-standard.pdf" width="100%" height="400px"></iframe>

<div class="content-img-align-center">
  <div class="center-image-wrapper">
    <img src="https://ironpdf.com/static-assets/pdf/how-to/pdf-versions/pdf-1.4-version.webp" alt="PDF version 1.4" class="img-responsive add-shadow">
  </div>
</div>

The result confirms IronPDF's selection of PDF 1.4 to ensure optimal compatibility with vast arrays of PDF viewers.

<hr>

## Generating PDF 1.7 with IronPDF

When merging multiple PDF documents, IronPDF defaults to using PDF 1.7, the international standard, to guarantee the highest level of compatibility across all PDF viewers. This strategy ensures that none of the original document features are lost in the merged output.

### Example: Creating PDF 1.7

Observe how IronPDF handles the merging of two different PDFs into one unified document, adhering to PDF version 1.7 standards.

#### Code Snippet

```cs
using IronPdf;

// Create two individual paged PDFs
const string firstHtml =
    @"<p> [PDF_A] </p>
    <p> [PDF_A] First Page </p>
    <div style='page-break-after: always;'></div>
    <p> [PDF_A] Second Page</p>";

const string secondHtml =
    @"<p> [PDF_B] </p>
    <p> [PDF_B] First Page </p>
    <div style='page-break-after: always;'></div>
    <p> [PDF_B] Second Page</p>";

var pdfBuilder = new ChromePdfRenderer();

var firstDoc = pdfBuilder.RenderHtmlAsPdf(firstHtml);
var secondDoc = pdfBuilder.RenderHtmlAsPdf(secondHtml);

// Merge the documents
var mergedDocument = PdfDocument.Merge(firstDoc, secondDoc);
mergedDocument.SaveAs("Merged.pdf");
```

#### Output View

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/pdf-versions/pdf-merged.pdf" width="100%" height="400px"></iframe>

<div class="content-img-align-center">
  <div class="center-image-wrapper">
    <img src="https://ironpdf.com/static-assets/pdf/how-to/pdf-versions/pdf-1.7-version.webp" alt="PDF version 1.7" class="img-responsive add-shadow">
  </div>
</div>

This section illustrates how IronPDF successfully creates a PDF document conforming to version 1.7 standard by merging two distinct documents, thereby ensuring consistency and broad compatibility.