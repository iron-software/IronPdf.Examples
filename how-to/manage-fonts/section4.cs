using IronPdf;
using IronPdf.Fonts;
using System.Linq;

// Import PDF
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Select which font to embed
PdfFont targetFont = pdf.Fonts["MyCustomFont"];

// Add the font
byte[] fontData = System.IO.File.ReadAllBytes("dir/to/font.ttf");
pdf.Fonts.Add(fontData);

// Embed the font
pdf.Fonts.Last().Embed(fontData);