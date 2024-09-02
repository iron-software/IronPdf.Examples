using IronPdf;

// Import PDF document
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Sanitize with Bitmap
PdfDocument sanitizeWithBitmap = Cleaner.SanitizeWithBitmap(pdf);

// Sanitize with SVG
PdfDocument sanitizeWithSvg = Cleaner.SanitizeWithSvg(pdf);

// Export PDFs
sanitizeWithBitmap.SaveAs("sanitizeWithBitmap.pdf");
sanitizeWithSvg.SaveAs("sanitizeWithSvg.pdf");