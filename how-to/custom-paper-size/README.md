# Rendering PDFs with Customized Paper Sizes

***Based on <https://ironpdf.com/how-to/custom-paper-size/>***


Custom paper sizes refer to dimensions that are specifically tailored by the user, rather than adhering to traditional standards such as A4 or the US letter size (8.5 x 11 inches). Such sizes are particularly useful for unique document layouts required for niche applications like banners, posters, and other specialized forms.

Explore IronPDF's broad selection of paper sizes tailored to accommodate any unique requirement you may have!

## Implementing a Custom Paper Size

To start, instantiate the `ChromePdfRenderer` class which allows access to various rendering options, including setting a custom paper size for the PDFs you generate. There are four methods available for setting the desired paper size, each accommodating different units of measure:

- `SetCustomPaperSizeInCentimeters`: Sets the size in **centimeters**.
- `SetCustomPaperSizeInInches`: Sets the size in **inches**.
- `SetCustomPaperSizeInMillimeters`: Sets the size in **millimeters**.
- `SetCustomPaperSizeInPixelsOrPoints`: Sets the size in **pixels or points**.

### Example Code

```cs
using IronPdf;

// Create a new PDF renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Define the custom paper size in centimeters
renderer.RenderingOptions.SetCustomPaperSizeinCentimeters(15, 15);

// Render HTML to PDF with a custom paper size
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Custom Paper Size</h1>");

// Save the PDF
pdf.SaveAs("customPaperSize.pdf");
```

### Display Resulting PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/custom-paper-size/customPaperSize.pdf#view=fit" width="100%" height="400px">
</iframe>

### Associated Properties

- **PaperSize**: This property allows setting a predefined paper size such as A3, A4, etc., for your PDF pages.
- **ForcePaperSize**: This capability ensures that the pages conform exactly to the specified size by adjusting the dimensions after the PDF is generated from HTML, ignoring any contrary CSS rules.

<hr>

## Adjusting Page Dimensions in a PDF

To alter the dimensions of a page within an existing PDF or a newly created PDF document, you can use the `ExtendPage` method. This method provides the flexibility to adjust the four margins of a targeted page and specify the measurement units. The adjustments can either increase (positive values) or decrease (negative values) the respective margins.

### Example Code

```cs
using IronPdf;
using IronPdf.Editing;

// Load an existing PDF
PdfDocument pdf = PdfDocument.FromFile("customPaperSize.pdf");

// Modify the left margin of the first page
pdf.ExtendPage(0, 50, 0, 0, 0, MeasurementUnit.Millimeter);

// Save the modified PDF
pdf.SaveAs("extendedLeftSide.pdf");
```

### Display Updated PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/custom-paper-size/extendedLeftSide.pdf#view=fit" width="100%" height="400px">
</iframe>