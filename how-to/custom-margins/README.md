# How to Set Custom Margins

> Full guide: [How to Set Custom Margins](https://ironpdf.com/how-to/custom-margins/)


Creating documents with specific margin requirements is a common task, whether for academic formats like MLA and APA which specify 1-inch margins or for university dissertations that may require 1.5-inch margins.

## Quickstart: Implement Custom PDF Margins with IronPDF

IronPDF simplifies the process of setting custom margins when converting HTML to PDF. It can be easily configured as shown below:

```cs
var pdfRenderer = new IronPdf.ChromePdfRenderer { RenderingOptions = { MarginTop = 10, MarginBottom = 10, MarginLeft = 10, MarginRight = 10, UseMarginsOnHeaderAndFooter = true } };
pdfRenderer.RenderHtmlAsPdf("<h1>Hello with margins!</h1>").SaveAs("custom‑margins.pdf");
```

### Minimal Workflow (5 Steps):

1. Install the IronPDF C# library from [NuGet](https://nuget.org/packages/IronPdf/)
2. Create an instance of the `ChromePdfRenderer` class
3. Adjust the `RenderingOptions` to customize the margins
4. Apply custom margins to both headers and footers
5. Convert HTML to PDF and save it

## Set Custom Margin Example

To customize margins, start by creating an instance of `ChromePdfRenderer`. This allows you to access and set margins in the `RenderingOptions`, specified in millimeters for each side as demonstrated here:

```csharp
ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();

pdfRenderer.RenderingOptions.MarginTop = 40;
pdfRenderer.RenderingOptions.MarginLeft = 20;
pdfRenderer.RenderingOptions.MarginRight = 20;
pdfRenderer.RenderingOptions.MarginBottom = 40;
```

Note that these settings will augment any margins defined in the HTML's style tag. For instance, if the HTML has a 50 mm margin overall, and you add 30 mm through `RenderingOptions`, the total margin will be 80 mm:

```csharp
const string htmlWithStyledMargins = @"
<!DOCTYPE html>
<html>
    <head>
        <style>
            body {margin: 50mm;}
        </style>
    </head>
<body>
    <h1>Welcome to IronPDF!</h1>
</body>
</html>";

ChromePdfRenderer pdfRendererSetup = new ChromePdfRenderer();

pdfRendererSetup.RenderingOptions.MarginTop = 30;
pdfRendererSetup.RenderingOptions.MarginLeft = 30;
pdfRendererSetup.RenderingOptions.MarginRight = 30;
pdfRendererSetup.RenderingOptions.MarginBottom = 30;

PdfDocument finalizedPdf = pdfRendererSetup.RenderHtmlAsPdf(htmlWithStyledMargins);
finalizedPdf.SaveAs("PdfWithCustomMargins.pdf");
```

The following displays the resultant PDF:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/custom-margins/PdfWithCustomMargins.pdf" width="100%" height="500px"></iframe>

## Set Custom Margin in Header/Footer

Initially, `RenderingOptions` set margins do not impact headers and footers. To integrate the same custom margins across document headers and footers, utilize the `UseMarginsOnHeaderAndFooter` setting in `RenderingOptions`:

```csharp
renderer.RenderingOptions.UseMarginsOnHeaderAndFooter = UseMargins.All;
```

You can also specify targeted margins for headers and footers, as elucidated in our [detailed API Reference](https://ironpdf.com/object-reference/api/IronPdf.UseMargins.html). Here are some configurations for selective margin applications:

```csharp
// Apply only the left margin in headers and footers.
renderer.RenderingOptions.UseMarginsOnHeaderAndFooter = UseMargins.Left;

// Apply both left and right margins in headers and footers.
renderer.RenderingOptions.UseMarginsOnHeaderAndFooter = UseMargins.LeftAndRight;
```