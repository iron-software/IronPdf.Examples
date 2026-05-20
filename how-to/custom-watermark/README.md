# How to Add Watermarks to PDFs in C# Using IronPDF

***Based on <https://ironpdf.com/how-to/custom-watermark/>***


A custom watermark is a unique overlay of text or an image used primarily as a background on a PDF page. It offers several uses such as promoting branding through logos or names, enhancing document security with labels such as "Confidential", fortifying copyright protection, and denoting the status of a document. These watermarks may consist of text, images, or a combination of both and can be applied either selectively or across multiple pages, with adjustable opacity to suit different needs for customization, security, and contextualization of PDFs.

IronPDF simplifies this process with an integrated feature to add watermarks to PDF documents using just a single line of code. This feature utilizes an HTML string to create the watermark, leveraging the full spectrum of HTML and CSS capabilities for versatility.

## Quickstart: Effortlessly Applying Custom Watermarks

Adding a custom watermark to your PDF is straightforward with IronPDF. A single line of code can apply a distinctive watermark, custom-designed using HTML and CSS for adjustments in opacity, rotation, and placement based on a simple 3x3 grid system. This guide demonstrates how to rapidly enhance your PDF documents with custom watermarks, thereby ensuring both enhanced security and brand visibility.

```cs
// Adding Watermarks Instantly
new IronPdf.PdfDocument.FromFile("input.pdf")
    .ApplyWatermark("<h1 style='opacity:0.5;'>Confidential</h1>", IronPdf.PagePosition.TopCenter)
    .SaveAs("output.pdf");
```

## Minimal Workflow (5 Steps)

1. [Download the IronPDF Library for C#](https://www.nuget.org/packages/IronXL.Excel/)
2. Open an existing PDF document or create a new one.
3. Set up the HTML string for the watermark.
4. Apply the watermark using the `ApplyWatermark` method.
5. Adjust the watermark's rotation, opacity, and positioning as necessary.

## Example of Applying a Watermark

The `ApplyWatermark` method allows for the placement of a watermark on either a new or existing PDF. This method supports HTML strings for the watermark, enabling the utilization of all HTML and CSS offerings. Below, we demonstrate incorporating both an image and text into a single watermark, noting that this application will affect all pages of the document.

### Code

```csharp
using IronPdf;

string watermarkHtml = @"
<img src='https://ironpdf.com/img/products/ironpdf-logo-text-dotnet.svg'>
<h1>Iron Software</h1>";

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Watermark</h1>");

// Applying watermark
pdf.ApplyWatermark(watermarkHtml);

pdf.SaveAs("watermark.pdf");
```

### Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/custom-watermark/watermark.pdf#zoom=45%" width="100%" height="400px">
</iframe>

This method is a straightforward means to add both image and text watermarks, allowing for customization with various image formats such as PNG and different text styles.

<hr>

## Watermark Opacity and Rotation

By default, the watermark's opacity is set at 50%. This attribute can be altered to better meet specific needs. The `ApplyWatermark` method also allows for the adjustment of rotation.

### Code

```csharp
using IronPdf;
using IronPdf.Editing;

string watermarkHtml = @"
<img style='width: 200px;' src='https://ironpdf.com/img/products/ironpdf-logo-text-dotnet.svg'>
<h1>Iron Software</h1>";

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Watermark</h1>");

// Applying watermark with 45 degrees rotation and 70% opacity
pdf.ApplyWatermark(watermarkHtml, rotation: 45, opacity: 70);

pdf.SaveAs("watermarkOpacity&Rotation.pdf");
```

### Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/custom-watermark/watermarkOpacity&Rotation.pdf" zoom="50%" style="width: 100%; height: 400px;">
</iframe>

<hr>

## Watermark Placement on PDF

To establish watermark placement, employ a 3x3 grid system segmented into three horizontal columns and three vertical rows. This arrangement allows for nine distinct positional options per page. For a visual guide, please refer to the image below.

<div class="content-img-align-center">
    <div class="center-image-wrapper">
        <img src="https://ironpdf.com/static-assets/pdf/how-to/custom-watermark/watermark-location.webp" alt="Watermark location" class="img-responsive add-shadow">
    </div>
</div>

To set a watermark to a specifically desired location, utilize the **VerticalAlignment** and **HorizontalAlignment** enums available in the `IronPdf.Editing` namespace.

### Code

```csharp
using IronPdf;
using IronPdf.Editing;

string watermarkHtml = @"
<img style='width: 200px;' src='https://ironpdf.com/img/products/ironpdf-logo-text-dotnet.svg'>
<h1>Iron Software</h1>";

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Watermark</h1>");

// Placing watermark at the top-right of the document
pdf.ApplyWatermark(watermarkHtml, 50, VerticalAlignment.Top, HorizontalAlignment.Right);

pdf.SaveAs("watermarkLocation.pdf");
```

### Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/custom-watermark/watermarkLocation.pdf" width="100%" height="400px">
</iframe>

Explore further possibilities with our comprehensive tutorial here: [Edit PDFs](https://ironpdf.com/tutorials/csharp-edit-pdf-complete-tutorial/)