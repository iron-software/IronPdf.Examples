# How to Employ CSS for HTML Content

***Based on <https://ironpdf.com/how-to/html-to-pdf-responsive-css/>***


The CSS 'screen' media specification is primarily geared toward visual display on computer monitors and comparable devices. Employing the 'screen' media type enhances how web materials are visually engaged on screens, highlighting aesthetic design and user interaction.

In parallel, the CSS 'print' media specification is tailored for printed outputs. It dictates the presentation of web pages in print form, focusing on adapting the content for paper media. This might involve modifying font sizes, margins, and concealing or omitting elements that are irrelevant or unnecessary in print.

<h3>Introduction to IronPDF</h3>

-------------------------

## Exploring Screen & Print CSS Types (CSS3)

With IronPDF, you can produce PDFs from HTML using C#. It can seamlessly transform a screen-specific stylesheet into a PDF by default. Print stylesheets, in comparison, are often less explored, utilized, and crafted than screen stylesheets.

CSS3 facilitates the application of specific CSS styles solely in printed materials, while others are designed for viewing on web browsers. IronPDF supports customization to handle both contexts.

Develop and integrate a print stylesheet for your HTML: [Explore how to create and implement an optimal print stylesheet.](https://www.jotform.com/blog/css-perfect-print-stylesheet-98272/).

Deciding between CSS media types is not straightforward, as each targets distinct scenarios. It is advisable to experiment with each type through trial and error to discover which best suits your needs.

![Example of Print Media](https://ironpdf.com/static-assets/pdf/how-to/pixel-perfect-html-to-pdf/Comparison%20of%20Screen%20and%20Print%201.webp)
![Example of Screen Media](https://ironpdf.com/static-assets/pdf/how-to/pixel-perfect-html-to-pdf/Comparison%20of%20Screen%20and%20Print%202.webp)

<hr>

## Ensuring Repeated Table Headers

To manage HTML tables extending over multiple pages, adjust the **CssMediaType** property to **PdfCssMediaType.Print**. This configuration guarantees that the table’s header repeats on top of each subsequent page. Conversely, setting **PdfCssMediaType.Screen** results in the headers being printed only once.

Ensure the table header is wrapped in a `<thead>` tag for Chrome to correctly detect it. Here’s how to convert the ['tableHeader.html example of repeating table headers'](https://ironpdf.com/static-assets/pdf/how-to/html-to-pdf-responsive-css/tableHeader.html) into a PDF to observe the functionality.

```cs
using IronPdf;
using IronPdf.Rendering;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Adjust the document size
renderer.RenderingOptions.SetCustomPaperSizeinPixelsOrPoints(600, 400);

// Select the preferred CSS media type
renderer.RenderingOptions.CssMediaType = PdfCssMediaType.Print;

// Convert HTML to PDF
PdfDocument pdf = renderer.RenderHtmlFileAsPdf("tableHeader.html");

// Save the PDF file
pdf.SaveAs("tableHeader.pdf");
```

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/html-to-pdf-responsive-css/tableHeader.pdf" width="100%" height="400px">
</iframe>