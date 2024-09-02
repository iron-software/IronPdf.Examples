using IronPdf;

// Instantiate Renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Markdown string
string md = "This is some **bold** and *italic* text.";

// Render from markdown string
PdfDocument pdf = renderer.RenderMarkdownStringAsPdf(md);

// Save the PDF
pdf.SaveAs("pdfFromMarkdownString.pdf");