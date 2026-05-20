# Managing PDF Pages: Add, Copy, and Delete Techniques

***Based on <https://ironpdf.com/how-to/add-copy-delete-pages-pdf/>***


Editing PDFs often requires the ability to add fresh content or rearrange existing content through the insertion of new pages, duplication of existing ones, or elimination of superfluous pages. This guide demonstrates how to effectively handle such modifications using IronPDF.

## Quickstart: Instant PDF Page Management

Harness the capabilities of IronPDF to seamlessly add, copy, and delete pages from your PDFs. This example demonstrates how to integrate additional pages into a PDF document effortlessly, employing IronPDF's powerful features to simplify page management in any .NET project.

```cs
:title=Streamlined PDF Page Manipulation
IronPdf.PdfDocument.FromFile("https://ironpdf.com/input/path.pdf")
    .AppendPdf(IronPdf.PdfDocument.FromFile("https://ironpdf.com/additional/path.pdf"))
    .SaveAs("https://ironpdf.com/output/path.pdf");
```

## Adding Pages to a PDF

To add a page to a PDF, you only need a single line of code. Consider a scenario where a report needs a cover page at the beginning. This is accomplished by merging two PDF documents. You can download the sample documents here: [coverPage.pdf](https://ironpdf.com/static-assets/pdf/how-to/add-copy-delete-pages-pdf/coverPage.pdf) and [contentPage.pdf](https://ironpdf.com/static-assets/pdf/how-to/add-copy-delete-pages-pdf/contentPage.pdf).

```cs
using IronPdf;

// Load the cover page
PdfDocument coverPage = PdfDocument.FromFile("coverPage.pdf");

// Load the main content document
PdfDocument contentPage = PdfDocument.FromFile("contentPage.pdf");

// Combine both documents
PdfDocument combinedPdf = PdfDocument.Merge(coverPage, contentPage);

combinedPdf.SaveAs("pdfWithCover.pdf");
```

The above code creates a PDF with the cover page at the beginning, displayed here:

<iframe src="https://ironpdf.com/static-assets/pdf/how-to/add-copy-delete-pages-pdf/pdfWithCover.pdf#view=fit" width="100%" height="500px">
</iframe>

It's also possible to insert a page at a specific position using the `InsertPdf` method.

```cs
using IronPdf;

// Load the cover page
PdfDocument coverPage = PdfDocument.FromFile("coverPage.pdf");

// Load the main document
PdfDocument contentPage = PdfDocument.FromFile("contentPage.pdf");

// Insert the cover page at the beginning
contentPage.InsertPdf(coverPage, 0);
```

## Copying Pages in a PDF

Copying pages is straightforward with the `CopyPage` or `CopyPages` methods, ideal for duplicating single or multiple pages. These methods return a new `PdfDocument` containing the copied pages.

```cs
using IronPdf;
using System.Collections.Generic;

// Copy a single page into a new document
PdfDocument report = PdfDocument.FromFile("report_final.pdf");
PdfDocument singlePageCopy = report.CopyPage(0);

// Copy multiple pages into a new document
PdfDocument multiplePagesCopy = report.CopyPages(new List<int> { 0, 1, 2 });
```

## Deleting Pages from a PDF

To remove pages, use the `RemovePage` or `RemovePages` methods for deleting individual or multiple pages respectively.

```cs
using IronPdf;
using System.Collections.Generic;

PdfDocument document = PdfDocument.FromFile("full_report.pdf");

// Delete the first page
document.RemovePage(0);

// Delete several pages
document.RemovePages(new List<int> { 2, 3 });
```

Explore more possibilities with IronPDF through our complete guide: [Organize PDFs Tutorial](https://ironpdf.com/tutorials/organize-pdfs-complete-tutorial/).