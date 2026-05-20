# Manipulating PDF DOM Objects

***Based on <https://ironpdf.com/how-to/access-pdf-dom-object/>***


Manipulating the PDF DOM involves interacting with the structure of a PDF document in ways similar to handling webpage DOMs. The DOM of a PDF is a structured representation of its content which enables developers to programmatically modify various components such as text, images, annotations, and metadata.

## Quickstart: Utilizing IronPDF to Handle PDF DOM Elements

Easily manage your PDF files by leveraging the robust DOM manipulation capabilities of IronPDF. This introductory guide will walk you through the process of obtaining PDF DOM, selecting a specific page, and adjusting text elements. Start by loading your document, selecting the page of interest, and then modifying it using a few simple lines of code. This guide is ideal for developers who want to efficiently handle PDFs without complicated setups.

```cs
:title=Efficiently Handle PDF DOM with IronPDF
var domObjects = IronPdf.ChromePdfRenderer.RenderUrlAsPdf("https://example.com").Pages.First().ObjectModel;
```

## Example: Interacting with DOM Objects

To access the `ObjectModel` you must first load the PDF and refer to the `Pages` property. Select any page to gain access to the `ObjectModel`.

```csharp
using IronPdf;
using System.Linq;

// Create a new Renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Generate a PDF from a URL
PdfDocument document = renderer.RenderUrlAsPdf("https://ironpdf.com/");

// Work with DOM Objects
var pageObjects = document.Pages.First().ObjectModel;
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
        <img src="https://ironpdf.com/static-assets/pdf/how-to/access-pdf-dom-object/debug.webp" alt="Debug" class="img-responsive add-shadow">
    </div>
</div>

The **ObjectModel** houses elements such as **ImageObject**, **PathObject**, and **TextObject**. Each type of object includes details like the page index, bounding boxes, and transformation properties, all of which are editable.

`ImageObject`:

- `Height` – The image's height.
- `Width` – The image's width.
- `ExportBytesAsJpg` – Exports the image in JPG format as a byte array.

`PathObject`:

- `FillColor` – The fill color.
- `StrokeColor` – The stroke color.
- `Points` – Points that define the path contours.

`TextObject`:

- `Color` – Text color.
- `Contents` – The actual text.

### Fetching Glyph Data and bounding boxes

To ensure accurate depiction of text, especially when using custom fonts, use IronPDF to fetch glyph and bounding box details. This can be achieved by accessing the **TextObjects** from the **ObjectModel** of a **PdfPage**.

```cs
using IronPdf;
using System.Linq;

PdfDocument pdf = PdfDocument.FromFile("invoice.pdf");

var glyphDetails = pdf.Pages.First().ObjectModel.TextObjects.First().GetGlyphInfo();
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/access-pdf-dom-object/glyphinformation.webp" alt="Glyph Information" class="img-responsive add-shadow">
    </div>
</div>

<hr>

## Moving PDF Objects

Adjusting the position of PDF elements is straightforward with the `Translate` property. This example centers text using CSS Flexbox before moving the "Centered" text block on the page using translation coordinates.

### Practical Illustration

```csharp
using IronPdf;
using System.Drawing;
using System.Linq;

// Initialize Renderer
var renderer = new ChromePdfRenderer();

// HTML string to be rendered as PDF with centered text
var html = @"
<div style='display: flex; justify-content: center; align-items: center; font-size: 48px;'>
    Centered
</div>";

// Convert HTML to PDF
PdfDocument pdf = renderer.RenderHtmlAsPdf(html);

// Save Initial PDF
pdf.SaveAs("BeforeTranslate.pdf");

// Modify Text Position
var textBlock = pdf.Pages.First().ObjectModel.TextObjects.First();
textBlock.Translate = new PointF(200, -150);

// Save Altered PDF
pdf.SaveAs("AfterTranslate.pdf");
```

### Result

The text "Centered" has been moved 200 points to the right and 150 points up from its original position.

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/access-pdf-dom-object/translate.webp" alt="Translate object" class="img-responsive add-shadow">
    </div>
</div>

<hr>

## Resizing PDF Objects

Alter the size of any PDF element using the `Scale` property. This demonstration reduces an `ImageObject` to 70% of its original dimensions.

### Execution Steps

```csharp
using IronPdf;
using System.Drawing;
using System.Linq;

// Establish Renderer
var renderer = new ChromePdfRenderer();

// HTML with an image component
string imgHtml = @"<img src='https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTi8LuOR6_A98euPLs-JRwoLU7Nc31nVP15rw&s'>";

// Convert HTML to PDF
PdfDocument scaledPdf = renderer.RenderHtmlAsPdf(imgHtml);

// Store PDF for baseline comparison
scaledPdf.SaveAs("BeforeScale.pdf");

// Adjust Image Size
var image = scaledPdf.Pages.First().ObjectModel.ImageObjects.First();
image.Scale = new PointF(0.7f, 0.7f);

// Save Resulting PDF
scaledPdf.SaveAs("AfterScale.pdf");
```

### Display

The image is resized to 70% of its original dimensions.

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/access-pdf-dom-object/scale.webp" alt="Scale object" class="img-responsive add-shadow">
    </div>
</div>

<hr>

## Delete PDF Objects

Easily remove elements from your PDF by manipulating the DOM object collections like `ImageObjects` or `TextObjects`. Use the `RemoveAt` technique to delete the desired object.

Below is the method for removing the first image from a document.

```csharp
using IronPdf;
using IronSoftware.Pdfium.Dom;
using System.Linq;

// Loading previously scaled PDF
PdfDocument removalPdf = PdfDocument.FromFile("BeforeScale.pdf");

// Access and modify DOM
IPdfPageObjectModel pageElements = removalPdf.Pages.First().ObjectModel;
pageElements.ImageObjects.RemoveAt(0);

// Save the changes
removalPdf.SaveAs("removedFirstImage.pdf");
```

Explore more capabilities by visiting our comprehensive guide here: [Manipulate PDFs](https://ironpdf.com/tutorials/csharp-edit-pdf-complete-tutorial/)