using IronPdf;

var pdf = new PdfDocument("document.pdf");

// Quality parameter can be 1-100, where 100 is 100% of original quality
pdf.CompressImages(60);
pdf.SaveAs("document_compressed.pdf");

// Second optional parameter can scale down the image resolution according to its visible size in the PDF document. Note that this may cause distortion with some image configurations
pdf.CompressImages(90, ShrinkImage: true);
pdf.SaveAs("document_scaled_compressed.pdf");
