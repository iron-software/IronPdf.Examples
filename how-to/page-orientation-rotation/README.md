# Setting Page Orientation and Rotation

***Based on <https://ironpdf.com/how-to/page-orientation-rotation/>***


Page orientation indicates the layout direction of a page—portrait, which is vertical, or landscape, which is horizontal.

Page rotation, on the other hand, modifies the angle of the page. This feature lets you adjust the orientation for purposes like aligning content or tailoring to specific presentation needs. You can set page angles to 90, 180, or 270 degrees.

With IronPDF, you can easily set the orientation to either portrait or landscape when rendering PDFs and also rotate pages to angles such as 0, 90, 180, or 270 degrees, customizing them as required.

## Getting Started: Set PDF Page Orientation and Rotation Using C#

IronPDF simplifies the process of setting the orientation and rotation of PDF pages within .NET C# applications. Start by loading your PDF and then apply the required rotations or orientations using straightforward method calls, saving the revised document quickly to meet your layout needs. Follow this straightforward guide to get up and running quickly.

```cs
:title=Quickly Apply Rotation & Orientation to PDF Pages
IronPdf.PdfDocument.FromFile("file.pdf")
    .SetAllPageRotations(IronPdf.PdfDocument.PageRotation.Rotate90)
    .SaveAs("new-rotated.pdf");
```



## Example of Setting Page Orientation

To assign page orientation, you must be generating a PDF from other formats. Utilize the `PaperOrientation` attribute available in the `RenderingOptions` class, which can be set to portrait (the default) or landscape.

### Implementing Code

```csharp
using IronPdf;
using IronPdf.Rendering;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Adjust paper orientation
renderer.RenderingOptions.PaperOrientation = PdfPaperOrientation.Landscape;

PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");

pdf.SaveAs("landscape-oriented.pdf");
```

### Displaying the PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/page-orientation-rotation/landscape.pdf#zoom=55%" width="100%" height="450px">
</iframe>

<hr>

## Example of Setting Page Rotation

IronPDF offers four rotation settings:

- `None`: 0 degrees, meaning no rotation.
- `Clockwise90`: Rotates the page 90 degrees clockwise.
- `Clockwise180`: Rotates the page 180 degrees clockwise.
- `Clockwise270`: Rotates the page 270 degrees clockwise.

Zero-based indexing is used when referring to page indices in the methods below.

### Implementing Page Rotations

Employ the following methods to rotate a single page, multiple selected pages, or all pages in the document.

- `SetAllPageRotations`: Applies specified rotation to all pages.
- `SetPageRotation`: Applies specified rotation to a single page.
- `SetPageRotations`: Applies specified rotation to a list of selected pages.

```csharp
using IronPdf;
using IronPdf.Rendering;
using System.Collections.Generic;

PdfDocument pdf = PdfDocument.FromFile("landscape.pdf");

// Rotate all pages
pdf.SetAllPageRotations(PdfPageRotation.Clockwise90);

// Rotate a specific page
pdf.SetPageRotation(1, PdfPageRotation.Clockwise180);

// Rotate selected pages
List<int> pagesToRotate = new List<int>() { 0, 3 };
pdf.SetPageRotations(pagesToRotate, PdfPageRotation.Clockwise270);

pdf.SaveAs("multiple-rotated.pdf");
```

### Viewing the Rotated PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/page-orientation-rotation/rotatedLandscape.pdf#zoom=55%" width="100%" height="450px">
</iframe>

### Retrieving Page Rotations

To find out the rotation of a specific page within the PDF document, use the `GetPageRotation` method by providing the page index.

```csharp
using IronPdf;
using IronPdf.Rendering;

PdfDocument pdf = PdfDocument.FromFile("multiple-rotated.pdf");

PdfPageRotation currentRotation = pdf.GetPageRotation(1);
```