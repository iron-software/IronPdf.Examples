# How to Insert Page Numbers into a PDF Document

***Based on <https://ironpdf.com/how-to/page-numbers/>***


Page numbers are essential navigational aids in a PDF document. They guide the reader to specific sections, facilitate easy referencing, and are crucial for citation purposes. With the IronPDF library, incorporating page numbers into your PDFs becomes straightforward.

### Initial Setup with IronPDF

---

## Example: Adding Page Numbers

Through the utilization of placeholders `{page}` and `{total-pages}`, you can seamlessly integrate both current and total page numbers using either the `TextHeaderFooter` or `HtmlHeaderFooter` class.

```cs
using IronPdf;

// Define text header
TextHeaderFooter textHeader = new TextHeaderFooter()
{
    CenterText = "{page} of {total-pages}"
};

// Define HTML footer
HtmlHeaderFooter htmlFooter = new HtmlHeaderFooter()
{
    HtmlFragment = "<center><i>{page} of {total-pages}</i></center>"
};

// Instantiate PDF renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Welcome</h1>");

// Append headers and footers
pdf.AddTextHeaders(textHeader);
pdf.AddHtmlFooters(htmlFooter);

pdf.SaveAs("EnhancedPdfWithPageNumbers.pdf");
```

The resulting PDF is accessible here:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/page-numbers/pdf-with-page-numbers.pdf" width="100%" height="500px">
</iframe>

Alternatively, you can include headers and footers directly in the `ChromePdfRenderer` rendering options:

```cs
using IronPdf;

// Configuration for rendering
ChromePdfRenderer renderer = new ChromePdfRenderer();
renderer.RenderingOptions.TextHeader = new TextHeaderFooter()
{
    CenterText = "{page} of {total-pages}"
};
renderer.RenderingOptions.HtmlFooter = new HtmlHeaderFooter()
{
    HtmlFragment = "<center><i>{page} of {total-pages}</i></center>"
};

string htmlContent = @"
    <h1>Welcome Page!</h1>
<div style='page-break-after: always;'></div>
    <h1>Second Page</h1>";

// Generate PDF
PdfDocument pdf = renderer.RenderHtmlAsPdf(htmlContent);

pdf.SaveAs("DirectPageNumberApplication.pdf");
```

## Custom Page Number Placement Example

With IronPDF, it is possible to customize where page numbers appear in your document, such as starting from a specific page or on only even or odd pages.

Prepare the PDF document:

```cs
using IronPdf;
using System.Linq;
using System.Collections.Generic;

string htmlPages = @"
    <p>Initial Page</p>
<div style='page-break-after: always;'></div>
    <p>Second Page</p>
<div style='page-break-after: always;'></div>
    <p>Third Page</p>";

// Initialize header
HtmlHeaderFooter header = new HtmlHeaderFooter()
{
    HtmlFragment = "<center><i>{page} of {total-pages}</i></center>"
};

// Prepare PDF
ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf(htmlPages);

var pageIndices = Enumerable.Range(0, pdf.PageCount);
```

### Specific Page Indexes for Page Numbers

For applying page numbers to even page indexes, resulting in showing numbers on odd pages:

```cs
var evenPageIndices = pageIndices.Where(i => i % 2 == 0);

pdf.AddHtmlHeaders(header, 1, evenPageIndices);
pdf.SaveAs("EvenIndexedPages.pdf");
```

For odd page indexes:

```cs
var oddPageIndexes = pageIndices.Where(i => i % 2 != 0);

pdf.AddHtmlHeaders(header, 1, oddPageIndexes);
pdf.SaveAs("OddIndexedPages.pdf");
```

### Page-specific Numbering

For the last page only:

```cs
var lastPageIndex = new List<int>() { pdf.PageCount - 1 };

pdf.AddHtmlHeaders(header, 1, lastPageIndex);
pdf.SaveAs("OnlyLastPage.pdf");
```

And for the first page only:

```cs
var firstPageIndex = new List<int>() { 0 };

pdf.AddHtmlHeaders(header, 1, firstPageIndex);
pdf.SaveAs("OnlyFirstPage.pdf");
```

### Omitting Specific Pages

To skip the first page:

```cs
var skipFirstPage = pageIndices.Skip(1);

pdf.AddHtmlHeaders(header, 1, skipFirstPage);
pdf.SaveAs("ExceptFirstPage.pdf");
```

And to start numbering from the second page, considering it as page 1:

```cs
var ignoreFirstPage = pageIndices.Skip(1);

pdf.AddHtmlHeaders(header, 0, ignoreFirstPage);
pdf.SaveAs("NumberingFromSecondPage.pdf");
```

For further details on customization, refer to the comprehensive [IronPDF Headers and Footers Guide](https://ironpdf.com/how-to/headers-and-footers/#anchor-metadata-to-text-header-footer).