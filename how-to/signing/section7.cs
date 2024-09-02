using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("annual_census.pdf");
bool isValid = pdf.VerifyPdfSignatures();