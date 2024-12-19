# Managing Page Orientation and Rotation with IronPDF

***Based on <https://ironpdf.com/how-to/page-orientation-rotation/>***


## Introduction to Page Orientation and Rotation

**Page Orientation** refers to the configuration of a page, which can be vertically set (portrait) or laid out horizontally (landscape).

**Page Rotation**, alternatively, means adjusting a page’s tilt to various degrees (e.g., 90, 180, 270 degrees). This feature is especially beneficial for rectifying the alignment of a page or adapting to specific viewing requirements.

With IronPDF, users can set page orientation to portrait or landscape during the document creation process. It is also conceivable to rotate pages in your PDF to desired angles, such as 0, 90, 180, or 270 degrees, whether the pages are existing or newly added to the document.

## Example of Setting Page Orientation

While creating a PDF from other document formats, you can decide on its page orientation via the **RenderingOptions** class, which includes the **PaperOrientation** property. By default, the orientation is set to portrait.

### Example Code:

```cs
using IronPdf;
using IronPdf.Rendering;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Configure paper orientation
renderer.RenderingOptions.PaperOrientation = PdfPaperOrientation.Landscape;

PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");

pdf.SaveAs("landscape.pdf");
```

### Display PDF:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/page-orientation-rotation/landscape.pdf#zoom=55%" width="100%" height="450px">
</iframe>

<hr>

## Example on Applying Page Rotation

IronPDF allows four rotation settings:

- **None**: 0 degrees or no rotation.
- **Clockwise90**: Rotates the page 90 degrees clockwise.
- **Clockwise180**: Rotates the page 180 degrees clockwise.
- **Clockwise270**: Rotates the page 270 degrees clockwise.

All instructions regarding the page index use zero-based indexing.

### Rotate Pages:

To manipulate page rotation use the following methods:

- `SetAllPageRotations`: Applies a specified rotation to every page.
- `SetPageRotation`: Applies a rotation to a particular single page.
- `SetPageRotations`: Applies a rotation to a specific set of pages.

```cs
using IronPdf;
using IronPdf.Rendering;
using System.Collections.Generic;

PdfDocument pdf = PdfDocument.FromFile("landscape.pdf");

// Apply rotation to all pages
pdf.SetAllPageRotations(PdfPageRotation.Clockwise90);

// Apply rotation to a specific page
pdf.SetPageRotation(1, PdfPageRotation.Clockwise180);

// Target multiple specific pages for rotation
List<int> selectedPages = new List<int>() { 0, 3 };
pdf.SetPageRotations(selectedPages, PdfPageRotation.Clockwise270);

pdf.SaveAs("rotatedLandscape.pdf");
```

### Display Rotated PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/page-orientation-rotation/rotatedLandscape.pdf#zoom=55%" width="100%" height="450px">
</iframe>

### Retrieve Page Rotation:

To access the rotation setting of any specific page:

```cs
using IronPdf;
using IronPdf.Rendering;

PdfDocument pdf = PdfDocument.FromFile("rotatedLandscape.pdf");

PdfPageRotation rotation = pdf.GetPageRotation(1);
```