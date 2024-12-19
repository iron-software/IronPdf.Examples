# Managing Fonts in PDF Documents

***Based on <https://ironpdf.com/how-to/manage-fonts/>***


Fonts, consisting of various characters, symbols, and glyphs that share a consistent style and design, play a critical role in typography, making text visually appealing and cohesive. Each font represents a specific typeface, size, weight, and style (like bold or italic).

IronPDF simplifies the process of handling fonts through features that allow users to find, retrieve, embed, unembed, and replace fonts within PDF documents.

## Font Retrieval and Searching

### Retrieving Fonts

To obtain a list of all fonts within a PDF document, you can access the `Fonts` property. This property returns a `PdfFontCollection` object and can be easily iterated:

```cs
using IronPdf;
using IronPdf.Fonts;

// Load a PDF document
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Retrieve fonts
PdfFontCollection fonts = pdf.Fonts;
```

### Finding a Specific Font

To locate a particular font by name within the `PdfFontCollection`, use the font name indexed like so: `Fonts["SpecificFontName"]`. This returns a `PdfFont` object that can be used further:

```cs
using IronPdf;
using IronPdf.Fonts;

// Load a PDF document
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Find a specific font
PdfFont font = pdf.Fonts["SpecialFontName"];
```

## Adding Fonts

Fonts can be added using the `Add` method. This method allows the addition of both standard and custom fonts (from byte data). When a standard font is added, it does not need to be embedded since it's guaranteed to be available on the operating system.

```cs
using IronPdf;
using IronPdf.Fonts;

// Load PDF document
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Add a standard font
pdf.Fonts.Add("Helvetica");
```

## Embedding Fonts

Embedding a font includes its byte stream data directly in the PDF, eliminating the need for the font to be installed on the viewing system. This is useful for ensuring visual consistency across different systems, although it might increase the PDF's file size.

```cs
using IronPdf;
using IronPdf.Fonts;

// Load the PDF document
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Choose the font to embed
PdfFont customFont = pdf.Fonts["MyCustomFont"];
byte[] fontData = System.IO.File.ReadAllBytes("dir/to/font.ttf");

// Add and embed the font
pdf.Fonts.Add(fontData);
pdf.Fonts.Last().Embed(fontData);
```

## Unembedding Fonts

To reduce the size of a PDF document, you can remove the embedded font data using the `Unembed` method.

```cs
using IronPdf;
using IronPdf.Fonts;

// Load the PDF document
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Access fonts
PdfFontCollection fonts = pdf.Fonts;

// Unembed a font
pdf.Fonts[0].Unembed();
```

## Replacing Fonts

Replacing a font in a PDF retains its original data structure (like style and encoding) but updates it to a new specified font. This method may not always result in a visually perfect match due to the method's limitations.

```cs
using IronPdf;
using IronPdf.Fonts;

// Load the PDF document
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

byte[] newFontData = System.IO.File.ReadAllBytes("dir/to/font.ttf");

// Replace a font
pdf.Fonts["Courier"].ReplaceWith(newFontData);
```

## Standard Fonts Overview

PDFs support 14 'Base 14 Fonts' or 'Standard Type 1 Fonts' which are widely supported across platforms and do not need embedding. Here's an overview of these standard fonts and their mappings:

- **Courier Variants**
  - `Courier`, `CourierNew`, `CourierNewPSMT`, `CourierStd`
  - Bold, Oblique, BoldOblique versions

- **Helvetica Variants**
  - `Arial`, `ArialMT`, `Helvetica`
  - Bold, Oblique, BoldOblique versions

- **Times Variants**
  - `TimesNewRoman`, `TimesNewRomanPS`, `TimesNewRomanPSMT`, `Times`
  - Bold, Italic, BoldItalic versions

- **Other Fonts**
  - `Symbol`, `SymbolMT`
  - `ZapfDingbats`

The extensive support for both standard and custom fonts within IronPDF facilitates robust PDF manipulation, ensuring high levels of customization and functional diversity in managing document fonts.