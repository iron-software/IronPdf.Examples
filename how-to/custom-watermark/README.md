# How to Insert Custom PDF Watermarks

***Based on <https://ironpdf.com/how-to/custom-watermark/>***


A custom watermark refers to a unique mark, either as a text or an image, added to the background of a PDF's page. This can be utilized for a myriad of purposes such as branding through the incorporation of logos or names, boosting security with 'Confidential' labels, reinforcing copyright claims or indicating the document's stage of process. You can craft these watermarks using either text or images, apply them across all pages or just few, and even adjust their transparency, ensuring flexibility in how documents are personalized, protected, and marked.

IronPDF simplifies adding watermarks to PDFs. It does this via a straightforward method that accepts HTML string for creating watermarks, which allows the full spectrum of HTML and CSS styling capabilities.

<h3>Start Using IronPDF</h3>

--------------------------------------

## Example: Applying a Watermark

The `ApplyWatermark` function facilitates placing a watermark on a newly created PDF document or on an existing one, embracing the broad functionalities of HTML, including CSS for styling. The example below demonstrates setting a watermark that consists of both image and text. It’s important to note that this watermark will be repeated on every page of the document as the feature doesn't support page-specific application.

### Code

```cs
using IronPdf;

string watermarkHtml = @"
<img src='https://ironsoftware.com/img/products/ironpdf-logo-text-dotnet.svg'>
<h1>Iron Software</h1>";

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Watermark</h1>");

// Implementing the watermark
pdf.ApplyWatermark(watermarkHtml);

pdf.SaveAs("watermark.pdf");
```

### Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/custom-watermark/watermark.pdf#zoom=45%" width="100%" height="400px">
</iframe>

This method is quite effective in adding watermarks using various image formats, such as PNG, and custom font text.

<hr>

## Manipulating Watermark Opacity and Angle

To adjust a watermark's visibility and orientation, you can set its opacity and rotation angle. IronPDF enables these customizations directly in the `ApplyWatermark` method, allowing adjustments for opacity and degrees of rotation.

### Code

```cs
using IronPdf;
using IronPdf.Editing;

string watermarkHtml = @"
<img style='width: 200px;' src='https://ironsoftware.com/img/products/ironpdf-logo-text-dotnet.svg'>
<h1>Iron Software</h1>";

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Watermark</h1>");

// Adding watermark with configured opacity and rotation
pdf.ApplyWatermark(watermarkHtml, rotation: 45, opacity: 70);

pdf.SaveAs("watermarkOpacity&Rotation.pdf");
```

### Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/custom-watermark/watermarkOpacity&Rotation.pdf#zoom=50%" width="100%" height="400px">
</iframe>

<hr>

## Setting Watermark Position in a PDF

Watermark positioning can be fine-tuned using a grid approach, divided into three columns and three rows, allowing placement in nine distinct positions within the page. The example below illustrates this configuration.

<div class="content-img-align-center">
    <div class="center-image-wrapper">
        <img src="https://ironpdf.com/static-assets/pdf/how-to/custom-watermark/watermark-location.webp" alt="Watermark location" class="img-responsive add-shadow">
    </div>
</div>

To adjust the watermark's location, make use of the **VerticalAlignment** and **HorizontalAlignment** enums available in IronPdf.Editing.

### Code

```cs
using IronPdf;
using IronPdf.Editing;

string watermarkHtml = @"
<img style='width: 200px;' src='https://ironsoftware.com/img/products/ironpdf-logo-text-dotnet.svg'>
<h1>Iron Software</h1>";

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Watermark</h1>");

// Positioning watermark at the top-right
pdf.ApplyWatermark(watermarkHtml, 50, VerticalAlignment.Top, HorizontalAlignment.Right);

pdf.SaveAs("watermarkLocation.pdf");
```

### Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/custom-watermark/watermarkLocation.pdf" width="100%" height="400px">
</iframe>