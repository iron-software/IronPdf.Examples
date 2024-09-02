# Utilizing Virtual Viewport and Zoom in HTML-to-PDF Conversion

When transforming HTML to PDF, the virtual viewport is essential as it represents the mock screen size used by the browser to render the web page. This setting influences the layout capture in your final PDF document.

Zoom functionality in HTML-to-PDF translation is critical for adjusting web page content scaling within the PDF. Modifying the zoom setting allows you to tailor the content size in your generated PDF to meet your layout and design requirements.

## Rendering Modes for Paper Fit

Explore the **PaperFit** property in `RenderingOptions` to select a preset rendering strategy suitable for a range of needs. Below are various PaperFit modes exemplified using the renowned Wikipedia main page.

## Chrome Default Rendering

This rendering mode replicates the layout observed in the print preview of Google Chrome. It adjusts the rendering options to simulate how a web page looks when printed from the Chrome browser, managing the virtual screen size based on the paper width specified. To enable this mode, use the `UseChromeDefaultRendering` method.

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Activate Chrome default rendering
renderer.RenderingOptions.PaperFit.UseChromeDefaultRendering();

// Convert URL to PDF
PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");

pdf.SaveAs("chromeDefault.pdf");
```

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/viewport-zoom/chromeDefault.pdf#view=fit" width="100%" height="600px">
</iframe>

## Responsive CSS Rendering

This mode allows setting a specific virtual viewport width for responsive CSS by utilizing the `UseResponsiveCssRendering` method, with a default of 1280 pixels. It scales web content to match the width of the chosen paper size.

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Set up Responsive CSS rendering
renderer.RenderingOptions.PaperFit.UseResponsiveCssRendering(1280);

// Convert URL to PDF
PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");

pdf.SaveAs("responsiveCss.pdf");
```

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/viewport-zoom/responsiveCss.pdf#view=fit" width="100%" height="600px">
</iframe>

## Scaled Rendering

The `UseScaledRendering` method follows the layout from the 'Chrome Print Preview' and allows adjusting the zoom level additionally. This setting is ideal for scaling content dynamically based on the predefined zoom percentage.

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Implement Scaled rendering
renderer.RenderingOptions.PaperFit.UseScaledRendering(180);

// Convert URL to PDF
PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");

pdf.SaveAs("scaled.pdf");
```

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/viewport-zoom/scaled.pdf#view=fit" width="100%" height="600px">
</iframe>

## Fit to Page Rendering

'Fit to page' rendering automatically scales content to match the paper size. It configures the minimum content width to be scaled appropriately, respecting the pixel-based layout guidelines from CSS3.

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Activate Fit to page rendering
renderer.RenderingOptions.PaperFit.UseFitToPageRendering();

// Convert URL to PDF
PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");

pdf.SaveAs("fitToPage.pdf");
```

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/viewport-zoom/fitToPage.pdf#view=fit" width="100%" height="600px">
</iframe>

## Continuous Feed Rendering

This mode produces a single-page PDF, custom-tailoring the entire content's dimensions to span one page, ideal for items like receipts. Users can modify both the page width and margin.

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Enable Continuous feed rendering
renderer.RenderingOptions.PaperFit.UseContinuousFeedRendering();

// Convert URL to PDF
PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");

pdf.SaveAs("continuousFeed.pdf");
```

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/viewport-zoom/continuousFeed.pdf#view=fit" width="100%" height="600px">
</iframe>