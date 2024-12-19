# Modifying PDF Text and Page Orientation in .NET

***Based on <https://ironpdf.com/how-to/rotating-text/>***


Modifying the orientation of text or pages in a PDF document involves altering the positioning of either the whole page or specific textual elements. These adjustments are generally executed in increments of 90, 180, or 270 degrees, allowing for clockwise or counterclockwise shifts.

<h2>Introducing IronPDF</h2>

--------

## Altering PDF Page Orientation

To change the orientation of pages within a PDF, IronPDF provides methods such as `SetPageRotation`, `SetPageRotations`, and `SetAllPageRotations`. Each method enables setting the rotation for a single, multiple, or all pages, respectively. This rotation is applied clockwise and fully replaces any existing setting, unless the current page is already at the specified orientation, in which case no change will occur.

```cs
using IronPdf;
using IronPdf.Rendering;
using System.Linq;

// Load the PDF document
PdfDocument pdf = PdfDocument.FromFile("multi-page.pdf");

// Apply rotation to a specific page
pdf.SetPageRotation(0, PdfPageRotation.Clockwise90);

// Apply rotation to several pages
pdf.SetPageRotations(Enumerable.Range(1,3), PdfPageRotation.Clockwise270);

// Apply rotation to every page in the document
pdf.SetAllPageRotations(PdfPageRotation.Clockwise180);

pdf.SaveAs("rotated.pdf");
```

<hr class="separator">

## Rotating Text Using CSS3

Upon converting HTML to a PDF in .NET, there may arise situations where text or page rotation is required post-conversion. An example includes setting text to be vertically aligned within the PDF, achievable through HTML5 and CSS3. Here’s the methodology to accomplish this task.

**CSS3** capabilities allow you to rotate text to a specific angle once you've transformed your HTML document to a PDF using the [IronPDF .NET Library](https://www.ironpdf.com/?utm_source=use-case-page). Employing the `-webkit-transform: rotate` CSS style, you can manipulate any HTML element to any angle.

The CSS property `[-webkit-transform](https://www.quackit.com/css/properties/webkit/css_-webkit-transform.cfm)` is versatile, supporting various 3D and rotational transformations for HTML elements. Below is an example demonstrating how to rotate text by 180 degrees using C# and IronPDF:

```cs
using IronPdf;

var renderer = new IronPdf.ChromePdfRenderer();

var pdf = renderer.RenderHtmlAsPdf(@"
<html>
<head>
 <style>
  .rotated{
  -webkit-transform: rotate(-180deg);
  width:400;
  height:400;
  }
</style>
</head>
<body>
<p class='rotated'>Rotated Text</p>
</body>
</html>
");

pdf.SaveAs("rotated.pdf");
```