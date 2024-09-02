using IronPdf;
using IronPdf.Fonts;
using System.Linq;

// Import PDF
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

byte[] fontData = System.IO.File.ReadAllBytes("dir/to/font.ttf");
// Get and replace Font
pdf.Fonts["Courier"].ReplaceWith(fontData);