# Enhancing PDFs with Backgrounds and Foregrounds

***Based on <https://ironpdf.com/how-to/background-foreground/>***


Incorporating a background into a PDF lets you append an image or another PDF beneath the principal content. This is particularly useful for crafting unique letterheads, inserting watermarks, or enhancing documents with artistic elements. Conversely, foreground overlay enables the addition of text, images, or other items above the existing PDF content. This method is widely employed for appending annotations, stamps, signatures, or supplementary details, preserving the underlying document intact.

IronPdf supports both processes, allowing the integration of PDFs as backgrounds or foregrounds with ease.

## Adding a Background to a PDF

To insert a background, utilize the `AddBackgroundPdf` method provided by IronPdf. This method can accept a PdfDocument instance. Below is an illustrative example where a background is added to a PDF. You can also directly use a file path to import and set the PDF as a background seamlessly.

### Example Code

```cs
// Import necessary namespaces
using IronPdf;

// Declare the namespace and class
namespace ironpdf.BackgroundForeground
{
    public class BackgroundExample
    {
        public void Execute()
        {
            // Create a PDF renderer instance
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Generate a PDF from basic HTML
            PdfDocument mainPdf = renderer.RenderHtmlAsPdf("<h1>Main HTML content</h1>");
            
            // Create a PDF to be used as a background
            PdfDocument backgroundPdf = renderer.RenderHtmlAsPdf("<body style='background-color: cyan;'></body>");
            
            // Apply the background
            mainPdf.AddBackgroundPdf(backgroundPdf);
            
            // Save the final PDF
            mainPdf.SaveAs("addBackground.pdf");
        }
    }
}
```

### Displayed Output

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/background-foreground/addBackground.pdf#view=fit" width="100%" height="400px">
</iframe>

---

## Example of Overlaying a Foreground

Similarly, for foregrounds, IronPdf's `AddForegroundOverlayPdf` method facilitates the overlaying process, which can also handle direct file paths.

### Example Code

```cs
// Import necessary namespaces
using IronPdf;

// Declare the namespace and class
namespace ironpdf.BackgroundForeground
{
    public class ForegroundExample
    {
        public void Execute()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            PdfDocument mainPdf = renderer.RenderHtmlAsPdf("<h1>Main HTML content</h1>");
            
            PdfDocument foregroundPdf = renderer.RenderHtmlAsPdf("<h1 style='transform: rotate(-45deg); opacity: 50%;'>Overlay Watermark</h1>");
            
            mainPdf.AddForegroundOverlayPdf(foregroundPdf);
            
            mainPdf.SaveAs("overlayForeground.pdf");
        }
    }
}
```

### Shown Output

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/background-foreground/overlayForeground.pdf#view=fit" width="100%" height="400px">
</iframe>

---

## Specifying Pages for Background or Foreground

You can select specific pages of a PDF on which to apply a background or foreground. For instance, to apply a distinct background color to the second page:

### Example Code

```cs
// Import necessary namespaces
using IronPdf;

// Declare the namespace and class
namespace ironpdf.BackgroundForeground
{
    public class PageSpecificBackground
    {
        public void Execute()
        {
            string backgroundHtml = @"
            <div style='background-color: cyan; height: 100%;'></div>
            <div style='page-break-after: always;'></div>
            <div style='background-color: lemonchiffon; height: 100%;'></div>";
            
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            PdfDocument mainPdf = renderer.RenderHtmlAsPdf("<h1>Main HTML content</h1>");
            
            PdfDocument backgroundPdf = renderer.RenderHtmlAsPdf(backgroundHtml);
            
            mainPdf.AddBackgroundPdf(backgroundPdf, 1);
            
            mainPdf.SaveAs("addBackgroundFromPage2.pdf");
        }
    }
}
```

### Displayed Output

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/background-foreground/addBackgroundFromPage2.pdf#view=fit" width="100%" height="400px">
</iframe>

---

## Applying Background or Foreground to Selected Pages

IronPdf provides methods to apply background or foreground settings to specific pages within a PDF, either individually or across a range of pages. Here’s how you can add a background to the first and third pages of a document:

### Example for Multiple Pages

```cs
using System.Collections.Generic;
using IronPdf;

namespace ironpdf.BackgroundForeground
{
    public class MultiplePageBackground
    {
        public void Execute()
        {
            string htmlContent = @"<p> This is 1st Page </p>
            <div style='page-break-after: always;'></div>
            <p> This is 2nd Page</p>
            <div style='page-break-after: always;'></div>
            <p> This is 3rd Page</p>";
            
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            PdfDocument mainPdf = renderer.RenderHtmlAsPdf(htmlContent);
            
            PdfDocument backgroundPdf = renderer.RenderHtmlAsPdf("<body style='background-color: cyan;'></body>");
            
            List<int> pages = new List<int>() { 0, 2 };
            
            mainPdf.AddBackgroundPdfToPageRange(pages, backgroundPdf);
            
            mainPdf.SaveAs("addBackgroundOnMultiplePage.pdf");
        }
    }
}
```

### Displayed Output

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/background-foreground/addBackgroundOnMultiplePage.pdf#view=fit" width="100%" height="500px">
</iframe>

These tools and methods from IronPdf enhance the flexibility and creativity of managing PDF documents, providing robust solutions for customizing and securing digital documentation.