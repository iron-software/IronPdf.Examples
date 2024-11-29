using IronPdf;

// Instantiate Renderer
var renderer = new ChromePdfRenderer();

// All IronPdf Rendering methods have Async equivalents
var pdf = await renderer.RenderHtmlAsPdfAsync("<h1>Html with CSS and Images</h1>");

// Export to a file or Stream
pdf.SaveAs("async_example.pdf");
