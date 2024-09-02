# Stamping Text & Images onto PDF Documents

Stamping text and images onto PDFs is the process of adding extra content, referred to as a "stamp", which may consist of text, images, or both. Stamps are frequently utilized to append additional information such as labels, watermarks, or notes to PDF files.

IronPdf provides four different types of stamping tools, which include **TextStamper**, **ImageStamper**, **HTMLStamper**, and **BarcodeStamper**. The **HTMLStamper** is especially versatile because it incorporates full HTML and CSS capability.

## Text Stamping Example

Start by initializing a **TextStamper** instance. This instance allows you to customize various attributes such as the text content, font, styling, and position of the stamp within the PDF.

```cs
using IronPdf;
using IronPdf.Editing;

// Render a simple HTML to PDF
ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Example HTML Document!</h1>");

// Initialize the text stamper with custom settings
TextStamper textStamper = new TextStamper()
{
    Text = "Text Stamper!",
    FontFamily = "Bungee Spice",
    UseGoogleFont = true,
    FontSize = 30,
    IsBold = true,
    IsItalic = true,
    VerticalAlignment = VerticalAlignment.Top,
};

// Applying the stamper to the PDF
pdf.ApplyStamp(textStamper);

// Save the PDF with stamped text
pdf.SaveAs("stampText.pdf");
```

### Sample Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/stamp-text-image/stampText.pdf" width="100%" height="400px">
</iframe>

For multiline text in `TextStamper`, simply use the `<br>` tag like in HTML to format text across multiple lines.

<hr>

## Image Stamping Example

First, instantiate the **ImageStamper** class. The method `ApplyStamp` can then be used to apply this stamper onto specified page(s) of the document. Here, we apply an image stamp to the first page.

```cs
using IronPdf;
using IronPdf.Editing;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Example HTML Document!</h1>");

// Initialize the image stamper
ImageStamper imageStamper = new ImageStamper(new Uri("https://ironpdf.com/img/svgs/iron-pdf-logo.svg"))
{
    VerticalAlignment = VerticalAlignment.Top,
};

// Apply the image stamper to the first page
pdf.ApplyStamp(imageStamper, 0);

// Save the PDF with the image stamp
pdf.SaveAs("stampImage.pdf");
```

### Sample Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/stamp-text-image/stampImage.pdf" width="100%" height="400px">
</iframe>

<hr>

## Applying Multiple Stamps

The `ApplyMultipleStamps` method allows for the application of several stampers at once by passing an array of stampers.

```cs
using IronPdf;
using IronPdf.Editing;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Example HTML Document!</h1>");

// Create two TextStampers
TextStamper stamper1 = new TextStamper()
{
    Text = "Text stamp 1",
    VerticalAlignment = VerticalAlignment.Top,
    HorizontalAlignment = HorizontalAlignment.Left,
};

TextStamper stamper2 = new TextStamper()
{
    Text = "Text stamp 2",
    VerticalAlignment = VerticalAlignment.Top,
    HorizontalAlignment = HorizontalAlignment.Right,
};

Stamper[] stampersToApply = { stamper1, stamper2 };

// Apply multiple stampers
pdf.ApplyMultipleStamps(stampersToApply);

// Save the PDF
pdf.SaveAs("multipleStamps.pdf");
```

### Sample Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/stamp-text-image/multipleStamps.pdf" width="100%" height="400px">
</iframe>

<hr>

## Defining Stamp Placement

To determine the stamp's location, use a 3x3 grid system with options for horizontal and vertical alignments and offsets. Below is a guide image:

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/stamp-text-image/stamp-location.webp" alt="Stamp location" class="img-responsive add-shadow">
    </div>
</div>

Properties like **HorizontalAlignment** and **VerticalAlignment** help position the stamp, while **HorizontalOffset** and **VerticalOffset** adjust its exact location.

### Example Configuration

```cs
using IronPdf.Editing;
using System;

// Initialize an image stamper with defined alignment and offset
ImageStamper imageStamper = new ImageStamper(new Uri("https://ironpdf.com/img/svgs/iron-pdf-logo.svg"))
{
    HorizontalAlignment = HorizontalAlignment.Center,
    VerticalAlignment = VerticalAlignment.Top,

    // Define offsets
    HorizontalOffset = new Length(10),
    VerticalOffset = new Length(10),
};
```

<hr>

## HTML Stamping

The `HtmlStamper` class renders HTML/CSS designs onto the PDF. You can specify the base URL for any assets referenced in the HTML.

```cs
using IronPdf;
using IronPdf.Editing;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Example HTML Document!</h1>");

// Initialize HTML stamper
HtmlStamper htmlStamper = new HtmlStamper()
{
    Html = @"<img src='https://ironpdf.com/img/svgs/iron-pdf-logo.svg'>
    <h1>Iron Software</h1>",
    VerticalAlignment = VerticalAlignment.Top,
};

// Apply the HTML stamper
pdf.ApplyStamp(htmlStamper);

// Save the stamped PDF
pdf.SaveAs("stampHtml.pdf");
```

Properties like **HtmlBaseUrl** and **CssMediaType** adjust how the HTML content interacts with external resources and styles.

<hr>

## Barcode Stamping

Stamp barcodes onto PDFs using the `BarcodeStamper` class, supporting several barcode types.

```cs
using IronPdf;
using IronPdf.Editing;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Example HTML Document!</h1>");

// Create barcode stamper with specified settings
BarcodeStamper barcodeStamper = new BarcodeStamper("IronPdf!!", BarcodeEncoding.Code39)
{
    VerticalAlignment = VerticalAlignment.Top,
};

// Apply the barcode stamper
pdf.ApplyStamp(barcodeStamper);

// Save the PDF
pdf.SaveAs("stampBarcode.pdf");
```

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/stamp-text-image/stampBarcode.pdf" width="100%" height="300px">
</iframe>

Additional options like **Opacity**, **Rotation**, and **Scale** can be configured to further customize the appearance and behavior of stamps.

<hr>

## Exploring Additional Stamper Features

Beyond the previously discussed features, stamper classes in IronPdf offer numerous other customization options such as setting opacity, size limits, rotation angles, hyperlink functionalities, scaling, and optionally rendering stamps behind the document content.