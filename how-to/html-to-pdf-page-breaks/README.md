# Managing Page Breaks in HTML PDF Conversion

***Based on <https://ironpdf.com/how-to/html-to-pdf-page-breaks/>***


IronPDF facilitates the integration of page breaks within PDF documents. Unlike HTML documents which display content in a continuous scroll format, PDF files are structured into multiple pages suitable for printing.

## Quickstart: Page Breaks Management in HTML to PDF Conversion

Leveraging IronPDF to convert HTML to PDF with page breaks is seamless. With the straightforward addition of CSS styling such as `page-break-after: always;`, developers can dictate the placement of page breaks. This functionality not only enhances the structure of the resulting PDF but also improves its readability, making it ideal for applications necessitating efficient HTML to PDF conversions.

```cs
:title=Instant HTML to PDF Conversion with Page Breaks
new IronPdf.ChromePdfRenderer()
  .RenderHtmlAsPdf("<html><body><h1>Hello, World!</h1><div style='page-break-after: always;'></div></body></html>")
  .SaveAs("documentWithBreaks.pdf");
```

## Implementing a Page Break

To insert a page break after an element within the HTML, you can integrate the following snippet:

```html
<div style="page-break-after: always;"></div>
```

### Example: Using Page Breaks to Separate Content

Let's say you have a table and an image in your HTML content, and you want them on two different pages. Adding a page break following the table achieves this separation.

#### The Table

```html
<table style="border: 1px solid black;">
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
```

#### The Image

```html
<img src="https://ironpdf.com/static-assets/pdf/how-to/html-to-pdf-page-breaks/ironpdf-logo-text-dotnet.svg" style="border:5px solid black; padding:3px; margin:5px" />
```

```csharp
using IronPdf;

const string html = @"
<table style='border: 1px solid black;'>
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

<div style='page-break-after: always;'> </div>

<img src='https://ironpdf.com/img/products/ironpdf-logo-text-dotnet.svg'>";

var renderer = new ChromePdfRenderer();

var pdf = renderer.RenderHtmlAsPdf(html);
pdf.SaveAs("Document_With_Page_Breaks.pdf");
```

Here, the PDF generated will exhibit the Table on the first page and the Image on the second page:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/html-to-pdf-page-breaks/Page_Break.pdf#view=fit" width="100%" height="500px"></iframe>

## Managing Page Breaks in Images and Tables

To prevent breaking within an image or a table, use the CSS `page-break-inside` property, encapsulated by a `DIV` element:

```html
<div style="page-break-inside: avoid">
    <img src="no-break-me.png" />
</div>
```

For tables, particularly large ones requiring the headers and footers on each PDF page, utilize the `<thead>`:

```html
<thead>
    <tr>
        <th>C Sharp</th><th>VB</th>
    </tr>
</thead>
```

### Extended CSS3 for Precise Layout Control

Enhance layout control further with CSS3 specifications alongside your table structure:

```html
<style type="text/css">
    table { page-break-inside:auto }
    tr { page-break-inside:avoid; page-break-after:auto }
    thead { display:table-header-group }
    tfoot { display:table-footer-group }
</style>
```