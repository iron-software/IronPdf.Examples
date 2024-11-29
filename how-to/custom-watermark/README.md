# How to Apply Custom PDF Watermarks

***Based on <https://ironpdf.com/how-to/custom-watermark/>***


A custom watermark is a unique mark that overlays either as an image or text on a page within a PDF document. It is typically used for purposes such as branding with company logos or names, imposing security by labeling documents as 'Confidential', protecting copyright, and notifying the document's status. You can create watermarks that consist of either text or images, apply them universally or selectively across pages, and adjust their transparency to meet specific needs for personalization, protection, or documentation purposes.

IronPDF simplifies the process of adding custom watermarks to PDF documents. It provides a straightforward method where you can use an HTML string to create diverse and dynamic watermarks with full HTML and CSS capabilities.

## Apply Watermark Example

To apply a watermark to a PDF, whether it's a new or existing document, use the `ApplyWatermark` method. This method uses an HTML string that facilitates the incorporation of comprehensive HTML elements and CSS styles in the watermark. In the following example, we combine both text and image in our watermark. It's important to note that the watermark will be applied across all pages in the document; application to selected pages only is not supported.

### Code

```cs
using IronPdf;
namespace ironpdf.CustomWatermark
{
    public class Section1
    {
        public void Run()
        {
            string watermarkHtml = @"
            <img src='https://ironsoftware.com/cdn/assets/images/ironpdf-logo-text-dotnet.svg'>
            <h1>Iron Software</h1>";
            
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Watermark</h1>");
            
            // Applying the watermark to the PDF
            pdf.ApplyWatermark(watermarkHtml);
            
            pdf.SaveAs("watermark.pdf");
        }
    }
}
```

### Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/custom-watermark/watermark.pdf#zoom=45%" width="100%" height="400px">
</iframe>

This method is an efficient way to incorporate both image and text watermarks using various formats, including PNG, along with customizable fonts.

<hr>

## Watermark Opacity and Rotation

This section demonstrates how to add a watermark with defaulted opacity settings at 50%, allowing for customization per user needs. Additionally, an overload of the `ApplyWatermark` method provides options to apply rotation.

### Code

```cs
using IronPdf.Editing;
using IronPdf;
namespace ironpdf.CustomWatermark
{
    public class Section2
    {
        public void Run()
        {
            string watermarkHtml = @"
            <img style='width: 200px;' src='https://ironsoftware.com/cdn/assets/images/ironpdf-logo-text-dotnet.svg'>
            <h1>Iron Software</h1>";
            
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Watermark</h1>");
            
            // Applying the watermark with customized rotation and opacity
            pdf.ApplyWatermark(watermarkHtml, rotation: 45, opacity: 70);
            
            pdf.SaveAs("watermarkOpacity&Rotation.pdf");
        }
    }
}
```

### Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/custom-watermark/watermarkOpacity&Rotation.pdf#zoom=50%" width="100%" height="400px">
</iframe>

<hr>

## Watermark Location on PDF file

To strategically place a watermark, IronPDF utilizes a 3x3 grid that defines 9 potential locations across three horizontal (left, center, right) and three vertical (top, middle, bottom) positions. The image below serves as a visual guide for these location settings.

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/custom-watermark/watermark-location.webp" alt="Watermark location" class="img-responsive add-shadow">
    </div>
</div>

The position of a watermark can be specified using the `VerticalAlignment` and `HorizontalAlignment` enums from the `IronPdf.Editing` namespace.

### Code

```cs
using IronPdf.Editing;
using IronPdf;
namespace ironpdf.CustomWatermark
{
    public class Section3
    {
        public void Run()
        {
            string watermarkHtml = @"
            <img style='width: 200px;' src='https://ironsoftware.com/cdn/assets/images/ironpdf-logo-text-dotnet.svg'>
            <h1>Iron Software</h1>";
            
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Watermark</h1>");
            
            // Specifying watermark placement in the top-right corner
            pdf.ApplyWatermark(watermarkHtml, 50, VerticalAlignment.Top, HorizontalAlignment.Right);
            
            pdf.SaveAs("watermarkLocation.pdf");
        }
    }
}
```

### Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/custom-watermark/watermarkLocation.pdf" width="100%" height="400px">
</iframe>