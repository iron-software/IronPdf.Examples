# Rotate PDF Text and Pages in .NET

***Based on <https://ironpdf.com/how-to/rotating-text/>***


When discussing the rotation of PDF text or pages, this typically involves altering the orientation of an entire page or specific text elements within a PDF file. You can rotate content by specified degrees such as 90, 180, or 270, either clockwise or counterclockwise to reposition it according to your requirements.

## Quickstart: Rotate PDF Pages in .NET with IronPDF

With IronPDF, rotating PDF pages in your .NET projects is straightforward. A few simple lines of code allow you to change the orientation of your PDF content to the angle you prefer. This guide will demonstrate how to rotate the first page of a PDF file by 90 degrees and save the updated document effortlessly. This is ideal for developers aiming to improve document layout with minimal coding.

```cs
:title=Efficient PDF page or text rotation!
IronPdf.PdfDocument.FromFile("input.pdf")
  .SetAllPageRotations(IronPdf.PdfPageRotation.Clockwise90)
  .SaveAs("rotated.pdf");
```

## Rotate PDF Pages

For adjusting the rotation of PDF pages, you can utilize the methods `SetPageRotation`, `SetPageRotations`, and `SetAllPageRotations`. These are used to apply rotation settings to a single page, multiple pages, or all pages in a document, respectively. These functions overwrite the existing page rotations with the designated degrees in a clockwise direction. If a page is already rotated to the intended degree, these methods won't alter the document.

```csharp
using IronPdf;
using IronPdf.Rendering;
using System.Linq;

// Load a PDF document
PdfDocument pdf = PdfDocument.FromFile("multi-page.pdf");

// Adjust rotation for a single page
pdf.SetPageRotation(0, PdfPageRotation.Clockwise90);

// Adjust rotation for multiple pages
pdf.SetPageRotations(Enumerable.Range(1,3), PdfPageRotation.Clockwise270);

// Adjust rotation for all pages in the document
pdf.SetAllPageRotations(PdfPageRotation.Clockwise180);

pdf.SaveAs("rotated.pdf");
```

<hr class="separator">

## Use CSS3 to Rotate Text

Another capability is to rotate text or entire pages after converting HTML to PDF in .NET, which might be required, for instance, to display vertical text in your PDFs. Using HTML5 and CSS3 within the IronPDF .NET Library you already have installed can accomplish this. This is enabled through the `transform: rotate(...)` CSS3 style, allowing any HTML element to be rotated to the desired angle.

```csharp
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

Explore more capabilities by visiting our tutorial page: [Edit PDFs](https://ironpdf.com/tutorials/csharp-edit-pdf-complete-tutorial/).