# How to Add, Copy, and Delete Pages in PDFs

Working with PDF documents often includes tasks like adding new content, duplicating existing pages, or eliminating unnecessary pages. Whether you're inserting text, images, or merging PDF pages, the operations can substantially alter your document's structure. Similarly, duplicating pages within or across PDF documents allows for easy reproduction of content, and removing undesired pages can streamline your files. IronPDF offers robust functionalities to efficiently handle these tasks.

## Add Pages to a PDF

Inserting a page into a PDF is straightforward. For instance, you might want to prepend a cover page to a report's PDF. To merge the cover and content PDFs into a single file, you utilize the `Merge` method. Consider these two files for demonstration: [coverPage.pdf](https://ironpdf.com/static-assets/pdf/how-to/add-copy-delete-pages-pdf/coverPage.pdf) and [contentPage.pdf](https://ironpdf.com/static-assets/pdf/how-to/add-copy-delete-pages-pdf/contentPage.pdf).

```cs
using IronPdf;

// Load the cover page
PdfDocument coverPage = PdfDocument.FromFile("coverPage.pdf");

// Load the content document
PdfDocument contentPage = PdfDocument.FromFile("contentPage.pdf");

// Combine the documents
PdfDocument finalPdf = PdfDocument.Merge(coverPage, contentPage);

// Save the combined PDF
finalPdf.SaveAs("pdfWithCover.pdf");
```

When executed, the snippet above creates a unified PDF file starting with the cover page:

<iframe src="https://ironpdf.com/static-assets/pdf/how-to/add-copy-delete-pages-pdf/pdfWithCover.pdf#view=fit" width="100%" height="500px">
</iframe>

Additionally, you can insert a PDF at a desired position using the `InsertPdf` method. In the following code, 'coverPage.pdf' is inserted at the start of the 'contentPage.pdf':

```cs
using IronPdf;

// Load the cover page
PdfDocument coverPage = PdfDocument.FromFile("coverPage.pdf");

// Load the content document
PdfDocument contentPage = PdfDocument.FromFile("contentPage.pdf");

// Insert the cover page at the beginning of the content page
contentPage.InsertPdf(coverPage, 0);
```

## Copy Pages from a PDF

Copying pages within a PDF is achieved by utilizing the `CopyPage` or `CopyPages` methods for single or multiple pages respectively. These methods produce a new **PdfDocument** with the requested pages.

```cs
using IronPdf;
using System.Collections.Generic;

// Load a document
PdfDocument myReport = PdfDocument.FromFile("report_final.pdf");

// Copy the first page to a new PDF document
PdfDocument copyOfPageOne = myReport.CopyPage(0);

// Copy the first three pages to a new PDF document
PdfDocument copyOfFirstThreePages = myReport.CopyPages(new List<int> { 0, 1, 2 });
```

## Delete Pages in a PDF

Removing pages from a PDF is as simple as invoking `RemovePage` or `RemovePages`, which allow for the deletion of single or multiple pages.

```cs
using IronPdf;
using System.Collections.Generic;

// Load the full report
PdfDocument pdf = PdfDocument.FromFile("full_report.pdf");

// Remove the first page
pdf.RemovePage(0);

// Remove the third and fourth pages
pdf.RemovePages(new List<int> { 2, 3 });
```