# Rotate PDF Text and Pages in .NET

Adjusting the orientation of text or entire pages within a PDF document involves modifying how they are displayed, either by rotating them by common degree increments such as 90, 180, or 270 degrees. This manipulation of content alignment can be executed either clockwise or counterclockwise.

## Rotate PDF Pages

The methods `SetPageRotation`, `SetPageRotations`, and `SetAllPageRotations` are utilized to adjust the orientation of a single page, multiple pages, or every page in a document, respectively. When using these methods, the current orientation of the page is replaced with the designated rotation value, applied in a clockwise direction. If the rotation set is the same as the current page orientation, these methods will not modify the document.

```cs
using IronPdf;
using IronPdf.Rendering;
using System.Linq;

// Load PDF document
PdfDocument pdfDocument = PdfDocument.FromFile("multi-page.pdf");

// Apply clockwise 90 degrees rotation to the first page
pdfDocument.SetPageRotation(0, PdfPageRotation.Clockwise90);

// Apply clockwise 270 degrees rotation to specified range of pages
pdfDocument.SetPageRotations(Enumerable.Range(1,3), PdfPageRotation.Clockwise270);

// Rotate all pages in the document to 180 degrees clockwise
pdfDocument.SetAllPageRotations(PdfPageRotation.Clockwise180);

pdfDocument.SaveAs("rotated.pdf");
```

<hr class="separator">

## Use CSS3 to Rotate Text

During the transformation from HTML to PDF using .NET, sometimes it's necessary to programmatically adjust the orientation of text or entire pages. One common need is to have text aligned vertically in a PDF, which can be achieved using HTML5 and CSS3.

**CSS3** facilitates the rotation of text to any arbitrary degree following the conversion from HTML to PDF. This adjustment is made possible with the `-webkit-transform: rotate` style in CSS3, which allows HTML elements to be rotated to any specified angle.

The property `[-webkit-transform](https://www.quackit.com/css/properties/webkit/css_-webkit_transform.cfm)` supports various 2D and 3D rotational transformations and effects on HTML elements. Here is an example illustrating how to use C# and the [PDF .NET Library](https://ironpdf.com/use-case/pdf-dot-net-library/) for rotating text by 180 degrees in a PDF:

```cs
using IronPdf;

var pdfRenderer = new IronPdf.ChromePdfRenderer();

var pdfDocument = pdfRenderer.RenderHtmlAsPdf(@"
<html>
<head>
 <style>
  .rotated {
  -webkit-transform: rotate(-180deg);
  width: 400;
  height: 400;
  }
</style>
</head>
<body>
<p class='rotated'>Rotated Text</p>
</body>
</html>
");

pdfDocument.SaveAs("rotated.pdf");
```