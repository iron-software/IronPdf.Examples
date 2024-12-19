# How to Merge or Split PDFs

***Based on <https://ironpdf.com/how-to/merge-or-split-pdfs/>***


Combining several PDF files into a single document can be extremely beneficial in various contexts. For example, merging individual documents like CVs into a single file simplifies distribution compared to handling numerous documents. This guide will explain how to effectively merge and split PDF files using C# with the IronPDF library, focusing on the key page manipulation capabilities available.

### Getting Started with IronPDF

----

## Example of Merging PDFs

In this example, we’ll start with two HTML strings representing two pages each. We'll use IronPDF to convert these into PDFs and then merge them together:

```cs
using IronPdf;

// Define HTML for two-paged PDF
const string html1 = 
    @"<p>[Document A]</p>
    <p>First Page of PDF A</p>
    <div style='page-break-after: always;'></div>
    <p>Second Page of PDF A</p>";

// Define HTML for another two-paged PDF
const string html2 = 
    @"<p>[Document B]</p>
    <p>First Page of PDF B</p>
    <div style='page-break-after: always;'></div>
    <p>Second Page of PDF B</p>";

var renderer = new ChromePdfRenderer();

var pdfA = renderer.RenderHtmlAsPdf(html1);
var pdfB = renderer.RenderHtmlAsPdf(html2);

// Create a four-page PDF by merging
var mergedPdf = PdfDocument.Merge(pdfA, pdfB);
mergedPdf.SaveAs("Merged.pdf");
```

### Merging Results

Check out the merged PDF file here:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/merge-or-split-pdfs/Merged.pdf#view=fit" width="100%" height="500px"></iframe>

<hr>

## Combining PDF Pages

The `CombinePages` method allows you to fuse multiple PDF pages into a single comprehensive page by specifying dimensions and grid layout:

```cs
using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("Merged.pdf");

// Dimensions are given in millimeters
PdfDocument combinedPdf = pdf.CombinePages(250, 250, 2, 2);

combinedPdf.SaveAs("CombinedPages.pdf");
```

### Combined Result

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/merge-or-split-pdfs/combinePages.pdf#view=fit" width="100%" height="500px"></iframe>

<hr>

## Splitting a PDF Example

Here we demonstrate how to split a previously merged multi-page PDF:

```cs
using IronPdf;

// Using the 4-page merged PDF from earlier:
var pdf = PdfDocument.FromFile("Merged.pdf");

// Extract the first page into a new PDF
var firstPagePdf = pdf.CopyPage(0);
firstPagePdf.SaveAs("FirstPageOnly.pdf");

// Extract pages 2 and 3
var pagesTwoThreePdf = pdf.CopyPages(1, 2);
pagesTwoThreePdf.SaveAs("Pages2and3.pdf");
```

### Splitting Results

The resulting files from the code above are:

#### FirstPageOnly.pdf

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/merge-or-split-pdfs/FirstPageOnly.pdf#view=fit" width="100%" height="500px"></iframe>

#### Pages2and3.pdf

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/merge-or-split-pdfs/Pages2and3.pdf#view=fit" width="100%" height="500px"></iframe>