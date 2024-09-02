# Managing Page Orientation and Rotation in PDFs

Page Orientation determines the layout of a page—either vertically (called portrait) or horizontally (known as landscape).

Page Rotation, on the other hand, involves adjusting the page's angle to modify its orientation. This feature is particularly helpful for correcting alignments or catering to specific visual preferences. The possible rotation angles are 90, 180, and 270 degrees.

IronPDF provides functionality to easily set the page orientation to either portrait or landscape when rendering new documents. Moreover, for both new and existing PDF files, you have the flexibility to adjust page rotations to 0, 90, 180, or 270 degrees, depending on your requirements.

## Example of Setting Page Orientation

Setting the orientation is feasible only when creating a new PDF from different formats. The `RenderingOptions` class offers a `PaperOrientation` property, which you can adjust to either portrait or landscape. By default, the orientation is set to portrait.

### Code Example

```cs
// Required namespaces
using IronPdf;
using IronPdf.Rendering;

// Create a renderer instance
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Modify the paper orientation to landscape
renderer.RenderingOptions.PaperOrientation = PdfPaperOrientation.Landscape;

// Render a webpage as PDF
PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");

// Save the PDF file
pdf.SaveAs("landscape.pdf");
```

### Generated PDF Display

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/page-orientation-rotation/landscape.pdf#zoom=55%" width="100%" height="450px">
</iframe>

<hr>

## Example of Page Rotation 

IronPDF supports four rotation settings:

- **None**: for an unrotated page (0 degrees).
- **Clockwise90**: rotates the page 90 degrees clockwise.
- **Clockwise180**: rotates the page 180 degrees clockwise.
- **Clockwise270**: rotates the page 270 degrees clockwise.

These methods allow you to apply rotation to a single page, multiple selected pages, or all pages in a document.

### Adjusting Page Rotation

```cs
// Required namespaces
using IronPdf;
using IronPdf.Rendering;
using System.Collections.Generic;

// Load an existing PDF
PdfDocument pdf = PdfDocument.FromFile("landscape.pdf");

// Rotate all pages by 90 degrees
pdf.SetAllPageRotations(PdfPageRotation.Clockwise90);

// Rotate a specific page by 180 degrees
pdf.SetPageRotation(1, PdfPageRotation.Clockwise180);

// Rotate select pages by 270 degrees
List<int> selectedPages = new List<int>() { 0, 3 };
pdf.SetPageRotations(selectedPages, PdfPageRotation.Clockwise270);

// Save the modified PDF
pdf.SaveAs("rotatedLandscape.pdf");
```

### PDF with Rotation Applied

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/page-orientation-rotation/rotatedLandscape.pdf#zoom=55%" width="100%" height="450px">
</iframe>

### Checking Page Rotation

To find out the rotation of any particular page within your PDF, use the `GetPageRotation` method by supplying the page index as follows:

```cs
using IronPdf;
using IronPdf.Rendering;

// Load the rotated PDF
PdfDocument pdf = PdfDocument.FromFile("rotatedLandscape.pdf");

// Retrieve the rotation of a specific page
PdfPageRotation rotation = pdf.GetPageRotation(1);
```