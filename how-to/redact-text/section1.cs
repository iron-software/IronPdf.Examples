using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("novel.pdf");

// Redact 'are' phrase from all pages
pdf.RedactTextOnAllPages("are");

pdf.SaveAs("redacted.pdf");