using IronPdf;

// Instantiate Renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Render from RTF file
PdfDocument pdf = renderer.RenderRtfFileAsPdf("sample.rtf");

// Save the PDF
pdf.SaveAs("pdfFromRtfFile.pdf");