var pdf = new PdfDocument("document.pdf");

pdf.CompressImages(90, true);
pdf.SaveAs("document_scaled_compressed.pdf");