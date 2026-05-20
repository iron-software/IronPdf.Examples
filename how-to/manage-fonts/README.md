# Managing Fonts in PDF Documents

***Based on <https://ironpdf.com/how-to/manage-fonts/>***


Fonts, which include characters, symbols, and glyphs, are key to maintaining the visual style and design consistency across documents. They allow text to be displayed attractively and coherently in documents.

IronPDF supports comprehensive font management tools, enabling developers to easily manage font operations such as embedding, finding, retrieving, adding, and unembedding fonts in PDFs.

## Quickstart: Managing and Embedding Fonts

IronPDF simplifies font management in PDF files. In the following tutorial, we’ll show you how to ensure that your PDF displays consistently on all platforms by embedding fonts. This can significantly improve your document's readability and viewer compatibility since no additional font installations are required.

```cs
:title=Quickly add and embed a custom font!
var pdf = PdfDocument.FromHtml("<p style='font-family:MyCustomFont;'>Hello world!</p>");
pdf.Fonts.Add("MyCustomFont", File.ReadAllBytes("MyCustomFont.ttf"))
  .Embed()
  .SaveAs("embeddedFontExample.pdf");
```

## Finding and Retrieving Fonts

### Retrieving Fonts

You can obtain a collection of fonts in a document by accessing the `Fonts` property, which returns the `PdfFontCollection`.

```csharp
using IronPdf;
using IronPdf.Fonts;

// Load a PDF file
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Retrieve fonts
PdfFontCollection fonts = pdf.Fonts;
```

### Finding Specific Fonts

To find a particular font in the `PdfFontCollection`, you can reference it by name. This allows you to check properties of specific fonts used in the document.

```csharp
using IronPdf;
using IronPdf.Fonts;

// Load a PDF file
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Find a specific font
PdfFont font = pdf.Fonts["SpecialFontName"];
```

## Adding Fonts

You can add fonts to your PDF file using the `Add` method. While adding standard fonts doesn’t require embedding since they're generally available on most systems, custom fonts can also be included via byte data.

```csharp
using IronPdf;
using IronPdf.Fonts;

// Load a PDF file
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Add a standard font
pdf.Fonts.Add("Helvetica");
```

## Embedding Fonts

Embedding fonts in a PDF ensures the document can be properly displayed on any system, even those without the font installed. This can slightly increase the PDF size but is crucial for maintaining the intended design.

```csharp
using IronPdf;

// Load a PDF file
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Add and embed a custom font
byte[] fontData = System.IO.File.ReadAllBytes("dir/to/font.ttf");
pdf.Fonts.Last().Embed(fontData);
```

## Unembedding Fonts

Removing embedded fonts from a PDF can help decrease the file size. Be cautious, as this might affect how the PDF is displayed if the font is not available on the viewing system.

```csharp
using IronPdf;
using IronPdf.Fonts;

// Load a PDF file
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Get fonts and unembed one
PdfFontCollection fonts = pdf.Fonts;
pdf.Fonts[0].Unembed();
```

When unembedding fonts, if you encounter display issues similar to what might occur in other software like Adobe, this indicates the font's unique properties are required for proper display.

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/unembed-fonts-from-pdf/failed-display.webp" alt="Corrupted font PDF" class="img-responsive add-shadow">
    </div>
</div>

## Replacing Fonts

Font replacement maintains the visual consistency of your PDF while allowing the replacement of specific font data. This operation must be handled with care to ensure the replacement font effectively matches the original.

```csharp
using IronPdf;
using IronPdf.Fonts;

// Load a PDF file
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Retrieve and replace a font
byte[] fontData = System.IO.File.ReadAllBytes("dir/to/font.ttf");
pdf.Fonts["Courier"].ReplaceWith(fontData);
```

### Overview of Standard Fonts

Standard fonts, or 'Base 14 Fonts', are universally supported across all PDF viewing platforms. Here’s a detailed list and mapping of these fonts to IronPDF's convenient format identifiers.

(Standard fonts mapping and details go here)

**Map to StandardFont.Courier**

- `Courier`
- `CourierNew`
- `CourierNewPSMT`
- `CourierStd`

*and so forth for each font mapping...*

By using IronPDF's font management capabilities, you can ensure your PDF documents are visually consistent and properly display custom typography, enhancing readability and accessibility.