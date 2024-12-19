# Transform SVG to PDF Using C#

***Based on <https://ironpdf.com/how-to/SVGs/>***


IronPDF offers robust capabilities for converting SVG graphics to PDF documents leveraging the "HTML to PDF" conversion approach.

It's crucial to specify the **width** and/or **height** attributes in the **img** tag when embedding an SVG. Without these attributes, the SVG could shrink to a zero size and fail to display in the generated PDF.

<h3>Getting Started with IronPDF</h3>

-----

## Example: Converting SVG to PDF

While many web browsers can handle SVGs without explicit dimensions, our rendering engine requires them to prevent issues.

```cs
using IronPdf;

string htmlCode = "<img src='https://ironsoftware.com/img/svgs/new-banner-svg.svg' style='width:100px;'>";

ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();
pdfRenderer.RenderingOptions.WaitFor.RenderDelay(1000); // Wait for 1000 milliseconds for rendering

PdfDocument outputPdf = pdfRenderer.RenderHtmlAsPdf(htmlCode);
outputPdf.SaveAs("convertedSvgToPdf.pdf");
```

### Displaying the Generated PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/SVGs/svgToPdf.pdf" width="100%" height="300px">
</iframe>

It's also possible to set explicit width and height attributes directly on the SVG element. For more detailed examples on SVG styling, refer to [these illustrative examples on CodePen](https://codepen.io/AmeliaBR/pen/MYbzaW).