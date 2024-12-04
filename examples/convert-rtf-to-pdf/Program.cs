using IronPdf;

// Instantiate Renderer
var renderer = new ChromePdfRenderer();

// Either load your RTF file directly
PdfDocument pdfFromRtfFile = renderer.RenderRtfFileAsPdf("/files/doc.rtf");

// Or instead, load it as a string
PdfDocument pdfFromRtfString = renderer.RenderRtfStringAsPdf("{/rtf..");

// Save your PDF
pdfFromRtfFile.SaveAs("document.pdf");
