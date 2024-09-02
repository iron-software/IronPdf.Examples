# Convert SVG to PDF in C&#35;

IronPDF effortlessly supports the conversion of SVG graphics into PDF documents using its "html to pdf" conversion capabilities.

It's critical to specify the **width** and/or **height** style attributes for the **img** element when incorporating an SVG. If these aren't set, the SVG might not be visible in the final PDF due to collapsing to a zero size.

## Render SVG to PDF Example

While many web browsers handle SVGs without explicit dimensions gracefully, IronPDF's rendering engine requires precise specifications.

```cs
using IronPdf;

// Define the HTML content with an SVG image
string htmlContent = "<img src='https://ironsoftware.com/img/svgs/new-banner-svg.svg' style='width:100px;'>";

// Initialize the PDF renderer
var pdfRenderer = new ChromePdfRenderer();
pdfRenderer.RenderingOptions.WaitFor.RenderDelay(1000); // Set render delay

// Convert HTML content to a PDF document
PdfDocument document = pdfRenderer.RenderHtmlAsPdf(htmlContent);
document.SaveAs("svgToPdf.pdf"); // Save the PDF file
```

### Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/SVGs/svgToPdf.pdf" width="100%" height="300px"></iframe>

Furthermore, an SVG node can have width and height attributes explicitly defined. For additional resources on styling SVGs, check out these excellent examples on CodePen: [SVG Styling Examples](https://codepen.io/AmeliaBR/pen/MYbzaW).