using IronPdf;
using IronPdf.Fonts;
using System.Collections.Generic;

// Import PDF
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Retreive font
PdfFontCollection fonts = pdf.Fonts;