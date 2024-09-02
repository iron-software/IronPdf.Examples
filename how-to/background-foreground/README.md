# Enhancing PDFs with Backgrounds and Foreground Overlays

Incorporating a background into your PDF allows the addition of an image or another PDF document behind the existing content. This is ideal for crafting letterheads, watermarks, or embellishing your documents with decorative elements.

Foreground overlays enable the placement of text, images, or other content atop an existing PDF. This technique is widely used to append annotations, stamps, signatures, or extra information to a document without modifying the original content.

IronPdf supports both of these enhancements, offering functionalities to set PDFs as either backgrounds or foregrounds.

## Example: Adding a Background

To include a background in your existing or newly generated PDF document, you can employ the `AddBackgroundPdf` method. Below, we illustrate how to provide this method with a `PdfDocument` object. Alternatively, you can input a file path to automatically load and set the PDF as a background.

### Code Snippet

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Main HTML content</h1>");

// Generate a background PDF
PdfDocument background = renderer.RenderHtmlAsPdf("<body style='background-color: cyan;'></body>");

// Apply the background
pdf.AddBackgroundPdf(background);

pdf.SaveAs("addBackground.pdf");
```

### Rendered PDF Output

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/background-foreground/addBackground.pdf#view=fit" width="100%" height="400px">
</iframe>

<hr>

## Example: Overlaying a Foreground

Foregrounds are added similarly by specifying a PDF file path which imports the document to be overlaid on the main PDF. The following code uses the `AddForegroundOverlayPdf` method to achieve this overlay.

### Code Snippet

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Main HTML content</h1>");

// Generate foreground
PdfDocument foreground = renderer.RenderHtmlAsPdf("<h1 style='transform: rotate(-45deg); opacity: 50%;'>Overlay Watermark</h1>");

// Apply the foreground overlay
pdf.AddForegroundOverlayPdf(foreground);

pdf.SaveAs("overlayForeground.pdf");
```

### Rendered PDF Output

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/background-foreground/overlayForeground.pdf" width="100%" height="400px">
</iframe>

<hr>

## Selecting Specific Pages for Background or Foreground

You can choose specific pages of your PDF to apply backgrounds or foregrounds. For example, to assign a different color background to each page, follow the approach outlined below, notably using page two as the background.

### Code Snippet

```cs
using IronPdf;

string backgroundHtml = @"
<div style = 'background-color: cyan; height: 100%;'></div>
<div style = 'page-break-after: always;'></div>
<div style = 'background-color: lemonchiffon; height: 100%;'></div>";

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Main HTML content</h1>");

// Generate a two-page background
PdfDocument background = renderer.RenderHtmlAsPdf(backgroundHtml);

// Assign page 2 as the background
pdf.AddBackgroundPdf(background, 1);

pdf.SaveAs("addBackgroundFromPage2.pdf");
```

### Rendered PDF Output

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/background-foreground/addBackgroundFromPage2.pdf#view=fit" width="100%" height="400px">
</iframe>

<hr>

## Applying Background or Foreground to Specific Pages

It's also feasible to apply effects to designated single or multiple pages. Utilizing `AddBackgroundPdfToPage` and `AddForegroundOverlayPdfToPage` methods allows targeting specific pages.

### Applying to a Single Page

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Main HTML content</h1>");

// Generate a background
PdfDocument background = renderer.RenderHtmlAsPdf("<body style='background-color: cyan;'></body>");

// Apply background to the first page
pdf.AddBackgroundPdfToPage(0, background);

pdf.SaveAs("addBackgroundOnASinglePage.pdf");
```

### Applying to Multiple Pages

```cs
using IronPdf;
using System.Collections.Generic;

string html = @"<p>This is Page 1</p>
<div style = 'page-break-after: always;'></div>
<p>This is Page 2</p>
<div style = 'page-break-after: always;'></div>
<p>This is Page 3</p>";

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf(html);

// Generate a background
PdfDocument background = renderer.RenderHtmlAsPdf("<body style='background-color: cyan;'></body>");

// Specify pages to apply the background
List<int> pages = new List<int>() { 0, 2 };

// Apply background to specified pages
pdf.AddBackgroundPdfToPageRange(pages, background);

pdf.SaveAs("addBackgroundOnMultiplePages.pdf");
```

### Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/background-foreground/addBackgroundOnMultiplePages.pdf#view=fit" width="100%" height="500px">
</iframe>