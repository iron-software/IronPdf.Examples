# Adjusting PDF Text and Pages Orientation in .NET

***Based on <https://ironpdf.com/how-to/rotating-text/>***


Adjusting the orientation of PDF text or entire pages involves modifying how text elements or pages are displayed within a PDF file. These adjustments typically involve rotations—commonly 90, 180, or 270 degrees—and can be either clockwise or counterclockwise to suit your document manipulation needs.

## Modifying the Orientation of PDF Pages

To change the orientation of PDF pages, you can utilize methods like `SetPageRotation`, `SetPageRotations`, and `SetAllPageRotations` to modify the rotation of a single page, multiple pages, or every page within a document, respectively. These methods will replace any existing page rotations with the new angle you specify, which must be defined in a clockwise direction. If a page is already rotated to the angle you apply, the page’s appearance won't change.

```cs
using System.Linq;
using IronPdf;
namespace ironpdf.RotatingText
{
    public class RotatePagesSection
    {
        public void Execute()
        {
            // Load existing PDF document
            PdfDocument pdf = PdfDocument.FromFile("multi-page.pdf");
            
            // Adjust the rotation of the first page
            pdf.SetPageRotation(0, PdfPageRotation.Clockwise90);
            
            // Alter orientations for a range of pages
            pdf.SetPageRotations(Enumerable.Range(1, 3), PdfPageRotation.Clockwise270);
            
            // Apply new orientation to all pages in the document
            pdf.SetAllPageRotations(PdfPageRotation.Clockwise180);
            
            // Save the modified document
            pdf.SaveAs("rotated-pages.pdf");
        }
    }
}
```

<hr class="separator">

## Applying CSS3 for Text Rotation

When converting from HTML to PDF in .NET, there are situations where text or even entire pages need to be rotated. This often includes setting up text to appear vertically in the PDFs, which can be achieved using HTML5 and CSS3 techniques.

**CSS3** transformations are possible after converting a PDF from HTML using your [IronPDF .NET Library](https://ironpdf.com/?utm_source=use-case-page). Specifically, the `-webkit-transform: rotate` CSS property allows the rotation of HTML elements by any degree.

You can see a brief example of implementing a 180-degree text rotation in C# converting HTML to PDF below:

```cs
using IronPdf;
namespace ironpdf.RotatingText
{
    public class RotateTextSection
    {
        public void Execute()
        {
            var renderer = new IronPdf.ChromePdfRenderer();
            
            var htmlContent = @"
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
            ";
            
            var pdf = renderer.RenderHtmlAsPdf(htmlContent);
            
            pdf.SaveAs("rotated-text.pdf");
        }
    }
}
```