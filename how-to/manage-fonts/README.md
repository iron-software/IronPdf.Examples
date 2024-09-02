# Managing Fonts in PDF Documents

A font encompasses various characters, symbols, and glyphs that share a uniform style and design, covering aspects such as typeface, size, weight, and style (including regular, bold, italic, etc.). Fonts play an essential role in typography providing a consistent and aesthetically pleasing manner of displaying text.

IronPDF offers a suite of features that simplify font management. These features include discovering fonts, accessing font data, embedding, unembedding, and substituting fonts within your documents.

## Retrieving and Finding Fonts

### Retrieving Fonts

To retrieve all fonts in a document, access the `Fonts` property, which returns a `PdfFontCollection`. This collection includes all fonts from the document, and you can iterate over this collection directly.

```cs
using IronPdf;
using IronPdf.Fonts;

// Load PDF document
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Retrieve all fonts from the PDF
PdfFontCollection fonts = pdf.Fonts;
```

### Finding a Specific Font

To locate a particular font, utilize the `PdfFontCollection` with the specific font name enclosed in brackets, like `Fonts["SpecificFontName"]`. This returns a `PdfFont` instance, allowing for further inspection and action.

```cs
using IronPdf;
using IronPdf.Fonts;

// Load PDF document
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Locate and access a specific font
PdfFont specificFont = pdf.Fonts["SpecificFontName"];
```

## Adding Fonts

To add fonts to a PDF, use the `Add` method. This method can add standard fonts (from a select list of 14 fonts, which do not need embedding due to OS availability) or custom fonts via byte data.

```cs
using IronPdf;
using IronPdf.Fonts;

// Load PDF
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Add a standard font
pdf.Fonts.Add("Helvetica");
```

## Embedding Fonts

Embedding a font involves including its byte data directly within the PDF, ensuring the document's fonts display correctly without requiring installation on the viewing system. This enhances consistency but may increase the file's size.

```cs
using IronPdf;
using IronPdf.Fonts;

// Load PDF
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Choose the font to embed
PdfFont fontToEmbed = pdf.Fonts["CustomFontName"];

// Read font data from a file
byte[] fontData = System.IO.File.ReadAllBytes("path/to/font.ttf");

// Add and embed the font
pdf.Fonts.Add(fontData);
pdf.Fonts.Last().Embed(fontData);
```

## Unembedding Fonts

To reduce a PDF's file size, unembed fonts by removing their byte data. This is done using the `Unembed` method.

```cs
using IronPdf;
using IronPdf.Fonts;

// Load PDF
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Access fonts collection
PdfFontCollection fonts = pdf.Fonts;

// Unembed the first embedded font
pdf.Fonts[0].Unembed();
```

## Replacing Fonts

Replace a font in a PDF while preserving the original font's style and encoding. This must be done carefully to ensure the new font matches well visually.

```cs
using IronPdf;
using IronPdf.Fonts;

// Load PDF
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Read new font data
byte[] newFontData = System.IO.File.ReadAllBytes("path/to/font.ttf");

// Replace old font with new font data
pdf.Fonts["Courier"].ReplaceWith(newFontData);
```

## Understanding Standard Fonts

There are 14 widely supported standard fonts in PDFs, referred to as the 'Base 14 Fonts'. These fonts are inherently available across PDF viewers, eliminating the need for embedding.

Here's a mapping of some common aliases to their respective standard font names, facilitating easier reference and usage:

**Mapping for Courier Variants:**

- `StandardFont.Courier` maps to variants like Courier, CourierNew, and others.
- `StandardFont.CourierBold` maps to bold variants.
- `StandardFont.CourierOblique` maps to italic and oblique variants.
- `StandardFont.CourierBoldOblique` maps to bold and italic variants.

**Mapping for Helvetica Variants:**

- Includes mappings from Arial to Helvetica, in styles like regular, bold, and italic.

**Mapping for Times Variants:**

- Includes mappings from Times New Roman to Times, covering styles like regular, bold, italic, and bold italic.

**Mapping for Symbol and ZapfDingbats:**

- `StandardFont.Symbol` and `StandardFont.Dingbats` map directly to Symbol and ZapfDingbats, respectively.

This structure ensures that using standard fonts is a straightforward process, enhancing document portability and compatibility.