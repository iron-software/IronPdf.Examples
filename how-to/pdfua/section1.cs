using IronPdf;

// Open PDF File
PdfDocument pdf = PdfDocument.FromFile("wikipedia.pdf");

// Export as PDF/UA compliance PDF
pdf.SaveAsPdfUA("pdf-ua-wikipedia.pdf");