using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("Invoice.pdf", "password");

// Get all text
string text = pdf.ExtractAllText();