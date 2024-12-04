# Setting Page Orientation and Rotation in IronPDF

***Based on <https://ironpdf.com/how-to/page-orientation-rotation/>***


Page orientation determines the layout of the page, either in a vertical (portrait) or horizontal (landscape) manner. 

Page rotation modifies the angle at which a page appears, ideal for correcting orientation, and assists in achieving specific presentation needs. You can set page angles to 90, 180, or 270 degrees to adjust the view accordingly.

IronPDF grants the flexibility to designate page orientation as portrait or landscape and to rotate pages at 0, 90, 180, or 270-degree angles as necessary during the PDF rendering process.

## Example of Configuring Page Orientation

You can set the orientation only when converting other document formats into PDF. Use the `PaperOrientation` property of the `RenderingOptions` class to specify orientation: either portrait or landscape, with portrait being the default.

### Example Code

```cs
using IronPdf.Rendering;
using IronPdf;
namespace ironpdf.PageOrientationRotation
{
    public class OrientationExample
    {
        public void Execute()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Setting the paper orientation
            renderer.RenderingOptions.PaperOrientation = PdfPaperOrientation.Landscape;
            
            PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");
            
            pdf.SaveAs("landscape.pdf");
        }
    }
}
```

### Rendered PDF Output

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/page-orientation-rotation/landscape.pdf#zoom=55%" width="100%" height="450px">
</iframe>

<hr>

## Example of Adjusting Page Rotation

IronPDF supports several rotation settings for flexibility:

- **None**: 0-degree (default, no rotation).
- **Clockwise90**: Rotates the page by 90 degrees clockwise.
- **Clockwise180**: Rotates the page by 180 degrees clockwise.
- **Clockwise270**: Rotates the page by 270 degrees clockwise.

### Methods to Adjust Page Rotation

Adjust the rotation for individual, multiple, or all pages in a document:

- `SetAllPageRotations`: Applies a specified rotation to all pages.
- `SetPageRotation`: Applies rotation to a specific page.
- `SetPageRotations`: Applies the chosen rotation to a list of specific pages.

```cs
using System.Collections.Generic;
using IronPdf;
namespace ironpdf.PageOrientationRotation
{
    public class RotationExample
    {
        public void Execute()
        {
            PdfDocument pdf = PdfDocument.FromFile("landscape.pdf");
            
            // Rotate all pages
            pdf.SetAllPageRotations(PdfPageRotation.Clockwise90);
            
            // Rotate a single page
            pdf.SetPageRotation(1, PdfPageRotation.Clockwise180);
            
            // Rotate selected pages
            List<int> selectedPages = new List<int>() { 0, 3 };
            pdf.SetPageRotations(selectedPages, PdfPageRotation.Clockwise270);
            
            pdf.SaveAs("rotatedLandscape.pdf");
        }
    }
}
```

### Rotated PDF Output

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/page-orientation-rotation/rotatedLandscape.pdf#zoom=55%" width="100%" height="450px">
</iframe>

### Retrieving Page Rotation

The `GetPageRotation` method allows you to ascertain the rotation of a specific page by providing the page index.

```cs
using IronPdf.Rendering;
using IronPdf;
namespace ironpdf.PageOrientationRotation
{
    public class RetrieveRotationExample
    {
        public void Execute()
        {
            PdfDocument pdf = PdfDocument.FromFile("rotatedLandscape.pdf");
            
            PdfPageRotation rotation = pdf.GetPageRotation(1);
        }
    }
}
```