# Rendering PDFs with Personalized Paper Sizes

***Based on <https://ironpdf.com/how-to/custom-paper-size/>***


A personalized paper size is a custom-defined size by the user, different from common standards such as A4 or letter size (8.5 x 11 inches). These sizes are particularly useful for distinct projects that require specialized formats like posters, banners, or unique documents.

IronPDF provides a comprehensive selection of paper sizes to cater to various requirements.

## Example: Implementing Custom Paper Sizes

Initially, set up an instance of **ChromePdfRenderer**. This object enables access to `RenderingOptions`, where you can specify a unique paper size for your PDF documents. IronPDF supports various methods to define the output paper size, each utilizing a different unit of measure:

- `SetCustomPaperSizeInCentimeters`: Sizes in **centimeters**.
- `SetCustomPaperSizeInInches`: Sizes in **inches**.
- `SetCustomPaperSizeInMillimeters`: Sizes in **millimeters**.
- `SetCustomPaperSizeInPixelsOrPoints`: Sizes in **pixels or points**.

### Sample Code

```cs
using IronPdf;
namespace ironpdf.CustomPaperSize
{
    public class Section1
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Set custom paper size using centimeters
            renderer.RenderingOptions.SetCustomPaperSizeInCentimeters(15, 15);
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Custom Paper Size</h1>");
            
            pdf.SaveAs("customPaperSize.pdf");
        }
    }
}
```

### Rendered PDF Example

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/custom-paper-size/customPaperSize.pdf#view=fit" width="100%" height="400px">
</iframe>

### Essential Properties

- **PaperSize**: Defines the output paper size using predefined dimensions like letter, A3, A4, etc.
- **ForcePaperSize**: Enforces the specific dimensions set in IronPdf.ChromePdfRenderOptions.PaperSize, overriding CSS rules that dictate paper size.

<hr>

## Altering Paper Dimensions Example

Modify the dimensions of pages within a new or existing PDF document via the `ExtendPage` method. This function adjustments the page dimensions by extending or reducing specified sides based on the values and units provided.

### Sample Code

```cs
using IronPdf.Editing;
using IronPdf;
namespace ironpdf.CustomPaperSize
{
    public class Section2
    {
        public void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("customPaperSize.pdf");
            
            // Extend the left side of the first page by 50 millimeters
            pdf.ExtendPage(0, 50, 0, 0, 0, MeasurementUnit.Millimeter);
            
            pdf.SaveAs("extendedLeftSide.pdf");
        }
    }
}
```

### Demonstration PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/custom-paper-size/extendedLeftSide.pdf#view=fit" width="100%" height="400px">
</iframe>