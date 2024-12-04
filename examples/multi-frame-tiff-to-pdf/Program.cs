using IronPdf;

//Convert a TIFF with 1 or more pages to a PDF
var pdf = ImageToPdfConverter.ImageToPdf("assets/multipage_tiff_example.tif");

// Export to a file or Stream
pdf.SaveAs("output/multi-page-pdf.pdf");
