# How to Add, Copy, and Delete Pages in PDFs

***Based on <https://ironpdf.com/how-to/add-copy-delete-pages-pdf/>***


Adding pages to a PDF involves introducing new content, whether text, images, or other PDF pages into a document. When we talk about copying pages within a PDF, we refer to replicating selected pages either within the same document or across different PDF documents. Removing pages from a PDF, on the other hand, pertains to eliminating unnecessary pages from the file. 

With IronPDF, managing pages within any PDF document becomes straightforward and efficient.

### Initial Setup with IronPDF

---

## Add Pages to a PDF

Inserting a new page into a PDF involves minimal coding. In this example, we aim to append a cover page at the beginning of a report's PDF. The `Merge` method facilitates the combining of two PDF documents. For our demonstration, use the following two PDFs: [download coverPage.pdf](https://ironpdf.com/static-assets/pdf/how-to/add-copy-delete-pages-pdf/coverPage.pdf) and [download contentPage.pdf](https://ironpdf.com/static-assets/pdf/how-to/add-copy-delete-pages-pdf/contentPage.pdf).

```cs
using IronPdf;

// Load the cover page PDF
PdfDocument coverPage = PdfDocument.FromFile("coverPage.pdf");

// Load the content page PDF
PdfDocument contentPage = PdfDocument.FromFile("contentPage.pdf");

// Combine both documents
PdfDocument finalPdf = PdfDocument.Merge(coverPage, contentPage);

// Save the merged document
finalPdf.SaveAs("pdfWithCover.pdf");
```

Executing the above code will yield a consolidated PDF document with the cover page set at the forefront:

<iframe src="https://ironpdf.com/static-assets/pdf/how-to/add-copy-delete-pages-pdf/pdfWithCover.pdf#view=fit" width="100%" height="500px">
</iframe>

Furthermore, to insert a page at any desired position within the PDF, you can use the `InsertPdf` method. Here's how you can achieve the insertion at the beginning:

```cs
using IronPdf;

// Load the cover page PDF
PdfDocument coverPage = PdfDocument.FromFile("coverPage.pdf");

// Load the content page PDF
PdfDocument contentPage = PdfDocument.FromFile("contentPage.pdf");

// Insert cover page at the beginning of content page
contentPage.InsertPdf(coverPage, 0);
```

<hr>

## Copy Pages from a PDF

Copying pages is simply a matter of using the `CopyPage` or `CopyPages` methods, designed to duplicate single or multiple pages. These methods yield a new **PdfDocument** containing the selected pages to be copied.

```cs
using IronPdf;
using System.Collections.Generic;

// Create a new PDF document from an existing file
PdfDocument myReport = PdfDocument.FromFile("report_final.pdf");
// Copy the first page
PdfDocument copyOfPageOne = myReport.CopyPage(0);

// Copy the first three pages
PdfDocument copyOfFirstThreePages = myReport.CopyPages(new List<int> { 0, 1, 2 });
```

<hr>

## Delete Pages in a PDF

Eliminating pages from a PDF can be accomplished with the `RemovePage` or `RemovePages` methods. These functions are crafted for deleting either a single page or multiple pages respectively.

```cs
using IronPdf;
using System.Collections.Generic;

// Load a PDF document
PdfDocument pdf = PdfDocument.FromFile("full_report.pdf");

// Remove the first page
pdf.RemovePage(0);

// Remove specified pages
pdf.RemovePages(new List<int> { 2, 3 });
```