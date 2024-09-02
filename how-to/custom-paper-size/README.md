# Rendering PDFs with Custom Paper Sizes

A custom paper size is a user-defined specification that deviates from standard dimensions such as A4 or letter size (8.5 x 11 inches). These specifications are ideal for specialized formats like posters, banners, and other unique document types.

Explore the diverse paper size options provided by IronPDF, tailored to meet a variety of requirements!

## Custom Paper Size Implementation

Begin by creating an instance of the `ChromePdfRenderer` class. From this instance, you can adjust the `RenderingOptions` to define a custom paper size for your PDF document. IronPDF supports setting the paper size using different units of measure:

- `SetCustomPaperSizeInCentimeters`: Use centimeters for dimensions.
- `SetCustomPaperSizeInInches`: Use inches for dimensions.
- `SetCustomPaperSizeInMillimeters`: Use millimeters for dimensions.
- `SetCustomPaperSizeInPixelsOrPoints`: Use pixels or points for dimensions.

### Example Code

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Define custom paper size in centimeters
renderer.RenderingOptions.SetCustomPaperSizeInCentimeters(15, 15);

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Custom Paper Size</h1>");

pdf.SaveAs("customPaperSize.pdf");
```

### Visualize the Output

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/custom-paper-size/customPaperSize.pdf#view=fit" width="100%" height="400px">
</iframe>

### Additional Configuration Options

- **PaperSize**: Choose a predefined paper size for PDFs, such as A3, A4, or letter size.
- **ForcePaperSize**: Override CSS-defined sizes by resizing pages to match the dimensions specified in `IronPdf.ChromePdfRenderOptions.PaperSize`.

<hr>

## Adjusting Page Dimensions in a PDF

Alter the dimensions of pages within a new or existing PDF using the `ExtendPage` method. This method adjusts the dimensions of a specified page, allowing you to extend or reduce each side based on your needs, using the specified unit of measurement.

### Example Code

```cs
using IronPdf;
using IronPdf.Editing;

PdfDocument pdf = PdfDocument.FromFile("customPaperSize.pdf");

// Extend the left side of the first page
pdf.ExtendPage(0, 50, 0, 0, 0, MeasurementUnit.Millimeter);

pdf.SaveAs("extendedLeftSide.pdf");
```

### View Adjusted PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/custom-paper-size/extendedLeftSide.pdf#view=fit" width="100%" height="400px">
</iframe>