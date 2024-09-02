# How to Implement Custom PDF Watermarks

A custom watermark is essentially a distinct image or text overlay that can be added to a PDF page. It is used for various functions like branding with company logos or names, enhancing security with tags such as 'Confidential', protecting copyright, and indicating a document's status. These watermarks can be composed of text or images, applied either selectively or across all pages, and their transparency can be regulated to ensure flexibility in personalizing, securing, and marking documents.

IronPdf simplifies the process with a straightforward command to insert watermarks into PDF documents. This feature leverages a HTML string to forge the watermark, utilizing the full spectrum of HTML and CSS styling capabilities.

## Example of Applying a Watermark

To insert a watermark into your PDF, whether it's a new or existing document, use the `ApplyWatermark` method. This method employs a HTML string as the watermark content offering comprehensive HTML capabilities, including CSS styling. In our example, both an image and text are used to create the watermark. Note that the watermark will affect all pages in the document; it isn't currently possible to apply it to select pages only.

### Implementation

```cs
using IronPdf;

string watermarkHtml = @"
<img src='https://ironsoftware.com/img/products/iron-pdf-logo-text-dotnet.svg'>
<h1>Iron Software</h1>";

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Watermark</h1>");

// Adding the watermark
pdf.ApplyWatermark(watermarkHtml);

pdf.SaveAs("custom-watermark.pdf");
```

### Resulting PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/custom-watermark/watermark.pdf#zoom=45%" width="100%" height="400px">
</iframe>

This method provides an easy way to integrate watermarks, supporting various image formats such as PNG, and text watermarks featuring custom fonts.

<hr>

## Adjusting Watermark Opacity and Rotation

Implement watermarks with a default opacity setting of 50%. You can adapt this setting to meet specific visibility needs. Additionally, you can set rotation for the watermark by using an overloaded version of the `ApplyWatermark` method, which also accepts rotation parameters.

### Implementation

```cs
using IronPdf;
using IronPdf.Editing;

string watermarkHtml = @"
<img style='width: 200px;' src='https://ironsoftware.com/img/products/iron-pdf-logo-text-dotnet.svg'>
<h1>Iron Software</h1>";

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Watermark</h1>");

// Setting the watermark with a 45-degree rotation and 70% opacity
pdf.ApplyWatermark(watermarkHtml, rotation: 45, opacity: 70);

pdf.SaveAs("custom-watermark-opacity-rotation.pdf");
```

### Resultant PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/custom-watermark/watermarkOpacity&Rotation.pdf#zoom=50%" width="100%" height="400px">
</iframe>

<hr>

## Setting Watermark Location in PDF Document

To define the watermark's position, we leverage a grid system split into three columns (left, center, right) and three rows (top, middle, bottom) across each page, enabling up to nine unique watermark placements.

![Watermark Location](https://ironpdf.com/static-assets/pdf/how-to/custom-watermark/watermark-location.webp "Watermark Positioning Guide")

Using the `VerticalAlignment` and `HorizontalAlignment` enums from the `IronPdf.Editing` namespace, you can position a watermark at a specified location.

### Implementation

```cs
using IronPdf;
using IronPdf.Editing;

string watermarkHtml = @"
<img style='width: 200px;' src='https://ironsoftware.com/img/products/iron-pdf-logo-text-dotnet.svg'>
<h1>Iron Software</h1>";

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Watermark</h1>");

// Positioning the watermark at the top-right corner of the document
pdf.ApplyWatermark(watermarkHtml, 50, VerticalAlignment.Top, HorizontalAlignment.Right);

pdf.SaveAs("specific-watermark-location.pdf");
```

### Displayed PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/custom-watermark/watermarkLocation.pdf" width="100%" height="400px">
</iframe>