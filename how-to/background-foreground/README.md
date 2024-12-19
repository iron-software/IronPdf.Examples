# How to Add Background and Overlay Foreground on PDFs

***Based on <https://ironpdf.com/how-to/background-foreground/>***


Inserting a background into your PDF can involve adding a new layer of an image or another PDF document behind the original content of your PDF. This technique is particularly helpful for designing letterheads, creating watermarks, or integrating artistic elements into your documents.

On the other hand, overlaying foreground content enables you to superimpose text, images, or other materials directly over the content of an existing PDF. This method is widely utilized for introducing annotations, stamps, signatures, or extra details atop a PDF while preserving the integrity of the underlying original.

Both background and foreground additions can be efficiently handled using IronPdf, offering functionalities to handle both elements using PDF layers.

<h3>Getting Started with IronPDF</h3>

----------------------------------

## Add Background Example

The `AddBackgroundPdf` method makes it possible to integrate a background into both newly created or existing PDF files. Below is a sample code snippet that uses a `PdfDocument` object with this method. Alternatively, you can directly use a file path to import and set a background with a singular call.

### Code

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Main HTML content</h1>");

// Generating the background
PdfDocument background = renderer.RenderHtmlAsPdf("<body style='background-color: cyan;'></body>");

// Background application
pdf.AddBackgroundPdf(background);

pdf.SaveAs("addBackground.pdf");
```

### Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/background-foreground/addBackground.pdf#view=fit" width="100%" height="400px">
</iframe>

<hr>

## Overlay Foreground Example

Just as with backgrounds, the `AddForegroundOverlayPdf` method is used for overlaying foregrounds; simply indicate the PDF file path to import the file and set it as a foreground over the primary PDF.

### Code

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Main HTML content</h1>");

// Foreground generation
PdfDocument foreground = renderer.RenderHtmlAsPdf("<h1 style='transform: rotate(-45deg); opacity: 50%;'>Overlay Watermark</h1>");

// Foreground overlay
pdf.AddForegroundOverlayPdf(foreground);

pdf.SaveAs("overlayForeground.pdf");
```

### Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/background-foreground/overlayForeground.pdf" width="100%" height="400px">
</iframe>

<hr>

## Select Pages for Background or Foreground

You can designate specific pages of a PDF to serve as backgrounds or foregrounds. Here's an example that applies a background, using a `PdfDocument` that adds the second page as a background.

All page indexes follow zero-based indexing.

### Code

```cs
using IronPdf;

string backgroundHtml = @"
<div style = 'background-color: cyan; height: 100%;'></div>
<div style = 'page-break-after: always;'></div>
<div style = 'background-color: lemonchiffon; height: 100%;'></div>";

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Main HTML content</h1>");

// Background rendering
PdfDocument background = renderer.RenderHtmlAsPdf(backgroundHtml);

// Applying second page as background
pdf.AddBackgroundPdf(background, 1);

pdf.SaveAs("addBackgroundFromPage2.pdf");
```

### Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/background-foreground/addBackgroundFromPage2.pdf#view=fit" width="100%" height="400px">
</iframe>

<hr>

## Apply Background or Foreground on Specified Pages

It's feasible to apply the background or foreground to specifically chosen pages using different methods. Use `AddBackgroundPdfToPage` for a single page and `AddForegroundOverlayPdfToPage` for overlaying foregrounds on one precise page respectively.

### Apply on a Single Page

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Main HTML content</h1>");

// Rendering the background
PdfDocument background = renderer.RenderHtmlAsPdf("<body style='background-color: cyan;'></body>");

// Adding background to the first page
pdf.AddBackgroundPdfToPage(0, background);

pdf.SaveAs("addBackgroundOnASinglePage.pdf");
```

For multiple pages, use the `AddBackgroundPdfToPageRange` and `AddForegroundOverlayPdfToPageRange` methods.

### Apply on Multiple Pages

```cs
using IronPdf;
using System.Collections.Generic;

string html = @"<p> This is 1st Page </p>
<div style = 'page-break-after: always;'></div>
<p> This is 2nd Page</p>
<div style = 'page-break-after: always;'></div>
<p> This is 3rd Page</p>";

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf(html);

// Background rendering
PdfDocument background = renderer.RenderHtmlAsPdf("<body style='background-color: cyan;'></body>");

// List of pages for background application
List<int> pages = new List<int>() { 0, 2 };

// Adding background to pages 1 & 3
pdf.AddBackgroundPdfToPageRange(pages, background);

pdf.SaveAs("addBackgroundOnMultiplePage.pdf");
```

### Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/background-foreground/addBackgroundOnMultiplePage.pdf#view=fit" width="100%" height="500px">
</iframe>