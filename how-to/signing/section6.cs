using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("invoice.pdf");
pdf.RemoveSignatures();