# How to Incorporate Page Numbers into a PDF Document

***Based on <https://ironpdf.com/how-to/page-numbers/>***


Page numbering assigns unique identifiers to each page of a PDF, facilitating easier navigation and referencing. This feature is invaluable for locating specific portions of content, understanding one's position within the document, and referencing for academic or professional purposes. Using IronPDF, you have the ability to seamlessly integrate page numbers into your PDF documents.

## Simplified Guide: Inserting Page Numbers in PDFs

Enhance your PDF documents by easily adding page numbers with IronPDF. A few lines of C# code allow you to dynamically insert page numbers within the headers or footers, control their location, and designate which pages should feature them. Whether you're modifying existing PDFs or crafting new ones, IronPDF offers an efficient and adaptable solution for improving document structure and readability. Start following this guide to quickly integrate page numbering into your projects.

```cs
:title=Implementing page numbers easily!
// Instantiate a new renderer
var pdfRenderer = new IronPdf.ChromePdfRenderer { RenderingOptions = { HtmlFooter = new IronPdf.HtmlHeaderFooter { HtmlFragment = "<center>{page} of {total-pages}</center>", DrawDividerLine = true } } };
var pdfDocument = pdfRenderer.RenderHtmlAsPdf("<h1>First Page</h1><div style='page-break-after:always;'></div><h1>Second Page</h1>");
pdfDocument.SaveAs("numbered-pages-output.pdf");
```

## Example of Adding Page Numbers

Using placeholders like `{page}` and `{total-pages}`, you can implement page number features using the **TextHeaderFooter** or the **HtmlHeaderFooter** classes to include current and total page numbers.

```csharp
using IronPdf;

// Initiate a textual header
TextHeaderFooter textHeader = new TextHeaderFooter()
{
    CenterText = "{page} of {total-pages}"
};

// Initiate an HTML footer
HtmlHeaderFooter htmlFooter = new HtmlHeaderFooter()
{
    HtmlFragment = "<center><i>{page} of {total-pages}<i></center>"
};

// Render a fresh PDF
ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Welcome to our PDF!</h1>");

// Append the header and footer
pdf.AddTextHeaders(textHeader);
pdf.AddHtmlFooters(htmlFooter);

pdf.SaveAs("pdfDocumentWithPageNumbers.pdf");
```

The output from this example is available here:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/page-numbers/pdf-with-page-numbers.pdf" width="100%" height="500px">
</iframe>

You can directly integrate the headers and footers within the rendering options of the **ChromePdfRenderer** as shown in the example below:

```csharp
using IronPdf;

// Setup renderer with headers and footers
ChromePdfRenderer renderer = new ChromePdfRenderer();
renderer.RenderingOptions.TextHeader = new TextHeaderFooter()
{
    CenterText = "{page} of {total-pages}"
};
renderer.RenderingOptions.HtmlFooter = new HtmlHeaderFooter()
{
    HtmlFragment = "<center><i>{page} of {total-pages}<i></center>"
};

string htmlContent = @"
    <h1>Welcome!</h1>
<div style='page-break-after: always;'/>
    <h1>Page Two</h1>";

// Generate the new PDF
PdfDocument pdf = renderer.RenderHtmlAsPdf(htmlContent);

pdf.SaveAs("PageNumberOptions.pdf");
```

## Specifying Page Numbers on Certain Pages

IronPDF lets you choose specific pages for applying page numbers, such as starting from a certain page or targeting pages with even or odd indexes.

Let's prepare a multi-page PDF to apply page numbering.

```csharp
using IronPdf;
using System.Linq;

string htmlPages = @"
    <p>Opening Page</p>
<div style = 'page-break-after: always;' ></div>
    <p>Second Page</p>";

// Setup a header with numbering on all pages
HtmlHeaderFooter header = new HtmlHeaderFooter()
{
    HtmlFragment = "<center><i>{page} of {total-pages}<i></center>"
};

// Produce the PDF
ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf(htmlPages);

// Define all pages
var pageNumbers = Enumerable.Range(0, pdf.PageCount);
```

### Apply numbers to even-indexed pages

This snippet targets even-indexed pages (which translates to odd page numbers):

```csharp
// Identify even indexes for page numbering
var evenIndexPages = pageNumbers.Where(i => i % 2 == 0);

pdf.AddHtmlHeaders(header, 1, evenIndexPages);
pdf.SaveAs("EvenIndexedPages.pdf");
```

### Number the odd-indexed pages

Here, page numbers are added to odd-indexed pages (resulting in even page numbers):

```csharp
// Filter for odd indexes
var oddIndexPages = pageNumbers.Where(i => i % 2 != 0);

pdf.AddHtmlHeaders(header, 1, oddIndexPages);
pdf.SaveAs("OddIndexedPages.pdf");
```

### Numbering the last page

To number only the last pageNo

```csharp
// Target the final page for numbering
var lastPage = new List<int>() { pdf.PageCount - 1 };

pdf.AddHtmlHeaders(header, 1, lastPage);
pdf.SaveAs("NumberOnFinalPage.pdf");
```

### Targeting the first page

To apply a pageNumber to only the first pageNo

```csharp
// Set numbering to start on the first pageNo
var firstPage = new List<int>() { 0 };

pdf.AddHtmlHeaders(header, 1, firstPage);
pdf.SaveAs("FirstPageNumbering.pdf");
```

### Override initial page numbering

This example skips the first page in numbering:

```csharp
// Exclude the first page from numbering
var skipFirstPage = pageNumbers.Skip(1);

pdf.AddHtmlHeaders(header, 1, skipFirstPage);
pdf.SaveAs("ExcludeFirstPageNumbering.pdf");
```

For more detailed options and methods, consider visiting the [IronPDF Headers and Footers Documentation](https://ironpdf.com/how-to/headers-and-footers/#anchor-metadata-to-text-header-footer).