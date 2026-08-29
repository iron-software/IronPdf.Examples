# Drawing Text and Bitmaps on PDFs

> Full guide: [Drawing Text and Bitmaps on PDFs](https://ironpdf.com/how-to/draw-text-and-bitmap/)


Adding text and bitmap images to PDF documents is a common requirement for customizing and enhancing existing files. Using IronPDF, this process is smooth and efficient, making it easy to incorporate elements like watermarks, logos, and annotations. This functionality not only boosts the document’s aesthetic value and branding but also enhances data presentation and interaction through visual content and form fields.

## Getting Started: Enhancing PDFs with Text and Images Using IronPDF

Begin adding text and images to your PDFs with IronPDF to quickly enhance document presentation and functionality. The `DrawText` and `DrawBitmap` methods allow for straightforward customization. This guide illustrates how to position text at particular coordinates and embed an image into a PDF document effectively, making it ideal for developers aiming to boost the branding or visual dynamics within their applications.

```cs
new ChromePdfRenderer()
    .RenderHtmlAsPdf("<h1>Document Title</h1>")
    .DrawText("Hello World", FontTypes.TimesNewRoman.Name, 12, 0, 100, 100, Color.Black, 0)
    .DrawBitmap(AnyBitmap.FromFile("logo.png"), 0, 50, 250, 500, 300)
    .SaveAs("enhanced.pdf");
```

## Adding Text to PDFs

To add text to a PDF document without modifying its original content, use the `DrawText` method offered by the **PdfDocument** object.

```csharp
using IronPdf;
using IronSoftware.Drawing;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Example Heading</h1>");

// Adding text to the PDF
pdf.DrawText("Example text", FontTypes.TimesNewRoman.Name, 12, 0, 100, 100, Color.Black, 0);

pdf.SaveAs("textAdded.pdf");
```

### Typeface Options in IronPDF

The `DrawText` method supports a range of [Standard Fonts provided by IronPDF](https://ironpdf.com/how-to/manage-fonts/#standard-fonts), such as Courier, Arial (alternatively Helvetica), Times New Roman, Symbol, and ZapfDingbats, including their italic, bold, and oblique variations.

ZapfDingbats is particularly useful for including unique symbols like ▲. For detailed information on supported symbols, you can refer to [Zapf Dingbats on Wikipedia](https://en.wikipedia.org/wiki/Zapf_Dingbats).

#### Displaying Font Samples on PDF

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/draw-text-and-bitmap/draw-text-and-bitmap-fonts.webp" alt="Fonts Sample on PDF" class="img-responsive add-shadow">
    </div>
</div>

### Multiline Text Rendering

The draw text functionality supports newline characters, thus enabling multiline text rendering within your PDFs for enhanced format and readability.

Example of drawing text with newlines:
```csharp
string multiLineText = "First line\nSecond line";
pdfDoc.DrawText(multiLineText, font, position);
```

### Incorporating Custom Fonts

IronPDF also allows for the integration of custom fonts using the `DrawText` method, as demonstrated in the following example with custom Pixelify Sans Font.

```csharp
using IronPdf;
using IronSoftware.Drawing;
using System.IO;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Document Title</h1>");

// Loading custom font
byte[] fontData = File.ReadAllBytes("PixelifySans-VariableFont_wght.ttf");
var customFont = pdf.Fonts.Add(fontData);

// Adding custom font text to PDF
pdf.DrawText("Custom Font Example", customFont.Name, 12, 0, 100, 600, Color.Black, 0);

pdf.SaveAs("customFontExample.pdf");
```

## Embedding Images in PDFs

IronPDF’s `DrawBitmap` method makes embedding images into PDFs straightforward. This is similar to using the Image Stamper functionality, well-suited for inserting high-quality images within the documents.

### Example of Adding an Image

```csharp
using IronPdf;
using IronSoftware.Drawing;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Sample Header</h1>");

// Loading and adding image to PDF
AnyBitmap image = AnyBitmap.FromFile("ironSoftware.png");
pdf.DrawBitmap(image, 0, 50, 250, 500, 300);

pdf.SaveAs("imageAdded.pdf");
```

### Additional Options for Drawing Bitmaps

The draw image process provides several parameters such as `PixelFormat` and `IgnorePageRotation` to customize how images are handled within the PDF, enhancing flexibility across different use cases.

Discover more ways to manipulate PDFs with our complete tutorial here: [C# PDF Editing Tutorial](https://ironpdf.com/tutorials/csharp-edit-pdf-complete-tutorial/).