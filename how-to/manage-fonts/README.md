# Managing Fonts in PDF Documents

***Based on <https://ironpdf.com/how-to/manage-fonts/>***


A font consists of characters, symbols, and glyphs designed in a unified style, representing a particular typeface that includes specifications like size, weight, and style (such as regular, bold, italic, etc.). Fonts play a crucial role in typography, helping to present text in a visually appealing and consistent manner.

IronPDF offers robust capabilities for handling fonts, including searching, retrieving, embedding, unembedding, and replacing fonts within PDF documents.

## Searching and Retrieving Fonts

### Retrieving Fonts

To fetch all the fonts used in a PDF document, you can leverage the `Fonts` property. This property returns the `PdfFontCollection` object, which houses a list of all fonts contained in the specific document. You can access this collection by iterating over the `PdfFontCollection` object directly.

```cs
using System.Collections.Generic;
using IronPdf;
namespace ironpdf.ManageFonts
{
    public class RetrieveFonts
    {
        public void Execute()
        {
            // Load the PDF document
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

            // Retrieve fonts collection
            PdfFontCollection fonts = pdf.Fonts;
        }
    }
}
```

### Finding a Specific Font

To locate a particular font within the `PdfFontCollection`, simply provide the name of the font in square brackets, like `Fonts["YourFontName"]`. This retrieves a `PdfFont` object, which you can use to explore properties and invoke methods.

```cs
using System.Linq;
using IronPdf;
namespace ironpdf.ManageFonts
{
    public class FindFonts
    {
        public void Execute()
        {
            // Load the PDF document
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

            // Find and fetch a specific font
            PdfFont font = pdf.Fonts["SpecialFontName"];
        }
    }
}
```

## Adding Fonts to PDF

To add fonts, use the `Add` method. You can add both standard fonts and custom fonts (from byte data). Note that adding a [standard font](#anchor-standard-fonts) does not embed it into the PDF, as their presence is assumed on most operating systems.

```cs
using IronPdf.Fonts;
using IronPdf;
namespace ironpdf.ManageFonts
{
    public class AddFonts
    {
        public void Execute()
        {
            // Load the PDF document
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

            // Add a standard font
            pdf.Fonts.Add("Helvetica");
        }
    }
}
```

## Embedding Fonts in PDF

Embedding a font entails including the font's byte stream data directly into the PDF, ensuring the document is displayed as intended without requiring the font to be installed on the local system. This typically increases the document's size but is beneficial for maintaining visual consistency.

```cs
using System.Linq;
using IronPdf;
namespace ironpdf.ManageFonts
{
    public class EmbedFonts
    {
        public void Execute()
        {
            // Load the PDF document
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

            // Select the font to embed
            PdfFont targetFont = pdf.Fonts["MyCustomFont"];

            // Read font data from a file
            byte[] fontData = System.IO.File.ReadAllBytes("dir/to/font.ttf");

            // Add and embed the font in the document
            pdf.Fonts.Add(fontData);
            pdf.Fonts.Last().Embed(fontData);
        }
    }
}
```

## Unembedding Fonts

To reduce the file size of a PDF, consider unembedding fonts. This removes the embedded font data from the PDF. Use the `Unembed` method on the `PdfFont` object to achieve this.

```cs
using IronPdf.Fonts;
using IronPdf;
namespace ironpdf.ManageFonts
{
    public class UnembedFonts
    {
        public void Execute()
        {
            // Load the PDF document
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

            // Fetch the fonts collection
            PdfFontCollection fonts = pdf.Fonts;

            // Unembed the first font
            pdf.Fonts[0].Unembed();
        }
    }
}
```

## Replacing Fonts in PDF

Replacing a font within a PDF substitutes the original with a specified new font. This process retains the original font’s style and structure but updates the character encoding to that of the new font. Discrepancies in visual appearance may arise due to limitations of the replacement method.

```cs
using System.Linq;
using IronPdf;
namespace ironpdf.ManageFonts
{
    public class ReplaceFonts
    {
        public void Execute()
        {
            // Load the PDF document
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

            // Read font data from a file
            byte[] fontData = System.IO.File.ReadAllBytes("dir/to/font.ttf");

            // Replace the existing font with a new one
            pdf.Fonts["Courier"].ReplaceWith(fontData);
        }
    }
}
```

## Overview of Standard Fonts in PDF

The PDF specification ensures the availability of 14 standard fonts, also known as 'Base 14 Fonts' or 'Standard Type 1 Fonts,' across all PDF viewers. These fonts do not require embedding due to their universal support.

### Standard Fonts and Their Mappings

The standard fonts include families like Courier, Helvetica, Times, and others, with several aliases pointing to the same base font for convenient reference. Each family has variants such as bold, italic, and bold-italic, along with specific mappings for each variant.

**Mapping of Standard Fonts**:

- **Courier**
  - StandardFont.Courier
  - Courier
  - CourierNew
  - CourierNewPSMT
  - CourierStd
- **Courier-Bold**
  - StandardFont.CourierBold
  - Courier, Bold
  - Courier-Bold
  - CourierBold
  - CourierNew, Bold
  - CourierNew-Bold
  - CourierNewBold
  - CourierNewPS-BoldMT
  - CourierStd-Bold

... _[Continued mappings for all font families]_

This comprehensive management of fonts ensures that documents adhere to design specifications across different viewing platforms, maintaining stylistic and operational integrity.