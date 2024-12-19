# Managing Page Breaks in HTML PDFs with IronPDF

***Based on <https://ironpdf.com/how-to/html-to-pdf-page-breaks/>***


IronPDF provides robust support for managing page breaks in PDF documents. Unlike HTML documents which are designed to be scrollable, PDFs are formatted as multi-page documents and are often used for printing.

### Getting Started with IronPDF

---

## Implementing a Page Break

You can introduce a page break in your HTML content by using the following code snippet:

```html
<div style='page-break-after: always;'></div>
```

### Example: Adding a Page Break

Consider the scenario where you have a table and an image in your HTML content, and you want them to appear on separate pages in the PDF. You can achieve this by inserting a page break after the table.

#### Table Example
<table style="border: 1px solid #000000">
  <tr>
    <th>Company</th>
    <th>Product</th>
  </tr>
  <tr>
    <td>Iron Software</td>
    <td>IronPDF</td>
  </tr>
  <tr>
    <td>Iron Software</td>
    <td>IronOCR</td>
  </tr>
</table>

#### Image Example
<img src="https://ironpdf.com/static-assets/pdf/how-to/html-to-pdf-page-breaks/ironpdf-logo-text-dotnet.svg" style="border:5px solid #000000; padding:3px; margin:5px">

Here's the C# code that generates a PDF with the table on the first page and the image on the second:

```cs
using IronPdf;
const string html = @"
<table style='border: 1px solid #000000'>
  <tr>
    <th>Company</th>
    <th>Product</th>
  </tr>
  <tr>
    <td>Iron Software</td>
    <td>IronPDF</td>
  </tr>
  <tr>
    <td>Iron Software</td>
    <td>IronOCR</td>
  </tr>
</table>
<div style='page-break-after: always;'></div>
<img src='https://ironpdf.com/img/products/ironpdf-logo-text-dotnet.svg'>";
var renderer = new ChromePdfRenderer();
var pdf = renderer.RenderHtmlAsPdf(html);
pdf.SaveAs("Page_Break.pdf");
```

The generated PDF has two pages with the table on the first page and the image on the second:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/html-to-pdf-page-breaks/Page_Break.pdf#view=fit" width="100%" height="500px"></iframe>

## How to Prevent Page Breaks in Images

Wrap your images in a `div` with the CSS `page-break-inside: avoid` attribute to prevent a page break within the image:

```html
<div style='page-break-inside: avoid'>
 <img src='no-break-me.png'>
</div>
```

## Preventing Page Breaks in Tables

To prevent page breaks inside a table, use the `page-break-inside: avoid` attribute within a wrapping `div` rather than applying it directly to the table:

```html
<div style='page-break-inside: avoid'>
  <table>
    <!-- Table contents -->
  </table>
</div>
```
For tables that span multiple pages, ensuring headers and footers repeat can be achieved using `<thead>`:

```html
<thead>
  <tr>
    <th>C Sharp</th>
    <th>VB</th>
  </tr>
</thead>
```

## Leveraging Advanced CSS3 for Page Management

For more intricate control over page breaks:

```html
<style type="text/css">
  table { page-break-inside:auto }
  tr    { page-break-inside:avoid; page-break-after:auto }
  thead { display:table-header-group }
  tfoot { display:table-footer-group }
</style>
```