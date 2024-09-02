using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("table.pdf");

// Compress tree structure in PDF
pdf.CompressStructTree();

pdf.SaveAs("compressedTable.pdf");