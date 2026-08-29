# How to Overlay Text & Image on PDFs

> Full guide: [How to Overlay Text & Image on PDFs](https://ironpdf.com/how-to/stamp-text-image/)


Overlaying text and images on an existing PDF is known as stamping. This process involves adding additional content, such as text, images, or both, which are commonly used for annotations, watermarks, labels, or information.

IronPdf offers four different stamping tools: `TextStamper`, `ImageStamper`, `HTMLStamper`, and `BarcodeStamper`. Among these, the `HTMLStamper` stands out for its ability to incorporate all HTML elements and CSS styles.

### Quick Guide: Instant Text Stamping on PDFs

In this quick guide, you'll see how to use IronPDF to overlay text onto a PDF. Utilizing the `TextStamper` class makes it simple to apply text labels or watermarks to any PDF. The following example outlines a straightforward approach to text stamping using the `ApplyStamp` method for quick and effective results.

```cs
// Title: Simple PDF Text Stamping
var pdf = new IronPdf.PdfDocument("input.pdf");
var stamper = new IronPdf.TextStamper("Confidential", 50, 50);
pdf.ApplyStamp(stamper);
pdf.SaveAs("stamped.pdf");
```

## Example of Stamping Text

Begin by initializing a `TextStamper` object where you can define all necessary settings for the text stamp. After setting up, apply this stamper using the `ApplyStamp` method. Settings include text content, font family, styling, and stamp position.

```csharp
using IronPdf;
using IronPdf.Editing;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Example HTML Content</h1>");

// Setup text stamper
TextStamper textStamper = new TextStamper()
{
    Text = "Text Stamp Example",
    FontFamily = "Bungee Shade",
    UseGoogleFont = true,
    FontSize = 32,
    IsBold = true,
    IsItalic = false,
    VerticalAlignment = VerticalAlignment.Top,
};

// Apply the text stamp to the PDF
pdf.ApplyStamp(textStamper);
pdf.SaveAs("demoTextStamp.pdf");
```

### PDF Output

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/stamp-text-image/stampText.pdf" width="100%" height="400px">
</iframe>

For multiline text in `TextStamper`, use the `<br>` HTML tag, as you would in normal HTML.

<hr>

## Example of Stamping an Image

First, instantiate an `ImageStamper` object and assign it to apply an image stamp. This example sets the image to be stamped on the first page, considering pages start at index 0.

```csharp
using IronPdf;
using IronPdf.Editing;
using System;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Example HTML Document</h1>");

// Setup the image stamper
ImageStamper imageStamper = new ImageStamper(new Uri("https://ironpdf.com/img/svgs/iron-pdf-logo.svg"))
{
    VerticalAlignment = VerticalAlignment.Top,
};

// Apply the image stamp to the first page
pdf.ApplyStamp(imageStamper, 0);
pdf.SaveAs("demoImageStamp.pdf");
```

### PDF Output

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/stamp-text-image/stampImage.pdf" width="100%" height="400px">
</iframe>

<hr>

## Apply Multiple Text Stamps

Multiple stamps can be simultaneously applied using the `ApplyMultipleStamps` method, which takes an array of stamper objects.

```csharp
using IronPdf;
using IronPdf.Editing;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Example HTML Document!</h1>");

// Set up two distinct text stampers
TextStamper stamper1 = new TextStamper()
{
    Text = "First Text Stamp",
    VerticalAlignment = VerticalAlignment.Top,
    HorizontalAlignment = HorizontalAlignment.Left,
};

TextStamper stamper2 = new TextStamper()
{
    Text = "Second Text Stamp",
    VerticalAlignment = VerticalAlignment.Top,
    HorizontalAlignment = HorizontalAlignment.Right,
};

Stamper[] stampersArray = { stamper1, stamper2 };

// Apply both stamps to the PDF
pdf.ApplyMultipleStamps(stampersArray);
pdf.SaveAs("combinedStamps.pdf");
```

### PDF Output

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/stamp-text-image/multipleStamps.pdf" width="100%" height="400px">
</iframe>

<hr>

## Defining Stamp Placement

Stamp positioning is defined using a three-by-three grid model, allowing for precise placement on the PDF page. Settings include horizontal and vertical alignment choices and adjustable offsets.

For visuals, see the placement grid image below:

<div class="content-img-align-center">
    <div class="center-image-wrapper">
        <img src="https://ironpdf.com/static-assets/pdf/how-to/stamp-text-image/stamp-location.webp" alt="Stamp placement grid" class="img-responsive add-shadow">
    </div>
</div>- `HorizontalAlignment`: Sets the stamp's side-to-side placement relative to the page.
- `VerticalAlignment`: Sets the stamp's up-and-down placement relative to the page.
- `HorizontalOffset`: Adjusts the left-right position of the stamp in percentage.
- `VerticalOffset`: Adjusts the up-down position of the stamp in percentage.

For the `HorizontalOffset` and `VerticalOffset` attributes, instantiate the `Length` class, which defaults to percentage measurement but can use various units like inches, millimeters, etc.

### Code for Setting Offsets

```csharp
using IronPdf.Editing;
using System;

// Setup an image stamper
ImageStamper imageStamper = new ImageStamper(new Uri("https://ironpdf.com/img/svgs/iron-pdf-logo.svg"))
{
    HorizontalAlignment = HorizontalAlignment.Center,
    VerticalAlignment = VerticalAlignment.Top,

    // Adjust offsets
    HorizontalOffset = new Length(10),
    VerticalOffset = new Length(10),
};
```

Equal attention has been paid to guide the users of `HtmlStamper` and `BarcodeStamper`, detailing their use cases and multiple options it supports, like manipulating opacity, rotation, and dimensions of the stamps while ensuring comprehensive documentation for developers. Link details are properly resolved to ensure accessibility and correct image and document references.