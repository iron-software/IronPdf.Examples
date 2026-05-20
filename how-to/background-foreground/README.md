# Enhancing PDFs with Background and Foreground Layers

***Based on <https://ironpdf.com/how-to/background-foreground/>***


Incorporating a background layer into a PDF allows you to seamlessly introduce an image or another PDF document beneath the existing content. This technique is invaluable for crafting customized letterheads, embedding watermarks, or adding aesthetically pleasing elements to your document.

Additionally, overlaying the foreground enables the placement of text, images, or supplementary materials atop an existing PDF. This feature is particularly beneficial for appending annotations, stamps, signatures, or extra information, thus enhancing the PDF without modifying the original data.

Both adding a background and overlaying a foreground can be efficiently achieved using IronPdf, which provides the flexibility to employ another PDF as both background and foreground.

## Quickstart: Insert a PDF Background into Your Documents

Quickly enhance your PDF documents by appending a background using IronPDF. This brief tutorial illustrates how to implement a PDF as a background layer, which is ideal for letterheads or watermarks. Below is an easy-to-follow code snippet to facilitate a smooth and swift modification of your PDF documents.

```cs
// Title: Enhance Your PDFs with Ease
var pdf = new IronPdf.PdfDocument("input.pdf");
pdf.AddBackgroundPdf("background.pdf");
pdf.SaveAs("output.pdf");
```

## Example of Adding a Background

To set a background in your PDF, either for a new or existing document, use `AddBackgroundPdf`. The following code example illustrates this by applying the method to a `PdfDocument` instance. Alternatively, you can directly supply the file path to import and set the PDF as a background in a single operation.

### Code Example

```csharp
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Main HTML content</h1>");

// Generate the background
PdfDocument background = renderer.RenderHtmlAsPdf("<body style='background-color: cyan;'></body>");

// Implement the background
pdf.AddBackgroundPdf(background);

pdf.SaveAs("addBackground.pdf");
```

### Visual Output

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/background-foreground/addBackground.pdf#view=fit" width="100%" height="400px">
</iframe>

---

## Example of Overlaying a Foreground

Just as you add a background, you can also introduce a foreground overlay to your main PDF document using `AddForegroundOverlayPdf`.

### Code Demonstration

```csharp
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Main HTML content</h1>");

// Produce the foreground
PdfDocument foreground = renderer.RenderHtmlAsPdf("<h1 style='transform: rotate(-45deg); opacity: 50%;'>Overlay Watermark</h1>");

// Apply the foreground overlay
pdf.AddForegroundOverlayPdf(foreground);

pdf.SaveAs("overlayForeground.pdf");
```

### Visual Output

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/background-foreground/overlayForeground.pdf" width="100%" height="400px">
</iframe>

---

## Target Specific Pages for Background or Foreground

You have the option to pinpoint which pages should receive a background or foreground. The following example utilizes the `AddBackgroundPdf` method, similar to the earlier example, but selects only the second page of a two-page document.

### Code Snippet

```csharp
using IronPdf;

string backgroundHtml = @"
<div style = 'background-color: cyan; height: 100%;'></div>
<div style = 'page-break-after: always;'></div>
<div style = 'background-color: lemonchiffon; height: 100%;'></div>";

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Main HTML content</h1>");

// Construct background
PdfDocument background = renderer.RenderHtmlAsPdf(backgroundHtml);

// Designate the second page for the background
pdf.AddBackgroundPdf(background, 1);

pdf.SaveAs("addBackgroundFromPage2.pdf");
```

### Visual Output

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/background-foreground/addBackgroundFromPage2.pdf#view=fit" width="100%" height="400px">
</iframe>

---

## Tailoring Background and Foreground Applications

You can directly apply background or foreground layers to select pages within a document, adapting to specific formatting needs.

### Application to a Single Page

```csharp
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Main HTML content</h1>");

// Create the background
PdfDocument background = renderer.RenderHtmlAsPdf("<body style='background-color: cyan;'></body>");

// Implement background on the first page
pdf.AddBackgroundPdfToPage(0, background);

pdf.SaveAs("addBackgroundOnASinglePage.pdf");
```

### Application to Multiple Pages

```csharp
using IronPdf;
using System.Collections.Generic;

string html = @"<p> This is 1st Page </p>
<div style = 'page-break-after: always;'></div>
<p> This is 2nd Page</p>
<div style = 'page-break-after: always;'></div>
<p> This is 3rd Page</p>";

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf(html);

// Construct the background
PdfDocument background = renderer.RenderHtmlAsPdf("<body style='background-color: cyan;'></body>");

// List of specific pages
List<int> pages = new List<int>() { 0, 2 };

// Apply background to specified pages
pdf.AddBackgroundPdfToPageRange(pages, background);

pdf.SaveAs("addBackgroundOnMultiplePage.pdf");
```

### Output Visualization

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/background-foreground/addBackgroundOnMultiplePage.pdf#view=fit" width="100%" height="500px">
</iframe>