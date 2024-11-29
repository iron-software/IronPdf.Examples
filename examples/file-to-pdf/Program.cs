using IronPdf;

// Instantiate Renderer
var renderer = new ChromePdfRenderer();

// Create a PDF from an existing HTML file using C#
var pdf = renderer.RenderHtmlFileAsPdf("example.html");

// Export to a file or Stream
pdf.SaveAs("output.pdf");
