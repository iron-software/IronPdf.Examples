using IronPdf;

// Select the desired PDF File
PdfDocument pdf = PdfDocument.FromFile("before.pdf");

// Flatten the pdf
pdf.Flatten();

// Save as a new file
pdf.SaveAs("after_flatten.pdf");