using IronPdf;

// Create a PDF from any existing web page
ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Portable_Document_Format");
pdf.SaveAs("wikipedia.pdf");