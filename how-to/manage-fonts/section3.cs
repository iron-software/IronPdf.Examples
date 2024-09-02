using IronPdf;
using IronPdf.Fonts;

// Import PDF
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Add font
pdf.Fonts.Add("Helvetica");