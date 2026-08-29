# How to Edit PDFs in C#

> Full guide: [How to Edit PDFs in C#](https://ironpdf.com/tutorials/csharp-edit-pdf-complete-tutorial/)

IronPDF edits PDF documents from .NET: signatures, HTML footers, watermarks, and annotations. The same code deploys across platforms.

IronPDF is rich with functionalities for modifying PDF files. This article will guide you through some key features, accompanied by relevant examples to illustrate their uses.

By the end of this tutorial, you'll be adept at utilizing IronPDF to modify PDF files using C#.

## Quick Start: Modify Your PDF Files

Quickly and efficiently modify PDF files in C# with IronPDF. This brief guide will demonstrate how to add a text stamp to a PDF document. In just a few lines of code, you can alter your PDF and save the modifications immediately. Ideal for developers looking for a quick and effective PDF modification solution.

```cs
var pdf = IronPdf.PdfDocument.FromFile("example.pdf");
pdf.ApplyStamp(new IronPdf.Editing.TextStamper("Confidential"));
pdf.SaveAs("edited_example.pdf");
```

## Table of Contents

- **Structure Modifications**
  - [Interact with PDF DOM](#interact-with-pdf-dom)
  - Preserve & Export PDFs
  - [Initiate PDFs from Memory](#initiate-pdfs-from-memory)
  - [Send PDFs to Memory](#send-pdfs-to-memory)
- **Property Editing**
  - [Analyze PDFs in C#](#analyze-pdfs-in-c)
  - Retrieve Text & Images
  - Censor Text & Areas
  - [Amend Text in PDF](#amend-text-in-pdf)
- **Design Enhancement**
  - Insert & Modify Annotations
  - Impose Text & Images
  - [Design Custom Watermarks](#design-custom-watermarks)
  - Configure Backgrounds & Foregrounds
  - Implement Text & Graphics
  - Sketch Lines & Shapes
  - [Alter Text and Page Orientation](#alter-text-and-page-orientation)
  - [Adjust PDF Pages](#adjust-pdf-pages)

## Modify Document Structure

### Interact with PDF DOM

Quickly and easily manipulate PDF elements using IronPDF. The library makes interacting with PDF DOM objects as straightforward as manipulating a webpage's DOM, enabling developers to modify text and other elements programmatically.

```cs
using IronPdf;
using System.Linq;

// Create a Renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Generate PDF from a URL
PdfDocument pdf = renderer.RenderUrlAsPdf("https://ironpdf.com/");

// Interact with DOM Objects
var objects = pdf.Pages.First().ObjectModel;
```

For more details and additional functions, please visit our complete [guide](https://ironpdf.com/how-to/access-pdf-dom-object/).

### Preserve & Export Documents

IronPDF facilitates the quick saving and exporting of your edited documents using `PdfDocument.SaveAs`, supporting various formats like Binary Data and Memory Streams.

Visit our detailed [guide](https://ironpdf.com/how-to/export-save-pdf-csharp/) for further information and more functions.

### Initiate PDFs from Memory

IronPDF loads and creates PDFs from memory through `MemoryStream`, which fits into an existing C# .NET application without changes.

```cs
using IronPdf;
using System.IO;

// Read bytes from a PDF file
var fileByte = File.ReadAllBytes("sample.pdf");

// Create PDF from memory stream
PdfDocument pdf = new PdfDocument(fileByte);
```

Explore additional functions in our detailed [guide](https://ironpdf.com/how-to/pdf-memory-stream/).

### Send PDFs to Memory

Exporting PDFs to a memory stream within C# .NET applications is facilitated by IronPDF, allowing further manipulation and storage flexibility.

```cs
using IronPdf;
using System.IO;

var renderer = new ChromePdfRenderer();

// Convert a URL to PDF
PdfDocument pdf = renderer.RenderUrlAsPdf("https://ironpdf.com/");

// Stream PDF content
MemoryStream pdfAsStream = pdf.Stream;

// Or, get byte data
byte[] pdfAsByte = pdf.BinaryData;
```

For complete instructions and additional use cases, visit our detailed [guide](https://ironpdf.com/how-to/pdf-to-memory-stream/).

## Document Text Editing

### Analyze PDFs in C#

The `ExtractAllText` method pulls the text out of a PDF file.

```cs
using IronPdf;

// Choose PDF
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Retrieve all text
string allText = pdf.ExtractAllText();

// Get text from first page
string page1Text = pdf.ExtractTextFromPage(0);
```

Refer to our comprehensive [guide](https://ironpdf.com/how-to/csharp-parse-pdf/) for more details and functions.

### Retrieve Text & Images

IronPDF not only pulls text from PDFs but also simplifies the extraction of images. Using the `ExtractAllImages` feature, you can conveniently capture all necessary visuals.

```cs
using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Extract and save images
var images = pdf.ExtractAllImages();

for(int i = 0; i < images.Count; i++)
{
    // Save images locally
    images[i].SaveAs($"images/image{i}.png");
}
```

For the detail, see the [guide](https://ironpdf.com/how-to/extract-text-and-images/).

### Censor Text & Areas

IronPDF's `RedactTextOnAllPages` conceals specified terms across an entire document.

```cs
using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("novel.pdf");

// Apply redactions across all pages
pdf.RedactTextOnAllPages("Alaric");

pdf.SaveAs("redacted.pdf");
```

Visit our detailed [guide](https://ironpdf.com/how-to/redact-text/) for more on this feature and others.

### Amend Text in PDF

IronPDF enables the straightforward replacement of text throughout a PDF document. Use the `ReplaceTextOnAllPages` method to update text accurately and maintain the document's polished appearance.

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>.NET6</h1>");

string oldText = ".NET6";
string newText = ".NET7";

// Update text across the document
pdf.ReplaceTextOnAllPages(oldText, newText);

pdf.SaveAs("replaceText.pdf");
```

For further exploration of this feature and more, visit our [guide](https://ironpdf.com/how-to/find-replace-text/).

## Enhance PDF Design

### Insert & Modify Annotations

IronPDF's extensive PDF annotation capabilities allow you to add customized notes directly onto PDF pages. The `TextAnnotation` class provides options for title, content, positioning, and more.

```cs
using IronPdf;
using IronPdf.Annotations;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Annotation</h1>");

// Define an annotation
TextAnnotation annotation = new TextAnnotation(0)
{
    Title = "This is the title",
    Contents = "This is the long 'sticky note' comment content...",
    X = 50,
    Y = 700,
};

// Add the annotation to the PDF
pdf.Annotations.Add(annotation);
pdf.SaveAs("annotation.pdf");
```

For additional information and applications, consult our [guide](https://ironpdf.com/how-to/annotations/).

### Impose Text & Images

IronPDF offers a variety of options for stamping text and images onto PDFs. The `TextStamper` class in the example below demonstrates how to apply a text stamp to a PDF.

```cs
using IronPdf;
using IronPdf.Editing;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Example HTML Document!</h1>");

// Setup text stamper
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

// Apply the text stamp
pdf.ApplyStamp(textStamper);

pdf.SaveAs("stampText.pdf");
```

For a complete examination of this feature and others, explore our [guide](https://ironpdf.com/how-to/stamp-text-image/).

### Design Custom Watermarks

Further brand your PDF documents by integrating custom watermarks using the `ApplyWatermark` function, enhancing your professional presence.

```cs
using IronPdf;

string watermarkHtml = @"
<img src='https://ironsoftware.com/img/products/ironpdf-logo-text-dotnet.svg'>
<h1>Iron Software</h1>";

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Watermark</h1>");

// Integrate watermark
pdf.ApplyWatermark(watermarkHtml);

pdf.SaveAs("watermark.pdf");
```

Explore more about this functionality by visiting our [guide](https://ironpdf.com/how-to/custom-watermark/).

### Configure Backgrounds & Foregrounds

Customize your PDFs completely with `AddBackgroundPdf`, choosing your preferred backdrop for any PDF page.

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Main HTML content</h1>");

// Render a background
PdfDocument background = renderer.RenderHtmlAsPdf("<body style='background-color: cyan;'></body>");

// Apply the background
pdf.AddBackgroundPdf(background);

pdf.SaveAs("addBackground.pdf");
```

For more information and additional functionality, consult our [guide](https://ironpdf.com/how-to/background-foreground/).

### Implement Text & Graphics

The `DrawText` method takes the parameters needed to place text at an exact position on the page.

```cs
using IronPdf;
using IronSoftware.Drawing;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>testing</h1>");

// Add text to your PDF
pdf.DrawText("Some text", FontTypes.TimesNewRoman.Name, FontSize: 12, PageIndex: 0, X: 100, Y: 100, Color.Black, Rotation: 0);

pdf.SaveAs("drawText.pdf");
```

For more details and other capabilities, look into our [guide](https://ironpdf.com/how-to/draw-text-and-bitmap/).

### Sketch Lines & Shapes

With IronPDF, drawing lines on your documents is straightforward. Initialize line endpoints, choose parameters, and apply the `DrawLine` method as illustrated below.

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>testing</h1>");

// Set up drawing parameters
int pageIndex = 0;
var start = new IronSoftware.Drawing.PointF(200, 150);
var end = new IronSoftware.Drawing.PointF(1000, 150);
int width = 10;
var color = new IronSoftware.Drawing.Color("#000000");

// Draw a line on your PDF
pdf.DrawLine(pageIndex, start, end, width, color);

pdf.SaveAs("drawLine.pdf");
```

For a comprehensive exploration of this feature and others, visit our [guide](https://ironpdf.com/how-to/draw-line-and-rectangle/).

### Alter Text and Page Orientation

IronPDF allows you to rotate pages within a PDF, applying precise adjustments to improve layout flexibility and presentation.

```cs
using IronPdf;
using IronPdf.Rendering;
using System.Linq;

// Import a PDF
PdfDocument pdf = PdfDocument.FromFile("multi-page.pdf");

// Adjust page rotation settings
pdf.SetPageRotation(0, PdfPageRotation.Clockwise90);
pdf.SetPageRotations(Enumerable.Range(1, 3), PdfPageRotation.Clockwise270);
pdf.SetAllPageRotations(PdfPageRotation.Clockwise180);

pdf.SaveAs("rotated.pdf");
```

For rotation angle options and more, consult this [reference](https://ironpdf.com/object-reference/api/IronPdf.Rendering.PdfPageRotation.html).

For further details on this functionality, visit our [guide](https://ironpdf.com/how-to/rotating-text/).

### Adjust PDF Pages

Modify your PDF pages using `Transform` to reposition and resize contents effectively.

```cs
using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("basic.pdf");

// Alter the first page
pdf.Pages[0].Transform(50, 50, 0.8, 0.8);

pdf.SaveAs("transformPage.pdf");
```

For more details and additional functionality, check our [guide](https://ironpdf.com/how-to/transform-pdf-pages/).

## Conclusion

The examples showcased illustrate that IronPDF offers a plethora of built-in features for editing PDFs effectively.

For feature requests or queries regarding IronPDF or its licensing, do not hesitate to [contact our support team](/troubleshooting/engineering-request-pdf/). We are always here to help.