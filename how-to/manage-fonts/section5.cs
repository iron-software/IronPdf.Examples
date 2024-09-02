using IronPdf;
using IronPdf.Fonts;

// Import PDF
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Get fonts
PdfFontCollection fonts = pdf.Fonts;

// Unembed a font
pdf.Fonts[0].Unembed();