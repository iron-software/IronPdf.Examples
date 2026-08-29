# How to Render PDFs with Custom Paper Size

> Full guide: [How to Render PDFs with Custom Paper Size](https://ironpdf.com/how-to/custom-paper-size/)


Custom paper size refers to any paper size that is personalized by the user and deviates from common standards like A4 or Letter size (8.5 x 11 inches). Such sizes are frequently used for printing unique projects that demand distinctive layouts, such as banners, posters, or specialized documents.

Explore IronPDF's expansive selection of paper sizes that cater to a variety of needs!

## Quickstart: Define Custom Paper Sizes in IronPDF

In this brief guide, you'll learn how to configure custom paper sizes with IronPDF with only a few lines of code. IronPDF enables you to customize PDF dimensions to your exact width and height preferences in any unit. This capability is particularly useful for producing documents that require specific design considerations like posters or banners. Start by installing the IronPDF library via NuGet and follow the steps below to set up your desired paper size with ease.

```csharp
// Example: Rendering a PDF with a custom paper size
var pdfRenderer = new IronPdf.ChromePdfRenderer();
pdfRenderer.RenderingOptions.PaperSize = IronPdf.Rendering.PdfPaperSize.Custom;
pdfRenderer.RenderingOptions.SetCustomPaperSizeInInches(5, 7); // 5 inches by 7 inches
var pdfDoc = pdfRenderer.RenderHtmlAsPdf("<h1>Custom size</h1>");
pdfDoc.SaveAs("custom‑size.pdf");
```

## Use Standard Paper Size Example

Begin by creating an instance of `ChromePdfRenderer`. Through the `RenderingOptions` property of this instance, adjust the `PaperSize`. Choose from one of the numerous predefined sizes provided by the `PdfPaperSize` enum to specify your preferred paper size. Over 100 standard sizes are available for your selection.

### Code

Here's how you set a standard paper size:

```csharp
using IronPdf;
using IronPdf.Rendering;

ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();

// Applying standard paper size (A4)
pdfRenderer.RenderingOptions.PaperSize = PdfPaperSize.A4;

PdfDocument document = pdfRenderer.RenderHtmlAsPdf("<h1>Standard Paper Size</h1>");
document.SaveAs("standardPaperSize.pdf");
```

### Related Properties

- `PaperSize`: Assign a predefined size for PDF pages.
- `ForcePaperSize`: Ensure the page sizes strictly match the specified `PaperSize`, altering the page dimensions after the PDF is generated from HTML to comply even when CSS specifies different dimensions.

### Get Standard Paper Sizes in Various Units

Find out the dimensions of standard paper sizes with the `ToMillimeters` method, which provides a tuple of width and height as `Length` objects. `Length` is a flexible class allowing conversion into diverse units such as millimeters, centimeters, inches, pixels, and points.

```csharp
using IronPdf.Rendering;

double A4WidthInPixels = PdfPaperSize.A4.ToMillimeters().width.ToPixels();
double A4HeightInCentimeters = PdfPaperSize.A4.ToMillimeters().height.ToCentimeters();
```

## Use Custom Paper Size Example

Start by creating a `ChromePdfRenderer` instance. With the `RenderingOptions`, set up a custom paper size for the PDF document. Use any of these four methods based on your measurement preferences:

- `SetCustomPaperSizeInCentimeters` for centimeter measurements
- `SetCustomPaperSizeInInches` for inch measurements
- `SetCustomPaperSizeInMillimeters` for millimeter measurements
- `SetCustomPaperSizeInPixelsOrPoints` for pixels or points

### Code

Example for setting a custom paper size in centimeters:

```csharp
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Configuring custom paper size in centimeters
renderer.RenderingOptions.SetCustomPaperSizeInCentimeters(15, 15);

PdfDocument customPdf = renderer.RenderHtmlAsPdf("<h1>Custom Paper Size</h1>");
customPdf.SaveAs("customPaperSize.pdf");
```

### Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/custom-paper-size/customPaperSize.pdf#view=fit" width="100%" height="400px"></iframe>

## Modify Paper Dimension Example

Adjust page sizes in either new or existing PDF documents using the `ExtendPage` method. This method permits modifications to any of the four borders of a page and supports both positive (to extend) and negative (to reduce) adjustments.

### Code

Here is how to alter paper dimensions:

```csharp
using IronPdf;
using IronPdf.Editing;

PdfDocument pdf = PdfDocument.FromFile("customPaperSize.pdf");

// Increase the left side
pdf.ExtendPage(0, 50, 0, 0, 0, MeasurementUnit.Millimeters);

pdf.SaveAs("extendedLeftSide.pdf");
```

### Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/custom-paper-size/extendedLeftSide.pdf#view=fit" width="100%" height="400px"></iframe>

Explore more capabilities by visiting our tutorial page: [Create PDFs](https://ironpdf.com/tutorials/csharp-create-pdf-complete-tutorial/)