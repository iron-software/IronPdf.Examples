using IronPdf;

// Instantiate Renderer
var renderer = new ChromePdfRenderer();

// Create a PDF from a URL or local file path
var pdf = renderer.RenderUrlAsPdf("https://ironpdf.com/");

// Export to a file or Stream
pdf.SaveAs("url.pdf");
