# How to Incorporate Page Numbers into a PDF Document

Page numbers serve as helpful navigational tools by marking each page sequentially in a PDF document. This functionality is crucial for helping readers identify their current page and for locating specific content quickly. These numbers also facilitate more effective cross-referencing and citing within the document. Incorporating page numbers into a PDF can be achieved effortlessly using IronPDF.

## Example of Adding Page Numbers

To insert page numbers that reflect the current page and total pages, you can use either the **TextHeaderFooter** or **HtmlHeaderFooter** class, utilizing placeholder strings `{page}` and `{total-pages}`.

```cs
using IronPdf;

// Define a text header
TextHeaderFooter textHeader = new TextHeaderFooter()
{
    CenterText = "{page} of {total-pages}"
};

// Define an HTML footer
HtmlHeaderFooter htmlFooter = new HtmlHeaderFooter()
{
    HtmlFragment = "<center><i>{page} of {total-pages}</i></center>"
};

// Create a PDF renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello World!</h1>");

// Embed the header and footer into the PDF
pdf.AddTextHeaders(textHeader);
pdf.AddHtmlFooters(htmlFooter);

pdf.SaveAs("pdfWithPageNumber.pdf");
```

An example of the resulting PDF can be viewed below:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/page-numbers/pdf-with-page-numbers.pdf" width="100%" height="500px">
</iframe>

Furthermore, these placeholders can be directly incorporated into the **ChromePdfRenderer** rendering options.

```cs
using IronPdf;

// Configure rendering options with headers and footers
ChromePdfRenderer renderer = new ChromePdfRenderer();
renderer.RenderingOptions.TextHeader = new TextHeaderFooter()
{
    CenterText = "{page} of {total-pages}"
};
renderer.RenderingOptions.HtmlFooter = new HtmlHeaderFooter()
{
    HtmlFragment = "<center><i>{page} of {total-pages}</i></center>"
};

string html = @"
    <h1>Hello World!</h1>
<div style='page-break-after: always;'></div>
    <h1>2nd Page!</h1>";

// Generate the PDF with these options
PdfDocument pdf = renderer.RenderHtmlAsPdf(html);

pdf.SaveAs("applyPageNumberWithRenderingOptions.pdf");
```

## Tailoring Page Numbers to Specific Pages

IronPDF also allows customizing where to begin placing page numbers, such as starting from a specific page or grouping like even-indexed pages.

Here's the setup example for such customizations:

```cs
using IronPdf;
using System.Linq;
using System.Collections.Generic;

string multi_page_html = @"
    <p>This is the 1st Page</p>
<div style='page-break-after: always;'></div>
    <p>This is the 2nd Page</p>
<div style='page-break-after: always;'></div>
    <p>This is the 3rd Page</p>
<div style='page-break-after: always;'></div>
    <p>This is the 4th Page</p>
<div style='page-break-after: always;'></div>
    <p>This is the 5th Page</p>
<div style='page-break-after: always;'></div>
    <p>This is the 6th Page</p>
<div style='page-break-after: always;'></div>
    <p>This is the 7th Page</p>";

// Create header
HtmlHeaderFooter header = new HtmlHeaderFooter()
{
    HtmlFragment = "<center><i>{page} of {total-pages}</i></center>"
};

// Render the PDF
ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf(multi_page_html);

// Define a range to cover all the pages
var allPageIndices = Enumerable.Range(0, pdf.PageCount);
```

### Configuring for Different Page Groupings

Here's how you can apply page numbers only to certain pages:

**Even Page Indexes** (displaying page numbers on pages viewed as odd due to zero-based index):

```cs
var evenPageIndices = allPageIndices.Where(i => i % 2 == 0);

pdf.AddHtmlHeaders(header, 1, evenPageIndices);
pdf.SaveAs("EvenPages.pdf");
```

**Odd Page Indexes**: (setting numbers on pages appearing as even):

```cs
var oddPageIndexes = allPageIndices.Where(i => i % 2 != 0);

pdf.AddHtmlHeaders(header, 1, oddPageIndexes);
pdf.SaveAs("OddPages.pdf");
```

**Last Page Only**:

```cs
var lastPageIndex = new List<int>() { pdf.PageCount - 1 };

pdf.AddHtmlHeaders(header, 1, lastPageIndex);
pdf.SaveAs("LastPageOnly.pdf");
```

**First Page Only**:

```cs
var firstPageIndex = new List<int>() { 0 };

pdf.AddHtmlHeaders(header, 1, firstPageIndex);
pdf.SaveAs("FirstPageOnly.pdf");
```

**Skip First Page**:

```cs
var skipFirstPage = allPageIndices.Skip(1);

pdf.AddHtmlHeaders(header, 1, skipFirstPage);
pdf.SaveAs("SkipFirstPage.pdf");
```

**Skip First Page and Don’t Count It** (begin numbering from the second page):

```cs
var skipFirstPageAndDontCountIt = allPageIndices.Skip(1);

pdf.AddHtmlHeaders(header, 0, skipFirstPageAndDontCountIt);
pdf.SaveAs("SkipFirstPageAndDontCountIt.pdf");
```

For a comprehensive overview of all possible metadata configurations, please refer to the [Add Headers and Footers](https://ironpdf.com/how-to/headers-and-footers/#anchor-metadata-to-text-header-footer) guide.