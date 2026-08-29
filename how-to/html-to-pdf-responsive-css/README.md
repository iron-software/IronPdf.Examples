# How to Apply CSS for HTML Content

> Full guide: [How to Apply CSS for HTML Content](https://ironpdf.com/how-to/html-to-pdf-responsive-css/)


The `screen` media type in CSS is generally used for content displayed on devices like computer screens. These style specifications focus on enhancing the visual appeal and interactivity of web content when viewed on screens. 

In a different vein, the `print` media type in CSS is tailored for print content. This styling ensures that web pages print optimally, modifying aspects such as fonts, margins, and concealing unnecessary elements to create a cleaner printout.

## Quick Start: Creating PDFs with Responsive HTML and CSS Using IronPDF

Easily transform your HTML with responsive CSS into pristine PDFs using IronPDF. Developers can produce perfectly rendered PDF documents that respect both screen and print styles with minimal coding. This swift guide explains utilizing IronPDF to convert HTML into high-quality PDFs effectively.

```cs
var chromeRenderer = new IronPdf.ChromePdfRenderer { RenderingOptions = { CssMediaType = IronPdf.Rendering.PdfCssMediaType.Print } };
chromeRenderer.RenderUrlAsPdf("https://example.com").SaveAs("responsive.pdf");
```

## Understanding CSS Media Types: Screen & Print (CSS3)

IronPDF facilitates PDF generation from HTML using C#, defaulting to render PDFs using screen stylesheets. This focus on screen CSS is practical since print stylesheets are less frequently crafted or detailed.

CSS3 supports specific styles to appear only in print form, whereas others are designed for on-screen viewing. IronPDF's flexible programming allows adaptation to either style.

Explore creating a customized print stylesheet for your HTML here: [Learn to craft and integrate the ideal print stylesheet.](https://www.jotform.com/blog/css-perfect-print-stylesheet-98272/).

Determining which CSS media type excels depends on specific needs and experimenting with each to find what best fits your project.

![Print Style Example](https://ironpdf.com/static-assets/pdf/how-to/pixel-perfect-html-to-pdf/Comparison%20of%20Screen%20and%20Print%201.webp)
![Screen Style Example](https://ironpdf.com/static-assets/pdf/how-to/pixel-perfect-html-to-pdf/Comparison%20of%20Screen%20and%20Print%202.webp)

<hr>

## Ensuring Table Headers Repeat in PDFs

For multi-page HTML tables, you should set the `CssMediaType` to `PdfCssMediaType.Print` to have the table headers repeat on each page. Conversely, using `PdfCssMediaType.Screen` will print the headers just once.

To ensure proper header recognition, encapsulate the header in a `<thead>` tag. The following example demonstrates converting the '<a href="https://ironpdf.com/static-assets/pdf/how-to/html-to-pdf-responsive-css/tableHeader.html" download='tableHeader.html'>tableHeader.html</a>' into a PDF to observe the header repetition.

```cs
using IronPdf;
using IronPdf.Rendering;

ChromePdfRenderer renderer = new ChromePdfRenderer 
{
    RenderingOptions = new RenderingOptions {
        SetCustomPaperSizeinPixelsOrPoints(600, 400),
        CssMediaType = PdfCssMediaType.Print
    }
};

// Render the HTML file to a PDF
PdfDocument pdfDocument = renderer.RenderHtmlFileAsPdf("tableHeader.html");
pdfDocument.SaveAs("tableHeader.pdf");
```

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/html-to-pdf-responsive-css/tableHeader.pdf" width="100%" height="400px"></iframe>