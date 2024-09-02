using IronPdf;

// Instantiate Renderer
var renderer = new ChromePdfRenderer();

// Create a PDF from a HTML string using C#
var pdf = renderer.RenderHtmlAsPdf(imageTag);

// Export to a file
pdf.SaveAs("imageToPdf.pdf");