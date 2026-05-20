# Combining and Separating PDF Documents

***Based on <https://ironpdf.com/how-to/merge-or-split-pdfs/>***


Combining several PDF documents into one can be immensely beneficial for various needs. For example, this could mean amalgamating all resumes into a single PDF file rather than dealing with numerous individual files. This guide provides a complete walkthrough on how to combine multiple PDF files using C#. IronPDF makes PDF separation and combination straightforward with eloquent method calls in your C# application. Below, we examine all the procedures for manipulating PDF pages.

## Quickstart: Merge PDFs with IronPDF

Easilycombine multiple PDF files into one document using IronPDF. With minimal code, developers can embed PDF merging capabilities into their C# applications. This brief guide illustrates how to employ the IronPDF library's `Merge` method for unifying PDFs, thereby enhancing document management efficiency.

```csharp
// Merging multiple PDFs into a consolidated file with ease!
IronPdf.PdfDocument
    .Merge(IronPdf.PdfDocument.FromFile("file1.pdf"), IronPdf.PdfDocument.FromFile("file2.pdf"))
    .SaveAs("merged.pdf");
```

## Demonstration on Merging PDFs

Below is a demonstration where we create two two-page HTML strings, convert them to separate PDFs using IronPDF, and subsequently merge them:

```csharp
using IronPdf;

// Define two HTML contents to render as PDFs
const string html_a = @"
    <p> [PDF_A] </p>
    <p> [PDF_A] 1st Page </p>
    <div style='page-break-after: always;'></div>
    <p> [PDF_A] 2nd Page </p>";

const string html_b = @"
    <p> [PDF_B] </p>
    <p> [PDF_B] 1st Page </p>
    <div style='page-break-after: always;'></div>
    <p> [PDF_B] 2nd Page </p>";

var renderer = new ChromePdfRenderer();

var pdfdoc_a = renderer.RenderHtmlAsPdf(html_a);
var pdfdoc_b = renderer.RenderHtmlAsPdf(html_b);

// Combine into a four-page PDF
var merged = PdfDocument.Merge(pdfdoc_a, pdfdoc_b);
merged.SaveAs("Merged.pdf");
```

### Visual Result

This is the file produced by the code:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/merge-or-split-pdfs/Merged.pdf#view=fit" width="100%" height="500px">
</iframe>

<hr>

## Combining PDF Pages

Utilize the `CombinePages` method to amalgamate multiple PDF pages into a single comprehensive page. This method necessitates specifying the width, height, number of rows, and columns.

```csharp
using IronPdf;

// Load an existing PDF document.
PdfDocument pdf = PdfDocument.FromFile("Merged.pdf");

// Specify the configuration to combine pages into a grid layout.
int pageWidth = 250;  // Width in millimeters
int pageHeight = 250; // Height in millimeters
int rows = 2;         // Grid rows
int columns = 2;      // Grid columns

// Combine the PDF pages into a single page grid.
PdfDocument combinedPages = pdf.CombinePages(pageWidth, pageHeight, rows, columns);

// Save the newly structured document.
combinedPages.SaveAs("combinedPages.pdf");
```

### Visual Result

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/merge-or-split-pdfs/combinePages.pdf#view=fit" width="100%" height="500px">
</iframe>

<hr>

## Example of PDF Splitting

In the demonstration below, we split the previously created multi-page PDF document.

```csharp
using IronPdf;

// Load the 4-page combined PDF document.
var pdf = PdfDocument.FromFile("Merged.pdf");

// Extract the first page as a new PDF.
var page1doc = pdf.CopyPage(0);
page1doc.SaveAs("Page1Only.pdf");

// Extract pages 2 to 3 (note: zero-based index).
var page23doc = pdf.CopyPages(1, 2);
page23doc.SaveAs("Pages2to3.pdf");
```

These are the files that result from the above operations:

#### Single First Page

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/merge-or-split-pdfs/Page1Only.pdf#view=fit" width="100%" height="500px">
</iframe>

#### Pages Two and Three

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/merge-or-split-pdfs/Pages2to3.pdf#view=fit" width="100%" height="500px">
</iframe>

Curious to discover more? Visit our comprehensive guide here: [Organize PDFs](https://ironpdf.com/tutorials/organize-pdfs-complete-tutorial/)