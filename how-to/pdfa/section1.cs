using IronPdf;

// Create a PdfDocument object or open any PDF File
PdfDocument pdf = PdfDocument.FromFile("wikipedia.pdf");

// Use the SaveAsPdfA method to save to file
pdf.SaveAsPdfA("pdf-a3-wikipedia.pdf", PdfAVersions.PdfA3b);