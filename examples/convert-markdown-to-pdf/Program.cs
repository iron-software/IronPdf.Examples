using IronPdf;

// Instantiate Renderer
var renderer = new ChromePdfRenderer();

// Either load your Markdown file directly
PdfDocument pdfFromMarkdownFile = renderer.RenderMarkdownFileAsPdf("/files/documentation.md");

// Or instead, load it as a string
PdfDocument pdfFromMarkdownString = renderer.RenderMarkdownStringAsPdf("# Documentation\nIn this document...");

// Save your PDF
pdfFromMarkdownFile.SaveAs("document.pdf");
