using IronPdf;
using IronPdf.Fonts;
using System.Collections.Generic;
using System.Linq;

// Import PDF
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Find font
PdfFont font = pdf.Fonts["SpecialFontName"];