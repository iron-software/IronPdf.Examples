# Manipulating Page Breaks in HTML to PDF Conversions

IronPDF provides support for incorporating page breaks in PDF documents, crucial for distinguishing from HTML's scrolling interface as PDF pages often require precise management for print purposes.

## Implementing a Page Break

To introduce a page break within an HTML document for PDF conversion, you can include the following snippet in your HTML markup:

```html
<div style="page-break-after: always;"></div>
```

### Example of Implementing a Page Break

In the example below, my HTML comprises a table and an image. I aim for these two elements to appear on separate pages, hence inserting a page break immediately after the table.

#### Table Representation
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

#### Accompanying Image
<img src="https://ironpdf.com/static-assets/pdf/how-to/html-to-pdf-page-breaks/ironpdf-logo-text-dotnet.svg" style="border:5px solid #000000; padding:3px; margin:5px">

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

This code snippet will generate a PDF with the table on the first page and the image on the second, viewable below:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/html-to-pdf-page-breaks/Page_Break.pdf#view=fit" width="100%" height="500px">
</iframe>

## Preventing Page Breaks Within Images

To avoid an unintentional page break in an image or table, employ the CSS `page-break-inside` property on a DIV element encapsulating the content.

```html
<div style='page-break-inside: avoid'>
 <img src='no-break-me.png'>
</div>
```

## Controlling Page Breaks in Tables

Similar to images, you can prevent breaks within tables using:

```css
page-break-inside: avoid;
```

For large HTML tables spreading across multiple PDF pages, maintaining consistency of headers and footers is achievable with a `<thead>` group:

```html
<thead>
    <tr>
        <th>C Sharp</th><th>VB</th>
    </tr>
</thead>
```

## Leveraging Advanced CSS3 for Optimal Layout

Enhance your document's layout by integrating CSS3 settings alongside your header group for better control:

```html
<style type="text/css">
    table { page-break-inside:auto }
    tr    { page-break-inside:avoid; page-break-after:auto }
    thead { display:table-header-group }
    tfoot { display:table-footer-group }
</style>
```
This configuration guides CSS behavior for PDF rendering, ensuring content integrity across different pages.