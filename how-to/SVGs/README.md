# Convert SVG to PDF in C#

***Based on <https://ironpdf.com/how-to/SVGs/>***


IronPDF delivers robust functionality for including SVG images into PDF files using its "HTML to PDF" feature.

It's essential to specify the **width** and/or **height** attribute of the **img** element when incorporating SVGs in your documents. If these attributes are not set, the SVG might render as an invisible element due to collapsing to a minimal size.

## Quickstart: Effortless SVG to PDF Conversion

Explore the process of converting SVG images into PDF format with IronPDF using C#. This example shows how to embed an SVG using the HTML img tag with predefined sizes which is vital for correct depiction in the PDF. Follow these straightforward steps for a flawless transition of your SVGs into PDF documents.

```cs
:title=Single-step SVG to PDF Conversion
new IronPdf.ChromePdfRenderer { RenderingOptions = { WaitFor = IronPdf.Rendering.WaitFor.RenderDelay(1000) } }
    .RenderHtmlAsPdf("<img src='https://example.com/logo.svg' style='width:100px;height:100px;'>")
    .SaveAs("svgToPdf.pdf");
```

## Render SVG to PDF Example

While many web browsers don't require SVGs to have a defined size, the rendering engine used by IronPDF does.

```csharp
using IronPdf;

string html = "<img src='https://ironsoftware.com/img/svgs/new-banner-svg.svg' style='width:100px;height:auto;'>";

ChromePdfRenderer renderer = new ChromePdfRenderer();
renderer.RenderingOptions.WaitFor.RenderDelay(1000);

PdfDocument pdf = renderer.RenderHtmlAsPdf(html);
pdf.SaveAs("svgToPdf.pdf");
```

### Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/SVGs/svgToPdf.pdf" width="100%" height="300px"></iframe>

Furthermore, specifying explicit width and height attributes directly on an SVG node is also a beneficial practice. For additional styling examples of SVGs, visit [CodePen SVG Styling](https://codepen.io/AmeliaBR/pen/MYbzaW).

Curious about more capabilities? Visit our tutorial page here: [Additional Features](https://ironpdf.com/tutorials/pdf-assets-and-performance-csharp/).